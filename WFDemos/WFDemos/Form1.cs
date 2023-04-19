using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WFDemos.Models;

namespace WFDemos
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.countryComboBox.DisplayMember= "Name";
            this.countryComboBox.ValueMember= "Id";
            var countries = this.GetCountries();
            foreach (var country in countries)
            {
                this.countryComboBox.Items.Add(country);
            }
        }

        private IEnumerable<Country> GetCountries()
        {
            return new List<Country>() {
                new Country{ Id =1, Name = "Bulgaria" },
                new Country{ Id =2, Name = "Russia" },
                new Country{ Id =3, Name = "Australia" },
                new Country{ Id =4, Name = "USA" },
                new Country{ Id =5, Name = "Great Britan" }
                };
        }

        private IEnumerable<double> GetPrices(int countryId)
        {
            return new List<double>() { 1.12, 1.33, 1.62, 1.40, 1.08, 1.05, 0.78, 1.06, 1.05, 1.40, 1.72, 1.25 };
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = (ComboBox)sender;
            int countryIndex = cmb.SelectedIndex;
            var countryName = ((Country)cmb.SelectedItem).Name;

            var prices = this.GetPrices(countryIndex);

            var chart = pricesChart.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = prices.Count();

            chart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisY.Minimum = prices.Min() - 2;
            chart.AxisY.Maximum = prices.Max() + 2;

            this.pricesChart.Series.Clear();

            pricesChart.Series.Add(countryName);
            pricesChart.Series[countryName].Color = Color.Blue;
            pricesChart.Series[countryName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            foreach (var price in prices)
            {
                pricesChart.Series[countryName].Points.AddY(price);
            }
        }

        private void showMapButton_Click(object sender, EventArgs e)
        {
            var showMapForm = new ShowGoogleMapForm();
            showMapForm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
