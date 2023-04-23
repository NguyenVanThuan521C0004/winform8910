using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIndowFormApp8910
{

    public partial class ItemForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablet = new DataTable();
        string str = "DataSource=localhost; Initial Catalog = sql8910;Integrated Security = True";
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Item values('" + ItemID.Text + "' , '" + ItemName.Text + "' , '" + Size.Text + "')";
            command.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
