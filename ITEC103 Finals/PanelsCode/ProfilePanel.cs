namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        // Add Code Here
        private void PurchaseSelector_All_Click(object sender, EventArgs e)
        {
            PurchaseSelector_All.BackColor = Color.Teal;
            label28.ForeColor = Color.White;

            PurchaseSelector_Cancelled.BackColor = Color.White;
            PurchaseSelector_Completed.BackColor = Color.White;
            PurchaseSelector_ToReceive.BackColor = Color.White;
            PurchaseSelector_ToShip.BackColor = Color.White;
            label29.ForeColor = Color.Black;
            label31.ForeColor = Color.Black;
            label33.ForeColor = Color.Black;
            label35.ForeColor = Color.Black;
        }
        private void PurchaseSelector_ToShip_Click(object sender, EventArgs e)
        {
            PurchaseSelector_ToShip.BackColor = Color.Teal;
            label29.ForeColor = Color.White;

            PurchaseSelector_Cancelled.BackColor = Color.White;
            PurchaseSelector_Completed.BackColor = Color.White;
            PurchaseSelector_ToReceive.BackColor = Color.White;
            PurchaseSelector_All.BackColor = Color.White;
            label28.ForeColor = Color.Black;
            label31.ForeColor = Color.Black;
            label33.ForeColor = Color.Black;
            label35.ForeColor = Color.Black;
        }

        private void PurchaseSelector_ToReceive_Click(object sender, EventArgs e)
        {
            PurchaseSelector_ToReceive.BackColor = Color.Teal;
            label31.ForeColor = Color.White;

            PurchaseSelector_Cancelled.BackColor = Color.White;
            PurchaseSelector_Completed.BackColor = Color.White;
            PurchaseSelector_ToShip.BackColor = Color.White;
            PurchaseSelector_All.BackColor = Color.White;
            label28.ForeColor = Color.Black;
            label29.ForeColor = Color.Black;
            label33.ForeColor = Color.Black;
            label35.ForeColor = Color.Black;
        }

        private void PurchaseSelector_Completed_Click(object sender, EventArgs e)
        {
            PurchaseSelector_Completed.BackColor = Color.Teal;
            label33.ForeColor = Color.White;

            PurchaseSelector_Cancelled.BackColor = Color.White;
            PurchaseSelector_ToShip.BackColor = Color.White;
            PurchaseSelector_ToReceive.BackColor = Color.White;
            PurchaseSelector_All.BackColor = Color.White;
            label28.ForeColor = Color.Black;
            label29.ForeColor = Color.Black;
            label31.ForeColor = Color.Black;
            label35.ForeColor = Color.Black;
        }

        private void PurchaseSelector_Cancelled_Click(object sender, EventArgs e)
        {
            PurchaseSelector_Cancelled.BackColor = Color.Teal;
            label35.ForeColor = Color.White;

            PurchaseSelector_Completed.BackColor = Color.White;
            PurchaseSelector_ToShip.BackColor = Color.White;
            PurchaseSelector_ToReceive.BackColor = Color.White;
            PurchaseSelector_All.BackColor = Color.White;
            label28.ForeColor = Color.Black;
            label29.ForeColor = Color.Black;
            label31.ForeColor = Color.Black;
            label33.ForeColor = Color.Black;
        }
    }
}
