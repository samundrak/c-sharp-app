using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pencil
{
    public partial class ListPencils : Form
    {
        public ListPencils()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gridView.Rows[e.RowIndex].Cells["id"].Value);
            switch (gridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower())
            {
                case "delete":
                    DB db = new DB("delete from pencils where id=" + id);
                    db.ExecuteNonQuery();
                    MessageBox.Show("A Item has been deleted");

                    break;
                case "edit":
                    new Form1(id).Show();
                    this.Hide();

                    break;
            }
            this.loadData();

        }
        private void ListPencils_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void loadData()
        {
            string query = "select p.color, p.price, p.quantity, p.id, c.name as company_name from pencils as p, company as c where p.company_id = c.id";
            DB db = new DB(query);
            DataTable dt = db.GetData();
            gridView.DataSource = dt;
        }
        private void AddCompanyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCompany().Show();
        }

        private void AddPencilBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
