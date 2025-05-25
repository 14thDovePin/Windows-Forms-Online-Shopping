using MySqlX.XDevAPI.Common;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITEC103_Finals
{
    class API
    {
        // SQL Objects
        public MySql.Data.MySqlClient.MySqlConnection conn { get; set; }
        public MySql.Data.MySqlClient.MySqlCommand cmd { get; set; }

        public API()
        {
            // Initialize SQL Objects
            conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString());
            cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = conn;
        }

        public string ConnectionString()
        {
            // Returns the connection string required to access the database.
            string
                server = "sql12.freesqldatabase.com",
                user = "sql12780788",
                password = "pRLgjfjhA2",
                database = "sql12780788",

                connection = $"server={server};uid={user};pwd={password};database={database};";
            
            return connection;
        }

        public void ConnectDB()
        {
            // Attempts to open a connectoin to the database.
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    conn.ConnectionString = ConnectionString();
                    conn.Open();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                        "Error: Database Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DisconnectDB()
        {
            // Closes the connection to the database.
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public bool ConnectionPresent()
        {
            // Check the database connection.
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                MessageBox.Show("Database connection is closed. Changes on the server cannot be made.",
                    "Error: Database Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void RaiseSQLError(MySql.Data.MySqlClient.MySqlException ex)
        {
            // Show the currently thrown execption by SQL in a message box.
            MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataTable pullDataTable(string table_name)
        {
            // Return a datatable from the db with a given table name.

            // Setup Command for Query
            cmd.CommandText = $"SELECT * FROM {table_name}";
            cmd.Parameters.Clear();

            try
            {
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public (bool auth, int uid) AuthenticateAccount(string username, string password)
        {
            // Check the given username and password inside the system.
            // If username and password are both found, return true otherwise return false.

            try
            {
                // Pull the users data.
                DataTable dt = pullDataTable("users");

                // Check through each row of username and password.
                bool final_check, user_check, pass_check;
                foreach (DataRow row in dt.Rows)
                {
                    user_check = username.ToLower() == row[1].ToString().ToLower();
                    pass_check = password == row[2].ToString();
                    final_check = user_check && pass_check;

                    if (final_check)                        
                        return (true, Convert.ToInt32(row[0]));
                }
                return (false, -1);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                RaiseSQLError(ex);
                return (false, -1);
            }
        }

        public bool UsernameExists(string username)
        {
            // Check if the username is already in the Users table - JM
            string query = "SELECT COUNT(*) FROM users WHERE LOWER(username) = LOWER(@username)";
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", username);

            try
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                RaiseSQLError(ex);
                return false;
            }
        }

        public void PushDataToUsers(string username, string password)
        {
            // Pushes data to the Users table.

            // Check database connection
            if (!ConnectionPresent())
                return;

            // Query Command
            string query = "INSERT INTO users (username, password) VALUES (@username, @password)";

            // Setup Command for Query
            cmd.CommandText = query;
            cmd.Parameters.Clear();

            // Add Parameters.
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            // Attempt Query Execution
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                RaiseSQLError(ex);
            }
        }
        public IEnumerable<(int PriceId, int UserId, DateTime PurchaseDate, int Quantity, string Status, string Variation, string ProductName)> GetAllCartItems()
        {
            // A generator that returns ready to use data from the orders table.
            DataTable dt;

            try
            {
                dt = pullDataTable("orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pulling data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yield break; // Stop to avoid indexing out of range.
            }

            foreach (DataRow row in dt.Rows)
            {
                int price_id = 0;
                int user_id = 0;
                DateTime purchase_date = DateTime.MinValue;
                int purchase_quantity = 0;
                string status = "";
                string variation = "";
                string product_name = "";

                try
                {
                    price_id = Convert.ToInt32(row[1]);
                    user_id = Convert.ToInt32(row[2]);
                    purchase_date = Convert.ToDateTime(row[3]);
                    purchase_quantity = Convert.ToInt32(row[4]);
                    status = Convert.ToString(row[5]);
                    variation = Convert.ToString(row[6]);
                    product_name = Convert.ToString(row[7]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data conversion error: " + ex.Message,
                        "Row Skipped", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue; // Skip this row and continue with the rest
                }

                yield return (price_id, user_id, purchase_date, purchase_quantity, status, variation, product_name);
            }
        }

        public void PushDataToOrders(int price_id, int user_id, DateTime purchase_date, int purchase_quantity, string variation, string product_name, string status="Cart")
        {
            // Pushes data to the Orders table.

            // Check database connection
            if (!ConnectionPresent())
                return;

            // Query Command
            string query = "INSERT INTO orders (price_id, user_id, purchase_date, purchase_quantity, status, variation, product_name) VALUES (@price_id, @user_id, @purchase_date, @purchase_quantity, @status, @variation, @product_name)";

            // Setup Command for Query
            cmd.CommandText = query;
            cmd.Parameters.Clear();

            // Add Parameters.
            cmd.Parameters.AddWithValue("@price_id", price_id);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            cmd.Parameters.AddWithValue("@purchase_date", purchase_date);
            cmd.Parameters.AddWithValue("@purchase_quantity", purchase_quantity);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@variation", variation);
            cmd.Parameters.AddWithValue("@product_name", product_name);

            // Attempt Query Execution
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                RaiseSQLError(ex);
            }
        }



    }
}
