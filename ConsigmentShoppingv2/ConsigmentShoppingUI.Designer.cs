namespace ConsigmentShoppingv2
{
    partial class ConsigmentShoppingUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConsigmentShoppingLabel = new System.Windows.Forms.Label();
            this.StoreItemsLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.addToCart = new System.Windows.Forms.Button();
            this.CardItemsLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.MakePurchaseBtn = new System.Windows.Forms.Button();
            this.VendorListLabel = new System.Windows.Forms.Label();
            this.VendorListBox = new System.Windows.Forms.ListBox();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsigmentShoppingLabel
            // 
            this.ConsigmentShoppingLabel.AutoSize = true;
            this.ConsigmentShoppingLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConsigmentShoppingLabel.Location = new System.Drawing.Point(273, 61);
            this.ConsigmentShoppingLabel.Name = "ConsigmentShoppingLabel";
            this.ConsigmentShoppingLabel.Size = new System.Drawing.Size(233, 30);
            this.ConsigmentShoppingLabel.TabIndex = 0;
            this.ConsigmentShoppingLabel.Text = "Consigment Shopping";
            // 
            // StoreItemsLabel
            // 
            this.StoreItemsLabel.AutoSize = true;
            this.StoreItemsLabel.Location = new System.Drawing.Point(61, 112);
            this.StoreItemsLabel.Name = "StoreItemsLabel";
            this.StoreItemsLabel.Size = new System.Drawing.Size(66, 15);
            this.StoreItemsLabel.TabIndex = 1;
            this.StoreItemsLabel.Text = "Store Items";
            this.StoreItemsLabel.Click += new System.EventHandler(this.StoreItemsLabel_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 15;
            this.itemsListBox.Location = new System.Drawing.Point(61, 130);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(247, 94);
            this.itemsListBox.TabIndex = 2;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.StoreItemsListBox_SelectedIndexChanged);
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(336, 161);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(123, 23);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add Cart -->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.AddCartBtn_Click);
            // 
            // CardItemsLabel
            // 
            this.CardItemsLabel.AutoSize = true;
            this.CardItemsLabel.Location = new System.Drawing.Point(509, 112);
            this.CardItemsLabel.Name = "CardItemsLabel";
            this.CardItemsLabel.Size = new System.Drawing.Size(66, 15);
            this.CardItemsLabel.TabIndex = 1;
            this.CardItemsLabel.Text = "Store Items";
            this.CardItemsLabel.Click += new System.EventHandler(this.StoreItemsLabel_Click);
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 15;
            this.shoppingCartListBox.Location = new System.Drawing.Point(509, 130);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(247, 94);
            this.shoppingCartListBox.TabIndex = 2;
            this.shoppingCartListBox.SelectedIndexChanged += new System.EventHandler(this.StoreItemsListBox_SelectedIndexChanged);
            // 
            // MakePurchaseBtn
            // 
            this.MakePurchaseBtn.Location = new System.Drawing.Point(633, 230);
            this.MakePurchaseBtn.Name = "MakePurchaseBtn";
            this.MakePurchaseBtn.Size = new System.Drawing.Size(123, 23);
            this.MakePurchaseBtn.TabIndex = 3;
            this.MakePurchaseBtn.Text = "Purchase";
            this.MakePurchaseBtn.UseVisualStyleBackColor = true;
            this.MakePurchaseBtn.Click += new System.EventHandler(this.MakePurchaseBtn_Click);
            // 
            // VendorListLabel
            // 
            this.VendorListLabel.AutoSize = true;
            this.VendorListLabel.Location = new System.Drawing.Point(61, 244);
            this.VendorListLabel.Name = "VendorListLabel";
            this.VendorListLabel.Size = new System.Drawing.Size(49, 15);
            this.VendorListLabel.TabIndex = 1;
            this.VendorListLabel.Text = "Vendors";
            this.VendorListLabel.Click += new System.EventHandler(this.StoreItemsLabel_Click);
            // 
            // VendorListBox
            // 
            this.VendorListBox.FormattingEnabled = true;
            this.VendorListBox.ItemHeight = 15;
            this.VendorListBox.Location = new System.Drawing.Point(61, 262);
            this.VendorListBox.Name = "VendorListBox";
            this.VendorListBox.Size = new System.Drawing.Size(247, 94);
            this.VendorListBox.TabIndex = 2;
            this.VendorListBox.SelectedIndexChanged += new System.EventHandler(this.StoreItemsListBox_SelectedIndexChanged);
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Location = new System.Drawing.Point(509, 262);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(72, 15);
            this.StoreProfitLabel.TabIndex = 4;
            this.StoreProfitLabel.Text = "Store Profit: ";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Location = new System.Drawing.Point(602, 262);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(34, 15);
            this.StoreProfitValue.TabIndex = 5;
            this.StoreProfitValue.Text = "$0.00";
            // 
            // ConsigmentShoppingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.MakePurchaseBtn);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.CardItemsLabel);
            this.Controls.Add(this.VendorListBox);
            this.Controls.Add(this.VendorListLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.StoreItemsLabel);
            this.Controls.Add(this.ConsigmentShoppingLabel);
            this.Name = "ConsigmentShoppingUI";
            this.Text = "Consignment Shopping";
            this.Load += new System.EventHandler(this.ConsigmentShoppingUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ConsigmentShoppingLabel;
        private Label StoreItemsLabel;
        private ListBox itemsListBox;
        private Button addToCart;
        private Label CardItemsLabel;
        private ListBox shoppingCartListBox;
        private Button MakePurchaseBtn;
        private Label VendorListLabel;
        private ListBox VendorListBox;
        private Label StoreProfitLabel;
        private Label StoreProfitValue;
    }
}