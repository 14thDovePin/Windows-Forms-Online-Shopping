using System.Net.Sockets;
using System.Windows.Forms;

namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        int qnty = 1;
        int itm;//id para sa ibang switch
        int[] id = { 899, 499, 1259, 2459, 89, 259, 40, 699, 270, 180, 550, 70, 700, 130, 75, 821 };
        string details = "det";

        Panel[] panels = new Panel[16];
        public Form1()
        {
            InitializeComponent();
            addid();
            storecontrols();
            // Set Form Size
            this.Size = new Size(1366, 768);
            //displays default quantity to 1 
            ItemViewQty.Text = qnty.ToString();
            //sets reset button hidden
            button11.Visible = false;
        }

        //adds id to the link labels
        private void addid()
        {

            LinkLabel[] labels = new LinkLabel[] {
                 linkLabel1, linkLabel2, linkLabel3, linkLabel4,
                 linkLabel5, linkLabel6, linkLabel7, linkLabel8,
                 linkLabel9, linkLabel10, linkLabel11, linkLabel12,
                 linkLabel13, linkLabel14, linkLabel15, linkLabel16
            };
            Panel[] panels = {
                panel2, panel3, panel4, panel5,
                 panel6, panel7, panel8, panel9,
                panel10, panel11, panel12, panel13,
                panel14, panel15, panel16, panel17
            };
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Tag = id[i];
                labels[i].LinkClicked += LinkLabel_LinkClicked;
                panels[i].Tag = id[i];
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
                case 899:
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
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 499:
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
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 1259:
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
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 2459:
                    resetvisuals();
                    ItemViewName.Text = "Uratex inflatable mattress";
                    label18.Text = "2459";
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
                    pictureBox17.Image = Image.FromFile(@"img\4.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 89:
                    resetvisuals();
                    ItemViewName.Text = "(Inspeed) Bike Bag";
                    label18.Text = "89";
                    label19.Text = "Color";
                    button1.Text = "Blue";
                    button2.Text = "Red";
                    button3.Text = "Black";
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\5_def.png");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 259:
                    resetvisuals();
                    ItemViewName.Text = "Wireless Headset (Onikuma Gaming Headset)";
                    label18.Text = "259";
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
                    pictureBox17.Image = Image.FromFile(@"img\6.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
                    itm = id;
                    break;
                case 40:
                    resetvisuals();
                    ItemViewName.Text = "Taslan Shorts";
                    label18.Text = "40";
                    label19.Text = "Color";
                    button1.Text = "Black";
                    button2.Text = "Gray";
                    button3.Text = "Blue";
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\7_def.png");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 699:
                    resetvisuals();
                    ItemViewName.Text = "Wireless RGB mouse (Zeus x Gundam) ";
                    label18.Text = "699";
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
                    pictureBox17.Image = Image.FromFile(@"img\8.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 270:
                    resetvisuals();
                    ItemViewName.Text = "Chelsea boots (brown)";
                    label18.Text = "270";
                    label19.Text = "Size";
                    button1.Text = "38";
                    button2.Text = "39";
                    button3.Text = "40";
                    button4.Text = "41";
                    button5.Text = "42";
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\9.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 180:
                    resetvisuals();
                    ItemViewName.Text = "Lovito pocket pants";
                    label18.Text = "180";
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
                    pictureBox17.Image = Image.FromFile(@"img\10.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 550:
                    resetvisuals();
                    ItemViewName.Text = "Bluetooth Earbuds (Robin Honkai Star Rail)  ";
                    label18.Text = "550";
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
                    pictureBox17.Image = Image.FromFile(@"img\11.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 70:
                    resetvisuals();
                    ItemViewName.Text = "wallet (black, dark brown, brown) ";
                    label18.Text = "70";
                    label19.Text = "Color";
                    button1.Text = "Black";
                    button2.Text = "Darkbrown";
                    button3.Text = "brown";
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\12_def.png");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 700:
                    resetvisuals();
                    ItemViewName.Text = "10kg Workout Dumbbells";
                    label18.Text = "700";
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
                    pictureBox17.Image = Image.FromFile(@"img\13.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 130:
                    resetvisuals();
                    ItemViewName.Text = "Bike shades";
                    label18.Text = "130";
                    label19.Text = "Color";
                    button1.Text = "Red";
                    button2.Text = "Blue";
                    button3.Text = "Purple";
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\14_def.png");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 75:
                    resetvisuals();
                    ItemViewName.Text = "Adadis Socks (6pairs)";
                    label18.Text = "75";
                    label19.Text = "Color";
                    button1.Text = "White";
                    button2.Text = "Black";
                    button3.Text = "Black and White";
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    label20.Text = "";
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    pictureBox17.Image = Image.FromFile(@"img\15_def.png");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
                case 821:
                    resetvisuals();
                    ItemViewName.Text = "Gunpla Gundam kit HG (Barbatos, Aerial)";
                    label18.Text = "821";
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
                    pictureBox17.Image = Image.FromFile(@"img\16.jpg");
                    pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                    itm = id;
                    break;
            }
        }

        //resets the visibility of the buttons
        private void resetvisuals()
        {
            label19.Visible = true;
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
            qnty = 1;
            ItemViewQty.Text = qnty.ToString();
        }

        //Selects details based on click button (color, size, etc) (for buttons 1-5)(also changes images depending on the button clicked)
        private void button1_Click(object sender, EventArgs e)
        {
            switch (itm)
            {
                case 899:
                    details = button1.Text;
                    break;
                case 499:
                    details = button1.Text;
                    break;
                case 89:
                    details = button1.Text;
                    pictureBox17.Image = Image.FromFile(@"img\5_def.png");
                    break;
                case 40:
                    details = button1.Text;
                    pictureBox17.Image = Image.FromFile(@"img\7_def.png");
                    break;
                case 270:
                    details = button1.Text;
                    break;
                case 550:
                    details = button1.Text;
                    break;
                case 700:
                    details = button1.Text;
                    pictureBox17.Image = Image.FromFile(@"img\12_blk.png");
                    break;
                case 130:
                    details = button1.Text;
                    pictureBox17.Image = Image.FromFile(@"img\14_def.png");
                    break;
                case 75:
                    details = button1.Text;
                    pictureBox17.Image = Image.FromFile(@"img\15_def.png");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (itm)
            {
                case 899:
                    details = button2.Text;
                    break;
                case 499:
                    details = button2.Text;
                    break;
                case 89:
                    details = button2.Text;
                    pictureBox17.Image = Image.FromFile(@"img\5_rd.png");
                    break;
                case 40:
                    details = button2.Text;
                    pictureBox17.Image = Image.FromFile(@"img\7_gry.png");
                    break;
                case 270:
                    details = button2.Text;
                    break;
                case 180:
                    details = button2.Text;
                    break;
                case 70:
                    details = button2.Text;
                    pictureBox17.Image = Image.FromFile(@"img\12_drkbrwn.png");
                    break;
                case 130:
                    details = button2.Text;
                    pictureBox17.Image = Image.FromFile(@"img\14-bl.png");
                    break;
                case 75:
                    details = button2.Text;
                    pictureBox17.Image = Image.FromFile(@"img\15_black.png");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (itm)
            {
                case 899:
                    details = button3.Text;
                    break;
                case 499:
                    details = button3.Text;
                    break;
                case 89:
                    details = button3.Text;
                    pictureBox17.Image = Image.FromFile(@"img\5_blck.png");
                    break;
                case 40:
                    details = button3.Text;
                    pictureBox17.Image = Image.FromFile(@"img\7_bl.png");
                    break;
                case 270:
                    details = button3.Text;
                    break;
                case 180:
                    details = button3.Text;
                    break;
                case 70:
                    details = button3.Text;
                    pictureBox17.Image = Image.FromFile(@"img\12_def.png");
                    break;
                case 130:
                    details = button3.Text;
                    pictureBox17.Image = Image.FromFile(@"img\14_prpl.png");
                    break;
                case 75:
                    details = button3.Text;
                    pictureBox17.Image = Image.FromFile(@"img\15_blkwht.png");
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (itm)
            {
                case 499:
                    details = button4.Text;
                    break;
                case 270:
                    details = button4.Text;
                    break;
                case 180:
                    details = button4.Text;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (itm)
            {
                case 499:
                    details = button5.Text;
                    break;
                case 270:
                    details = button5.Text;
                    break;
                case 180:
                    details = button5.Text;
                    break;
            }
        }

        //returns to homepage from items view
        private void CloseView_Click(object sender, EventArgs e)
        {
            HomePage_Panel.BringToFront();
        }

        //adds 1 to quantity if clicked
        private void ItemView_QtyDecrement_Click(object sender, EventArgs e)
        {
            qnty++;
            ItemViewQty.Text = qnty.ToString();
        }

        //subtracts 1 to quantity if clicked
        private void ItemView_QtyIncrement_Click(object sender, EventArgs e)
        {
            if (qnty > 1)
            {
                qnty--;
            }
            ItemViewQty.Text = qnty.ToString();
        }

        //readds all controls depending on sort option
        private void SortPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SortPrice.Text == "High to Low")
            {
                //sort by price
                var sortedPanels = ItemList.Controls
                .OfType<Panel>()
                .OrderBy(p => (int)p.Tag);

                foreach (Panel panel in sortedPanels)
                {
                    ItemList.Controls.SetChildIndex(panel, 0); // move panel to top
                }
                button11.Visible = true;
            }
            else if (SortPrice.Text == "Low to High")
            {
                //sort by price
                var sortedPanels = ItemList.Controls
                .OfType<Panel>()
                .OrderByDescending(p => (int)p.Tag);

                foreach (Panel panel in sortedPanels)
                {
                    ItemList.Controls.SetChildIndex(panel, 0); // move panel to top
                }
                button11.Visible = true;
            }
        }

        //stores all controls in ItemList to an array
        private void storecontrols()
        {
            foreach (Panel pnl in ItemList.Controls)
            {
                for (int i = 0; i < ItemList.Controls.Count; i++)
                {
                    panels[i] = (Panel)ItemList.Controls[i];
                }
            }
        }

        //resets the sort
        private void button11_Click(object sender, EventArgs e)
        {
            ItemList.Controls.Clear();
            for (int i = 0; i < panels.Length; i++)
            {
                ItemList.Controls.Add(panels[i]);
            }
            SortPrice.Text = "Price";
            button11.Visible = false;
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

        private void Logo_PicBox_Click(object sender, EventArgs e)
        {
            HomePage_Panel.Show(); //clicking logo brings you back to home page
        }
    }
}
