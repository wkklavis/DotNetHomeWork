using demo01;
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

        public Order order { get; set; }
        public OrderAdd()
        {
            InitializeComponent();
        }
        public void Biding()
        {
            nameTextBox.DataBindings.Add("Text", this.order.customer, "Name");
            ageTextBox.DataBindings.Add("Text", this.order.customer, "Age");
            sexTextBox.DataBindings.Add("Text", this.order.customer, "Sex");
            addressTextBox.DataBindings.Add("Text", this.order.details, "Address");
            commodityTextBox.DataBindings.Add("Text", this.order.list.First(), "CommodityName");
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
                char sex = Char.Parse(sexTextBox.Text);
                String address = addressTextBox.Text;
                String commodityName = commodityTextBox.Text;
                int quantity = Int32.Parse(quantityTextBox.Text);
                
                order = new Order(new Customer(name, age, sex), Count+1, new OrderDetails(address));
                for (; quantity > 0; quantity--)
                    order.AddInfo(1, commodityName, price--);
                
             }
            else
            {

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
