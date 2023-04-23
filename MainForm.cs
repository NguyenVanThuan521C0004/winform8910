using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WIndowFormApp8910
{
    public partial class MainForm : Form {
        public MainForm()
        {
            InitializeComponent();
        }
        
            
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our services.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemForm Product = new ItemForm();
            Product.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgentForm Agent = new AgentForm();
            Agent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm Order = new OrderForm();
            Order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilterForm Filter = new FilterForm();
            Filter.Show();
        }
    }
}
