using ITEC103_Finals.AddControls;

namespace ITEC103_Finals
{
    public partial class Form1 : Form
    {
        // Add Code Here

        //labels buttons and picture box for each panel of product
        private PictureBox pictureBox = new PictureBox{};
        private Label label50 = new Label {};
        private Label label51 = new Label {};
        private Label label52 = new Label {};
        private Label label53 = new Label {};
        private Label ItemCartQty = new Label {};
        private Button cart_qtyDecrement = new Button{};
        private Button cart_qtyIncrement = new Button{};

        //user and product infos
        int cartid,quantity,price, totalprice;
        string  productname,variation,status;

        //totals 
        int totalamount, totalitems;
        //loads cart items

        private void CartPanel_Load()
        {
            flowLayoutPanel1.Controls.Clear();

            // Pull server data & generate cart items with it.

            foreach (var item in api.GetAllCartItems())
            {
                GenerateCartItem(
                    item.PriceId,
                    item.UserId,
                    item.PurchaseDate,
                    item.Quantity,
                    item.Status,
                    item.ProductName,
                    item.Variation
                    );
            }


            //GenerateCartItem(
            //    821,
            //    1,
            //    DateTime.MinValue,
            //    20,
            //    "Cart",
            //    "Secret Gundam Warrior",
            //    "White Medium Set"
            //    );
        }

        private void GenerateCartItem(int price_id, int user_id, DateTime purchase_date, int purchase_quantity, string status, string product_name, string variation)
        {
            // Check User & Order Status
            Console.WriteLine(global_uid);
            Console.WriteLine(user_id);
            bool user_check = user_id == global_uid;
            bool cart_item = status.ToLower() == "cart";

            if (user_check && cart_item) { }
            else return;

            // Generate Interface
            generatepanel();
            imagesource(price_id); //displays the image based on the id 
            price = price_id;//price galing sa database
            totalprice = price * purchase_quantity;

            //this part displays the data in each respective label 
            imagesource(price_id);
            label50.Text = product_name;
            label51.Text = variation;
            label52.Text = price.ToString();
            ItemCartQty.Text = purchase_quantity.ToString();
            label53.Text = totalprice.ToString();
            totalamount += totalprice;
            totalitems += purchase_quantity;
            TotalItemLabel.Text = $"Total( {totalitems} Item/s):";
            CheckOutTotalPrice.Text = totalamount.ToString();
        }


        ////generates cart items depending on user id
        //private void LoadCartItems(int price_id, int user_id, DateTime purchase_date, int purchase_quantity, string status, string product_name, string variation)
        //{
        //    panel23.Visible = false;
            
        //    for (int i = 0; i < 5; i++)
        //    {
        //        status = "cart"; //status galing sa database

        //        if (i == 0 && status == "cart") //condtion dito dapat is buyer id tas sa status is cart or something
        //        {
        //            generatepanel();
        //            imagesource(price_id); //displays the image based on the id 
        //            price = price_id;//price galing sa database
        //            totalprice = price * purchase_quantity;
                    
        //            //this part displays the data in each respective label 
        //            imagesource(price_id);
        //            label50.Text = product_name;
        //            label51.Text = variation;
        //            label52.Text = price.ToString();
        //            ItemCartQty.Text = purchase_quantity.ToString(); 
        //            label53.Text = totalprice.ToString(); 
        //            totalamount += totalprice;
        //            totalitems += purchase_quantity;
        //            TotalItemLabel.Text = $"Total( {totalitems} Item/s):";
        //            CheckOutTotalPrice.Text = totalamount.ToString();
        //        }
        //    }
        //}

        private void cart_qtyDecrement_Click(object sender, EventArgs e)
        {
            // Decrement quantity logic
            if (quantity > 1)
            {
                quantity--;
                ItemCartQty.Text = quantity.ToString();
            }
        }

        private void cart_qtyIncrement_Click(object sender, EventArgs e)
        {
            // Increment quantity logic
            quantity++;
            ItemCartQty.Text = quantity.ToString();
        }

        private void generatepanel()
        {
            Panel panel = new Panel
            {
                Size = new Size(1071, 122),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Name = "CartItemPanel",
            };

            //product toggle
            ToggleButton toggleButton = new ToggleButton
            {
                AutoSize = true,
                Location = new Point(10, 52),
                MinimumSize = new Size(45, 22),
                Name = "ToggleItem",
                OffBackColor = Color.Gray,
                OffToggleColor = Color.Gainsboro,
                OnBackColor = Color.MediumSlateBlue,
                OnToggleColor = Color.WhiteSmoke,
                Size = new Size(45, 22),
                SolidStyle = true,
                TabIndex = 0,
                UseVisualStyleBackColor = true,
            };

            panel.Controls.Add(toggleButton);

            // PictureBox (Image Box)
            pictureBox = new PictureBox
            {
                Size = new Size(144, 116),
                Location = new Point(65, 3),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            panel.Controls.Add(pictureBox);

            //product name and panel
            label50 = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(0,0),
                Name = "CartItemName",
                Size = new Size(37, 21),
                TabIndex = 6,
            };

            Panel product = new Panel
            {
                Location = new Point(219, 13),
                Name = "panel26",
                Size = new Size(320, 30),
                TabIndex = 12,
            };

            product.Controls.Add(label50);
            panel.Controls.Add(product);

            //product variation
            label51 = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(219, 90),
                Name = "CartItemVariation",
                Size = new Size(70, 21),
                TabIndex = 5,
                Text = "Color, Size",// Replace with actual product variation
            };

            panel.Controls.Add(label51);

            //product price 
            label52 = new Label
            {
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(571, 50),
                Name = "ProductPrice",
                Size = new Size(37, 21),
                TabIndex = 7,
                Text = "###",
            };
            panel.Controls.Add(label52);

            //buttons for increment and decrement
            cart_qtyDecrement = new Button
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ImageAlign = ContentAlignment.TopCenter,
                Location = new Point(3, 3),
                Name = "cart_qtyDecrement",
                Size = new Size(31, 26),
                TabIndex = 0,
                Text = "-",
                UseVisualStyleBackColor = true,
            };

            ItemCartQty = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12F),
                Location = new Point(40, 0),
                Name = "CartQty",
                Size = new Size(31, 32),
                TabIndex = 2,
                Text = "1",
                TextAlign = ContentAlignment.MiddleCenter,
            };

            cart_qtyIncrement = new Button
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(77, 3),
                Name = "cart_qtyIncrement",
                Size = new Size(34, 26),
                TabIndex = 2,
                Text = "+",
                UseVisualStyleBackColor = true,
            };

            cart_qtyDecrement.Click += cart_qtyDecrement_Click; 
            cart_qtyIncrement.Click += cart_qtyIncrement_Click;

            //table for incerement and decrement
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 3,
                Location = new Point(671, 50),
                Name = "tableLayoutPanel3",
                RowCount = 1,
                Size = new Size(114, 32),
                TabIndex = 0
            };

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            tableLayoutPanel.Controls.Add(cart_qtyDecrement, 0, 0);
            tableLayoutPanel.Controls.Add(ItemCartQty, 1, 0);
            tableLayoutPanel.Controls.Add(cart_qtyIncrement, 2, 0);

            panel.Controls.Add(tableLayoutPanel);

            //cart total amount
            label53 = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Teal,
                Location = new Point(839, 55),
                Name = "CartTotalPrice",
                Size = new Size(37, 21),
                TabIndex = 8,
                Text = "###",
            };

            panel.Controls.Add(label53);

            // edit and delete Buttons
            Button button1 = new Button
            {
                // TODO: Uncomment when resolved.
                //BackgroundImage = Image.FromFile("img/edit.png"), // Use BackgroundImage instead of Image
                BackgroundImageLayout = ImageLayout.Zoom,         // Zoom keeps image aspect ratio
                FlatStyle = FlatStyle.Flat,
                Location = new Point(956, 40),
                Name = "CartEdit",
                Size = new Size(48, 44),
                TabIndex = 11,
                UseVisualStyleBackColor = false // False if you want a clean background
            };

            button1.FlatAppearance.BorderSize = 0;

            panel.Controls.Add(button1);

            Button button2 = new Button
            {
                // TODO: Uncomment when resolved.
                //BackgroundImage = Image.FromFile("img/delete.png"),
                BackgroundImageLayout = ImageLayout.Zoom,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(1010, 40),
                Name = "CartDelete",
                Size = new Size(48, 44),
                TabIndex = 10,
                UseVisualStyleBackColor = false
            };

            button2.FlatAppearance.BorderSize = 0;

            panel.Controls.Add(button2);

            // Add panel to the form
            flowLayoutPanel1.Controls.Add(panel);
        }        

        private void imagesource(int id)
        {
            switch (id)
            {
                case 899:
                    pictureBox.Image = Image.FromFile("img/1.jpg");
                    break;
                case 499:
                    pictureBox.Image = Image.FromFile("img/2.jpg");
                    break;
                case 1259:
                    pictureBox.Image = Image.FromFile("img/3.jpg");
                    break;
                case 2459:
                    pictureBox.Image = Image.FromFile("img/4.jpg");
                    break;
                case 89:
                    pictureBox.Image = Image.FromFile("img/5_def.png");
                    break;
                case 259:
                    pictureBox.Image = Image.FromFile("img/6.jpg");
                    break;
                case 40:
                    pictureBox.Image = Image.FromFile("img/7_def.png");
                    break;
                case 699:
                    pictureBox.Image = Image.FromFile("img/8.jpg");
                    break;
                case 270:
                    pictureBox.Image = Image.FromFile("img/9.jpg");
                    break;
                case 180:
                    pictureBox.Image = Image.FromFile("img/10.jpg");
                    break;
                case 550:
                    pictureBox.Image = Image.FromFile("img/11.jpg");
                    break;
                case 70:
                    pictureBox.Image = Image.FromFile("img/12_def.png");
                    break;
                case 700:
                    pictureBox.Image = Image.FromFile("img/13.jpg");
                    break;
                case 130:
                    pictureBox.Image = Image.FromFile("img/14_def.png");
                    break;
                case 75:
                    pictureBox.Image = Image.FromFile("img/15_def.png");
                    break;
                case 821:
                    pictureBox.Image = Image.FromFile("img/16.jpg");
                    break;
                default:
                    pictureBox.Image = null; // Default image if no match
                    break;
            }
        }
    }
}
