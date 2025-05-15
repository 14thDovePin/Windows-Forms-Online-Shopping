using System.Windows.Forms;

namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addid();
            // Set Form Size
            this.Size = new Size(1366, 768);
        }

        //adds id to the link labels
        private void addid()
        {
            int id = 1000;
            LinkLabel[] labels = new LinkLabel[] {
                 linkLabel1, linkLabel2, linkLabel3, linkLabel4,
                 linkLabel5, linkLabel6, linkLabel7, linkLabel8,
                 linkLabel9, linkLabel10, linkLabel11, linkLabel12,
                 linkLabel14, linkLabel15, linkLabel16, linkLabel16
            };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Tag = id + i;
                labels[i].LinkClicked += LinkLabel_LinkClicked;
            }
        }

        //executes when link label is clicked
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel clickedLabel = sender as LinkLabel;
            if (clickedLabel != null && clickedLabel.Tag != null)
            {
                int id = (int)clickedLabel.Tag; //gets id from clicked button
                ItemView_Panel.BringToFront();
                showiteminfo(id);
            }
        }

        //shows products information
        private void showiteminfo(int id)
        {
            switch (id)
            {
                case 1000:
                    resetvisuals();
                    ItemViewName.Text = "Zeus K-55(Mechanical Keyboard";
                    label18.Text = "899";
                    label19.Text = "Switch";
                    button1.Text = "Red";
                    button2.Text = "Blue";
                    button3.Text = "Brown";
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\1.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 1001:
                    resetvisuals();
                    ItemViewName.Text = "Vintag Jacket (violet)";
                    label18.Text = "499"; 
                    label19.Text = "Size";
                    button1.Text = "XS"; 
                    button2.Text = "S";
                    button3.Text = "M";
                    button4.Text = "L";
                    button5.Text = "XL";
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\2.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 1002:
                    resetvisuals();
                    ItemViewName.Text = "Mini electric fan";
                    label18.Text = "1259";
                    label19.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\3.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        //resets the visibility of the buttons
        private void resetvisuals()
        { 
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
        }

        //returns to homepage from items view
        private void CloseView_Click(object sender, EventArgs e)
        {
            HomePage_Panel.BringToFront();
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

        
    }
}
