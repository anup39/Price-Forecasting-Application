using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPCLPriceForecast
{
    public partial class PriceCombination : MetroForm
    {
        public PriceCombination(string _forecastDate, string _todaysDate)
        {
            InitializeComponent();
            forecastDate = _forecastDate;
            todayDate = _todaysDate;
        }

        private string forecastDate;
        private string todayDate;

        public string passForecastDate
        {
            get { return forecastDate; }
            set { forecastDate = value; }
        }

        public string passTodaysDate
        {
            get { return todayDate; }
            set { todayDate = value; }
        }

        private void PriceCombination_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Price Model_No IPP";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "final_PriceModel.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Price Model_IPP";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "final_PriceModel_IPP.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Combination_Price";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "Price_final_MCS.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("Graphs.pdf");
            string folderName = @"D:\D Drive data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\FINAL PRICE";
            string filePath = Path.Combine(folderName, filename);
            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The graph was not generated!");
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string noDays = noOfDays.Text;
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\FINAL PRICE";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "graphs.R", forecastDate, noDays };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LoadForecastExtend form = new LoadForecastExtend(forecastDate, todayDate);
            form.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
