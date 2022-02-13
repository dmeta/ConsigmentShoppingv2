using System;
using ConsignmentShopLibrary;

namespace ConsigmentShoppingv2
{
    public partial class ConsigmentShoppingUI : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource cartBinding = new BindingSource();
        BindingSource itemsBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        private decimal StoreProfit = 0;

        public ConsigmentShoppingUI()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;
            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;
            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            VendorListBox.DataSource = vendorBinding;
            VendorListBox.DisplayMember = "Display";
            VendorListBox.ValueMember = "Display";

        }

        private void ConsigmentShoppingUI_Load(object sender, EventArgs e)
        {

        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("h");
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            //MessageBox.Show(selectedItem.Title);
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void StoreItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StoreItemsLabel_Click(object sender, EventArgs e)
        {

        }
        private void SetupData()
        {
            //store.Vendors = new List<Vendor>();
            Vendor demoVendor = new Vendor();
            demoVendor.FirstName = "Bill";
            demoVendor.LastName = "Smith";
            demoVendor.Comission = 0.5;
            store.Vendors.Add(demoVendor);

            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Poter",
                Description = "A book about a boy",
                Price = 5.20M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl",
                Price = 1.50M,
                Owner = store.Vendors[0]
            });
            store.Name = "Seconds are Better";
        }

        private void MakePurchaseBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puchase click");
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Comission * item.Price;
                StoreProfit += (1-(decimal)item.Owner.Comission) * item.Price;
            }
            shoppingCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
            StoreProfitValue.Text = String.Format("${0}", StoreProfit);
        }
    }
}