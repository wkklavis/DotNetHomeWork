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
            orderBindingSource.DataSource = service;
            orderBindingSource.DataMember = "orderList";

            detailBindingSource.DataSource = orderBindingSource;
            detailBindingSource.DataMember = "list";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OrderAdd form = new OrderAdd();
            form.Form1 = this;
            form.isAdd = true;
            form.Show();
        }
        public void Update()
        {
            orderBindingSource.ResetBindings(true);
            detailBindingSource.ResetBindings(true);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            service.Export(exportTextBox.Text);
        }



        private void importButton_Click(object sender, EventArgs e)
        {
            service.Import(importTextBox.Text);
            Update();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int orderNo =Int32.Parse( dataGridView1.SelectedCells[1].Value.ToString());

            service.DeleteOrder(orderNo);
            Update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderAdd form = new OrderAdd();
            form.Form1 = this;
            int orderNo = Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());            
            form.order = service.QueryOrder(orderNo);
            form.isAdd = false;
            form.Biding();
            form.Show();

        }

        private void queryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
