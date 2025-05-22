namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
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

    }
}
