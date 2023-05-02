using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rating_System
{
    public partial class Feedback : Form
    {
        public string CriteriaFile = @"..\..\criteria.csv";
        public string CustomerFile = @"..\..\customer.csv";
        public Feedback()
        {
            InitializeComponent();
        }
        public class CriteriaDetail
        {
            public string CriteriaName { get; set; }
        }
        public List<CriteriaDetail> LoadCsvData(string CsvFile)
        {
            var query = from l in File.ReadAllLines(CsvFile)
                        let data = l.Split(',')
                        select new CriteriaDetail
                        {
                            //Id = data[0],
                            CriteriaName = data[0]
                        };

            return query.ToList();
        }
        private void Feedback_Load(object sender, EventArgs e)
        {
            gridFeedback.DataSource = LoadCsvData(CriteriaFile);
            Console.WriteLine("Form data loaded");
            Console.ReadLine();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //double a = double.Parse(txtContactNumber.Text);
            try
            {
                double.Parse(txtContactNumber.Text);
                if (txtContactNumber.TextLength != 10)
                {
                    MessageBox.Show("Contact Number should be of 10 digit");
                    txtContactNumber.Clear();
                    txtContactNumber.Focus();
                }
                else
                {
                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();
                    for (int i = 0; i <= gridFeedback.Rows.Count - 1; i++)
                    {

                        string CriteriaValue = "";
                        try
                        {
                            //string criteria;
                            string Excellent;
                            string Average;
                            string Good;
                            string Disatisfied;

                            if (gridFeedback.Rows[i].Cells[0].Value != null)
                            {
                                Excellent = gridFeedback.Rows[i].Cells[0].Value.ToString(); //True
                                if (Excellent == "True")
                                {
                                    CriteriaValue = "4";
                                    //Console.WriteLine(CriteriaValue);

                                }
                            }
                            if (gridFeedback.Rows[i].Cells[1].Value != null)
                            {

                                Good = gridFeedback.Rows[i].Cells[1].Value.ToString(); //true
                                if (Good == "True")
                                {
                                    CriteriaValue = "3";
                                    // Console.WriteLine(CriteriaValue);

                                }
                            }
                            if (gridFeedback.Rows[i].Cells[2].Value != null)
                            {

                                Average = gridFeedback.Rows[i].Cells[2].Value.ToString(); //true
                                if (Average == "True")
                                {
                                    CriteriaValue = "2";
                                    //Console.WriteLine(CriteriaValue);

                                }
                            }
                            if (gridFeedback.Rows[i].Cells[3].Value != null)
                            {

                                Disatisfied = gridFeedback.Rows[i].Cells[3].Value.ToString(); //true
                                if (Disatisfied == "True")
                                {
                                    CriteriaValue = "1";
                                    //Console.WriteLine(CriteriaValue);

                                }
                            }
                        }
                        catch (InvalidCastException ex)
                        {
                            MessageBox.Show(" " + ex);

                        }

                        if (i == 0)
                        {
                            addRecord(txtCustomerName.Text, txtContactNumber.Text, txtEmail.Text, txtSuggestion.Text, date, time, CriteriaValue, CustomerFile);
                        }
                        else
                        {
                            addRecord1(CriteriaValue, CustomerFile);
                        }
                    }
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(CustomerFile, true))
                {
                    file.Write(@"" + "\n");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Contact Number should be of type int");
                txtContactNumber.Clear();
                txtContactNumber.Focus();
            }
            
        }
        // method to add the feedback to customer file
        public void addRecord(string name, string contact, string email, string message, string date, string time, string feedback, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    //file.WriteLine();
                    file.Write(@"" + name + "," + contact + "," + email + "," + message + "," + date + "," + time + "," + feedback + ",");
                }
                MessageBox.Show("Data Added", "Successful");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }

        }
        public void addRecord1(string feedback, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.Write(feedback + ",");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program is not doing well", ex);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void gridFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var loop = false;
            if (loop == false)
            {
                loop = true;


                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        if (i != e.ColumnIndex)
                        {
                            gridFeedback.Rows[(e.RowIndex)].Cells[i].Value = false;
                        }

                    }
                    gridFeedback.EndEdit();

                }
            }
        }
    }
}

