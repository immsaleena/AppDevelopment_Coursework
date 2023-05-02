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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            new Details().Show();
            this.Hide();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            new Graph().Show();
            this.Hide();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            FoodQualityChart.Hide();
            StaffFriendlinessChart.Hide();
            CleanlinessChart.Hide();
            OrderAccuracyChart.Hide();
            ResturantAmbianceChart.Hide();
            ValueForMoneyChart.Hide();

        }
        string[] raw_text = System.IO.File.ReadAllLines(@"..\..\customer.csv");
        string[] data_col = null;
        bool foodQualitycount = true;
        bool StaffFriendlinesscount = true;
        bool Cleanlinesscount = true;
        bool OrderAccuracycount = true;
        bool ResturantAmbiancecount = true;
        bool ValueForMoneycount = true;

        private void comboBoxGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGraph.SelectedIndex == 0)
            {

                FoodQualityChart.Show();
                StaffFriendlinessChart.Hide();
                CleanlinessChart.Hide();
                OrderAccuracyChart.Hide();
                ResturantAmbianceChart.Hide();
                ValueForMoneyChart.Hide();

                if (foodQualitycount == true)
                {
                    int foodQuality1 = 0;
                    int foodQuality2 = 0;
                    int foodQuality3 = 0;
                    int foodQuality4 = 0;


                    foreach (string text_line in raw_text)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 6; i <= 6; i++)
                        {

                            if (data_col[i] == "1")
                            {
                                foodQuality1++;
                            }
                            else if (data_col[i] == "2")
                            {
                                foodQuality2++;
                            }
                            else if (data_col[i] == "3")
                            {
                                foodQuality3++;
                            }
                            else if (data_col[i] == "4")
                            {
                                foodQuality4++;
                            }
                        }
                    }

                    FoodQualityChart.Series["Food Quality"].Points.AddXY("1", @foodQuality1);
                    FoodQualityChart.Series["Food Quality"].Points.AddXY("2", @foodQuality2);
                    FoodQualityChart.Series["Food Quality"].Points.AddXY("3", @foodQuality3);
                    FoodQualityChart.Series["Food Quality"].Points.AddXY("4", @foodQuality4);
                    foodQualitycount = false;
                }
            }

            if (comboBoxGraph.SelectedIndex == 1)
            {
                StaffFriendlinessChart.Show();
                FoodQualityChart.Hide();

                if (StaffFriendlinesscount == true)
                {
                    int StaffFriendliness1 = 0;
                    int StaffFriendliness2 = 0;
                    int StaffFriendliness3 = 0;
                    int StaffFriendliness4 = 0;


                    foreach (string text_line in raw_text)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 7; i <= 7; i++)
                        {

                            if (data_col[i] == "1")
                            {
                                StaffFriendliness1++;
                            }
                            else if (data_col[i] == "2")
                            {
                                StaffFriendliness2++;
                            }
                            else if (data_col[i] == "3")
                            {
                                StaffFriendliness3++;
                            }
                            else if (data_col[i] == "4")
                            {
                                StaffFriendliness4++;
                            }
                        }
                    }

                    StaffFriendlinessChart.Series["Staff Friendliness"].Points.AddXY("1", @StaffFriendliness1);
                    StaffFriendlinessChart.Series["Staff Friendliness"].Points.AddXY("2", @StaffFriendliness2);
                    StaffFriendlinessChart.Series["Staff Friendliness"].Points.AddXY("3", @StaffFriendliness3);
                    StaffFriendlinessChart.Series["Staff Friendliness"].Points.AddXY("4", @StaffFriendliness4);
                    @StaffFriendlinesscount = false;
                }
            }

            if (comboBoxGraph.SelectedIndex == 2)
            {
                CleanlinessChart.Show();

                FoodQualityChart.Hide();
                StaffFriendlinessChart.Hide();

                if (Cleanlinesscount == true)
                {
                    int Cleanliness1 = 0;
                    int Cleanliness2 = 0;
                    int Cleanliness3 = 0;
                    int Cleanliness4 = 0;


                    foreach (string text_line in raw_text)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 8; i <= 8; i++)
                        {

                            if (data_col[i] == "1")
                            {
                                Cleanliness1++;
                            }
                            else if (data_col[i] == "2")
                            {
                                Cleanliness2++;
                            }
                            else if (data_col[i] == "3")
                            {
                                Cleanliness3++;
                            }
                            else if (data_col[i] == "4")
                            {
                                Cleanliness4++;
                            }
                        }
                    }

                    CleanlinessChart.Series["Cleanliness"].Points.AddXY("1", @Cleanliness1);
                    CleanlinessChart.Series["Cleanliness"].Points.AddXY("2", @Cleanliness2);
                    CleanlinessChart.Series["Cleanliness"].Points.AddXY("3", @Cleanliness3);
                    CleanlinessChart.Series["Cleanliness"].Points.AddXY("4", @Cleanliness4);
                    @Cleanlinesscount = false;
                }
            }

            if (comboBoxGraph.SelectedIndex == 3)
            {
                OrderAccuracyChart.Show();

                FoodQualityChart.Hide();
                StaffFriendlinessChart.Hide();
                CleanlinessChart.Hide();

                if (OrderAccuracycount == true)
                {
                    int OrderAccuracy1 = 0;
                    int OrderAccuracy2 = 0;
                    int OrderAccuracy3 = 0;
                    int OrderAccuracy4 = 0;


                    foreach (string text_line in raw_text)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 9; i <= 9; i++)
                        {

                            if (data_col[i] == "1")
                            {
                                OrderAccuracy1++;
                            }
                            else if (data_col[i] == "2")
                            {
                                OrderAccuracy2++;
                            }
                            else if (data_col[i] == "3")
                            {
                                OrderAccuracy3++;
                            }
                            else if (data_col[i] == "4")
                            {
                                OrderAccuracy4++;
                            }
                        }
                    }

                    OrderAccuracyChart.Series["Order Accuracy"].Points.AddXY("1", @OrderAccuracy1);
                    OrderAccuracyChart.Series["Order Accuracy"].Points.AddXY("2", @OrderAccuracy2);
                    OrderAccuracyChart.Series["Order Accuracy"].Points.AddXY("3", @OrderAccuracy3);
                    OrderAccuracyChart.Series["Order Accuracy"].Points.AddXY("4", @OrderAccuracy4);
                    OrderAccuracycount = false;
                }
            }

            if (comboBoxGraph.SelectedIndex == 4)
            {
                ResturantAmbianceChart.Show();

                FoodQualityChart.Hide();
                StaffFriendlinessChart.Hide();
                CleanlinessChart.Hide();
                OrderAccuracyChart.Hide();

                if (ResturantAmbiancecount == true)
                {
                    int ResturantAmbiance1 = 0;
                    int ResturantAmbiance2 = 0;
                    int ResturantAmbiance3 = 0;
                    int ResturantAmbiance4 = 0;


                    foreach (string text_line in raw_text)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 10; i <= 10; i++)
                        {

                            if (data_col[i] == "1")
                            {
                                ResturantAmbiance1++;
                            }
                            else if (data_col[i] == "2")
                            {
                                ResturantAmbiance2++;
                            }
                            else if (data_col[i] == "3")
                            {
                                ResturantAmbiance3++;
                            }
                            else if (data_col[i] == "4")
                            {
                                ResturantAmbiance4++;
                            }
                        }
                    }

                    ResturantAmbianceChart.Series["Resturant Ambiance"].Points.AddXY("1", @ResturantAmbiance1);
                    ResturantAmbianceChart.Series["Resturant Ambiance"].Points.AddXY("2", @ResturantAmbiance2);
                    ResturantAmbianceChart.Series["Resturant Ambiance"].Points.AddXY("3", @ResturantAmbiance3);
                    ResturantAmbianceChart.Series["Resturant Ambiance"].Points.AddXY("4", @ResturantAmbiance4);
                    @ResturantAmbiancecount = false;
                }
            }

            if (comboBoxGraph.SelectedIndex == 5)
            {
                ValueForMoneyChart.Show();

                FoodQualityChart.Hide();
                StaffFriendlinessChart.Hide();
                CleanlinessChart.Hide();
                OrderAccuracyChart.Hide();
                ResturantAmbianceChart.Hide();

                if (ValueForMoneycount == true)
                {
                    int ValueForMoney1 = 0;
                    int ValueForMoney2 = 0;
                    int ValueForMoney3 = 0;
                    int ValueForMoney4 = 0;


                    foreach (string text_line in raw_text)
                    {
                        data_col = text_line.Split(',');
                        for (int i = 11; i <= 11; i++)
                        {

                            if (data_col[i] == "1")
                            {
                                ValueForMoney1++;
                            }
                            else if (data_col[i] == "2")
                            {
                                ValueForMoney2++;
                            }
                            else if (data_col[i] == "3")
                            {
                                ValueForMoney3++;
                            }
                            else if (data_col[i] == "4")
                            {
                                ValueForMoney4++;
                            }
                        }
                    }

                    ValueForMoneyChart.Series["Value For Money"].Points.AddXY("1", @ValueForMoney1);
                    ValueForMoneyChart.Series["Value For Money"].Points.AddXY("2", @ValueForMoney2);
                    ValueForMoneyChart.Series["Value For Money"].Points.AddXY("3", @ValueForMoney3);
                    ValueForMoneyChart.Series["Value For Money"].Points.AddXY("4", @ValueForMoney4);
                    @ValueForMoneycount = false;
                }

            }
        }
    }
}
