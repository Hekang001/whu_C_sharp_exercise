using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day08_OrderServiceForm
{
    public partial class Form1 : Form
    {
        private String name;
        public string KeyWord { get; set; }
        //the order list
        public List<Order> orders;
       
        public List<Order> Orders
        {
            get => orders;
        }
        public Form1()
        {
            InitializeComponent();
          //  OrderService orderService = new OrderService();   
            OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
            OrderItem egg = new OrderItem(2, "eggs", 1.2, 200);
            OrderItem milk = new OrderItem(3, "milk", 50, 10);

            Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
            Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });           
            
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);

            OrderBindingSource.DataSource = orders;
            txb_name.DataBindings.Add("Text", this, "KeyWord");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }

        private void OrderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            if (KeyWord==null || KeyWord == "")
            {
                OrderBindingSource.DataSource = orders;
            }
            else
            {
                OrderBindingSource.DataSource= orders.Where(s => s.Customer == KeyWord);
            }
        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {
            this.name = txb_name.Text;
        }

        private void btnChangeOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnImpotOrder_Click(object sender, EventArgs e)
        {
        
        }

        private void btnExportOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FormEdit form2 = new FormEdit();
            form2.ShowDialog();
        }

        private class FormEdit
        {
            internal void ShowDialog()
            {
                throw new NotImplementedException();
            }
        }
    }
}
