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
    }
}
