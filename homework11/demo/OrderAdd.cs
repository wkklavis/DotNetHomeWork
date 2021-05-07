using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class OrderAdd : Form
    {
        
        public bool isAdd = true;
        public int Count { get; set; }

        public Order Order { get; set; }
        public OrderAdd()
        {
            InitializeComponent();
        }
        public void Biding()
        {
            nameTextBox.DataBindings.Add("Text", this.Order.customer, "Name");
            ageTextBox.DataBindings.Add("Text", this.Order.customer, "Age");
            sexTextBox.DataBindings.Add("Text", this.Order.customer, "Sex");
            addressTextBox.DataBindings.Add("Text", this.Order.Details, "Address");
            commodityTextBox.DataBindings.Add("Text", this.Order.Commodities.First(), "CommodityName");
            //quantityTextBox.DataBindings.Add("Text", this.order.list, "Count");
            
        }

        int price = 30;
        private void save_Click(object sender, EventArgs e)
        {
            if (isAdd == true)
             {
                if (nameTextBox.Text == String.Empty
                      && ageTextBox.Text == String.Empty
                      && sexTextBox.Text == String.Empty
                      && commodityTextBox.Text == String.Empty
                      && quantityTextBox.Text == String.Empty) return;

                String name = nameTextBox.Text;
                int age = Int32.Parse(ageTextBox.Text);
                String sex = sexTextBox.Text;
                String address = addressTextBox.Text;
                String commodityName = commodityTextBox.Text;
                int quantity = Int32.Parse(quantityTextBox.Text);
                
                Order = new Order(new Customer(name, age, sex), Count+1, new OrderDetails(address));
                for (; quantity > 0; quantity--)
                    Order.AddInfo(1, commodityName, price--);
                
             }
            else
            {

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
