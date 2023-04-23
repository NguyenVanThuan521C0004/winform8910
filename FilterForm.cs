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
    public partial class FilterForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablet = new DataTable();
        string str = "DataSource=localhost; Initial Catalog = sql8910;Integrated Security = True";



        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();

            string query = "SELECT DISTINCT Category FROM sql8910";

            adapter.SelectCommand = new SqlCommand(query, connection);
            adapter.Fill(tablet);

            filterComboBox.DataSource = tablet;
            filterComboBox.DisplayMember = "Category";
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter = filterComboBox.Text;
            string search = searchTextBox.Text;

            string query = "SELECT ItemID, Itemname, OrderID, AgentID FROM Filter WHERE Status LIKE '%" + filter + "%' AND (ItemName LIKE '%" + search + "%' OR ItemID LIKE '%" + search + "%')";

            adapter.SelectCommand = new SqlCommand(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@filter", filter);
            adapter.SelectCommand.Parameters.AddWithValue("@search", search);
            DataTable resultTable = new DataTable();
            adapter.Fill(resultTable);

            resultsDataGridView.DataSource = resultTable;
        }
    }
}
