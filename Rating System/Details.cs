using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rating_System
{
    public partial class Details : Form
    {
        public string CriteriaFile = @"..\..\criteria.csv";
        public Details()
        {
            InitializeComponent();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            new Graph().Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            new Details().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            string criteraiName = txtCriteria.Text;
            AddRecord(criteraiName, CriteriaFile);
        }
        // method for add criteria to csv file
        public void AddRecord(string criteria, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    //file.WriteLine();
                    file.Write(@"" + criteria + "\n"); // add criteria to new line
                }
                MessageBox.Show("Criteria Added");
            }

            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCriteria.Clear();
        }
    }
}
