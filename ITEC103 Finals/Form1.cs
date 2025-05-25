namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        private API api;
        bool signed_in = false;

        int uid;
        int qnty = 1;
        int itm;//id para sa ibang switch
        int[] id = { 899, 499, 1259, 2459, 89, 259, 40, 699, 270, 180, 550, 70, 700, 130, 75, 821 };
        string details = null;

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
            ItemViewQty.Text = qnty.ToString();
            //sets reset buttons hidden
            button11.Visible = false;
            roundedButton1.Visible = false;

            CartPanel_Load();
        }

        int[] exclusions = { 259, 550, 699, 700, 821, 1259, 2459 };

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (details == null)
                ItemView_AddCart.Enabled = false;
            else
                ItemView_AddCart.Enabled = true;

            if (exclusions.Contains(itm))
                ItemView_AddCart.Enabled = true;
        }

        // Add Methods to Their Designated Panel Files...

    }
}
