namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        private API api;

        int qnty = 1;
        int itm;//id para sa ibang switch
        int[] id = { 899, 499, 1259, 2459, 89, 259, 40, 699, 270, 180, 550, 70, 700, 130, 75, 821 };
        string details = "det";

        Panel[] panels = new Panel[16];
        public Form1()
        {
            InitializeComponent();

            // API Setup
            api = new API();
            api.ConnectDB();

            addid();
            storecontrols();
            // Set Form Size
            this.Size = new Size(1366, 768);
            //displays default quantity to 1 
            ItemViewQty.Text = qnty.ToString();
            //sets reset buttons hidden
            button11.Visible = false;
            roundedButton1.Visible = false;
        }

        private void SignUp_FooterLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignIn_Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayout2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBar_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel49_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel48_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseSelector_All_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel31_Click(object sender, EventArgs e)
        {

        }

        
    }
}
