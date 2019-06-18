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
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string companyName = companyTextBox.Text;
                if (!Utils.isValidStringInput(companyName))
                {
                    MessageBox.Show("Please enter value");
                    return;
                }

                DB db = new DB("insert into company  values('" + companyName + "')");
                db.ExecuteNonQuery();
                MessageBox.Show("New company has been created");
                companyTextBox.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void MenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AddPencilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void ShowPencilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListPencils().Show();
        }
    }
}
