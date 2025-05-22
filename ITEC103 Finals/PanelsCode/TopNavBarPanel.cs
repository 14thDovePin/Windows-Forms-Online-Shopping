using ITEC103_Finals.AddControls;

namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        
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
                            if (lbl.Text.ToLower().Contains(textBox1.Text.ToLower()))
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
            SearchBar_TxtBox.Text = "";
            for (int i = 0; i < panels.Length; i++)
            {
                ItemList.Controls.Add(panels[i]);
            }
            roundedButton1.Visible = false;
        }
    }
}
