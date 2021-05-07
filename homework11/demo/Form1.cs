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
    public partial class Form1 : Form
    {
        public OrderService Service { get; set; } = new OrderService();

        public OrderContext orderContext;
        public Form1()
        {
            InitializeComponent();
            orderContext = new OrderContext();           
            orderBindingSource.DataSource = Service.OrderList;
            detailBindingSource.DataSource = orderBindingSource;
            detailBindingSource.DataMember = "Commodities";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OrderAdd form = new OrderAdd();
            form.Count = this.Service.OrderList.Count;
            form.isAdd = true;
            form.ShowDialog(); //NOTE this! must be ShowDialog()  NOT Show()!
            if (form.DialogResult == DialogResult.OK) {Service.AddOrder(form.Order); this.Update(); }
        }
        public void Update()
        {
            orderBindingSource.ResetBindings(false);
            detailBindingSource.ResetBindings(false);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Service.Export(saveFileDialog.FileName);
                MessageBox.Show("导出成功");
            }
        }
   
        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Service.Import(openFileDialog.FileName);
                Update();
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int orderNo =Int32.Parse( dataGridView1.SelectedCells[1].Value.ToString());
            Service.DeleteOrder(orderNo);
            Update();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                OrderAdd form = new OrderAdd();
                int orderNo = Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                form.Order = Service.QueryOrder(orderNo);
                form.isAdd = false;
                form.Biding();
                form.ShowDialog(); //NOTE this! must be ShowDialog()  NOT Show()!
                if (form.DialogResult == DialogResult.OK)
                {
                    using (var db = new OrderContext())
                    { 
                        db.SaveChanges(); 
                    }
                }
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            if (queryTextBox.Text != ""&&Int32.TryParse(queryTextBox.Text, out int i)) 
            {    
                orderBindingSource.DataSource = Service.QueryOrder(i);              
            }
            else 
            {
                using (var db = new OrderContext())
                {
                    orderBindingSource.DataSource = db.Orders.Include("Customer").Include("Commodities").ToList<Order>();
                }
            }
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.Cell.Selected)
            {
                if (!dataGridView1.Rows[e.Cell.RowIndex].Selected)
                {
                    dataGridView1.Rows[e.Cell.RowIndex].Selected = true;
                }
            }
        }
    }
}
