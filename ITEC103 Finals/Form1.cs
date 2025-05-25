namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        private API api;
        bool signed_in = false;

        int global_uid;
        int global_quantity;
        int global_item_id;

        int[] id = { 899, 499, 1259, 2459, 89, 259, 40, 699, 270, 180, 550, 70, 700, 130, 75, 821 };
        string global_variation = null;

        Panel[] panels = new Panel[16];

        public Form1()
        {
            InitializeComponent();

            // API Setup
            api = new API();
            api.ConnectDB();

            // Panel Setup
            SignIn_Panel.BringToFront();

            addid();
            storecontrols();
            // Set Form Size
            this.Size = new Size(1366, 768);
            //displays default quantity to 1 
            ItemViewQty.Text = global_quantity.ToString();
            //sets reset buttons hidden
            button11.Visible = false;
            roundedButton1.Visible = false;

            CartPanel_Load();
        }

        int[] exclusions = { 259, 550, 699, 700, 821, 1259, 2459 };

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (global_variation == null && !exclusions.Contains(global_item_id))
                ItemView_AddCart.Enabled = false;
            else
                ItemView_AddCart.Enabled = true;
        }

        // Add Methods to Their Designated Panel Files...

    }
}
