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
    public partial class Form1 : Form
    {
        int id = 0;
        public Form1(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utils.isValidStringInput(colorTextBox.Text)
                || !Utils.isValidStringInput(priceTextBox.Text)
                || !Utils.isValidStringInput(qualityTextBox.Text)
                )
                {
                    MessageBox.Show("Please enter correct input");
                    return;
                }
                string color = colorTextBox.Text;
                double price = Convert.ToDouble(priceTextBox.Text);
                double quantity = Convert.ToDouble(qualityTextBox.Text);
                int companyId = Convert.ToInt32(companyComboBox.SelectedValue);
                if (quantity < 1)
                {
                    MessageBox.Show("Quantity must be above 0");
                    return;
                }

                if (price < 0)
                {
                    MessageBox.Show("Price shouldnt be below 0");
                    return;
                }

                string query;
                if (this.id <1)
                {
                    query = "insert into pencils values(" + companyId + ",'" + color + "'," + price + "," + quantity + ")";

                    DB db = new DB(query);
                    db.ExecuteNonQuery();
                    MessageBox.Show("New pencil item has been created");
                    colorTextBox.Text = "";
                    priceTextBox.Text = "";
                    qualityTextBox.Text = "";
                    companyComboBox.Text = "";
                }
                else
                {
                    query = "update pencils set company_id=" + companyId + ", color='" + color + "',price=" + price + ", quantity=" + quantity +" where id=" +this.id;
                    DB db = new DB(query);
                    db.ExecuteNonQuery();
                    MessageBox.Show("New pencil item has been updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt; DB db;
            db = new DB("select * from company");
            dt = db.GetData();
            companyComboBox.DisplayMember = "name";
            companyComboBox.ValueMember = "id";
            companyComboBox.DataSource = dt;

            if (this.id > 0)
            {
                string query = "select * from pencils where id=" + this.id;
                db = new DB(query);
                dt = db.GetData();
                colorTextBox.Text = dt.Rows[0]["color"].ToString();
                priceTextBox.Text = dt.Rows[0]["price"].ToString();
                qualityTextBox.Text = dt.Rows[0]["quantity"].ToString();
                companyComboBox.SelectedValue = dt.Rows[0]["company_id"].ToString();
            }
        }

        private void ShowPencilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListPencils().Show();
        }

        private void AddCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCompany().Show();
        }
    }
}
