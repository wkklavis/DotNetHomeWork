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
    public partial class Form1 : Form
    {
        public OrderService service { get; set; } = new OrderService();

        public Form1()
        {
            InitializeComponent();
            orderBindingSource.DataSource = service.orderList;
            //orderBindingSource.DataMember = "orderList";

            detailBindingSource.DataSource = orderBindingSource;
            detailBindingSource.DataMember = "list";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OrderAdd form = new OrderAdd();
            form.Count = this.service.orderList.Count;
            form.isAdd = true;
            form.ShowDialog(); //NOTE this! must be ShowDialog()  NOT Show()!
            if (form.DialogResult == DialogResult.OK) {service.AddOrder(form.order); this.Update(); }
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
                service.Export(saveFileDialog.FileName);
                MessageBox.Show("导出成功");
            }
        }


        
        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                service.Import(openFileDialog.FileName);
                Update();
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int orderNo =Int32.Parse( dataGridView1.SelectedCells[1].Value.ToString());

            service.DeleteOrder(orderNo);
            Update();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderAdd form = new OrderAdd();
            
            int orderNo = Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());            
            form.order = service.QueryOrder(orderNo);
            form.isAdd = false;
            form.Biding();
            
            form.ShowDialog(); //NOTE this! must be ShowDialog()  NOT Show()!
            if (form.DialogResult == DialogResult.OK) { this.Update(); }
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            if (queryTextBox.Text != "") 
            {
                if (Int32.TryParse(queryTextBox.Text, out int i))
                {
                    orderBindingSource.DataSource = service.orderList.Where(o => o.OrderNo == i);
                }
                else
                {
                    orderBindingSource.DataSource =service.orderList.Where(o => o.customer.Name == queryTextBox.Text);
                }
            }
            else { orderBindingSource.DataSource = service.orderList; }
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
