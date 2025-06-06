﻿namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        // Add Code Here

        private void Search_Btn_Click(object sender, EventArgs e)
        {
            var matchingPanels = new List<Panel>();

            foreach (Control ctrl in ItemList.Controls)
            {
                if(ctrl is Panel pnl)
                {
                    foreach (Control incntrl in pnl.Controls)
                    {
                        // Check if the panel's tag matches the search text
                        if (incntrl is LinkLabel lbl)
                        {
                            if (lbl.Text.ToLower().Contains(SearchBox_TxtBox.Text.ToLower()))
                            {
                                matchingPanels.Add(pnl);
                            }
                        }
                    }
                }
            }

            ItemList.Controls.Clear();

            foreach (Panel panel in matchingPanels)
            {
                ItemList.Controls.Add(panel);
            }

            roundedButton1.Visible = true;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {  
            SearchBox_TxtBox.Text = "";

            for (int i = 0; i < panels.Length; i++)
            {
                ItemList.Controls.Add(panels[i]);
            }

            roundedButton1.Visible = false;
        }

        private void Logo_PicBox_Click(object sender, EventArgs e)
        {
            if (!signed_in)
                return;

            HomePage_Panel.BringToFront(); //clicking logo brings you back to home page
            PageLabel.Text = "Home";
        }

        private void CartIcon_PicBox_Click(object sender, EventArgs e)
        {
            if (!signed_in)
                return;

            CartPanel_Load();
            Cart_Panel.BringToFront(); //brings you to cart page
            PageLabel.Text = "Cart";
        }

        private void ProfileIcon_PicBox_Click(object sender, EventArgs e)
        {
            if (!signed_in)
                return;

            Profile_Panel.BringToFront(); //brings you to profile page
            PageLabel.Text = "Profile";
        }
        private void PageLabel_TextChanged(object sender, EventArgs e)
        {
            //// Reset all icons to white
            //CartIcon_PicBox.BackColor = Color.White;
            //ProfileIcon_PicBox.BackColor = Color.White;
            //NotificationIcon_PicBox.BackColor = Color.White;

            //// Highlight only the selected icon
            //switch (PageLabel.Text)
            //{
            //    case "Cart":
            //        CartIcon_PicBox.BackColor = Color.DarkGray;
            //        break;
            //    case "Profile":
            //        ProfileIcon_PicBox.BackColor = Color.DarkGray;
            //        break;
            //    case "Notification":
            //        NotificationIcon_PicBox.BackColor = Color.DarkGray;
            //        break;
            //}
        }
    }
}
