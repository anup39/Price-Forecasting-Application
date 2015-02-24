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
    public partial class RCodeRun : MetroForm
    {
        public RCodeRun(string _forecastDate, string _todayDate)
        {
            InitializeComponent();
            forecastDate = _forecastDate;
            todayDate = _todayDate;
        }

        private string forecastDate;
        private string todayDate;

        public string passForecastDate
        {
            get{ return forecastDate; }
            set{ forecastDate = value; }
        }

        public string passTodaysDate
        {
            get{ return todayDate; }
            set{ todayDate = value; }
        }

        private void RCodeRun_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Scraper scraperForm = new Scraper();
            scraperForm.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string folderPath = "D:\\D Drive Data\\PSPCL\\STEP\\Exchange Price Projection\\All States\\SYSTEM\\Univariate_Price";
            Directory.SetCurrentDirectory(folderPath);
            string[] args = { "Final_PriceCode_Univariate_ML.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string folderPath = "D:\\D Drive Data\\PSPCL\\STEP\\Exchange Price Projection\\All States\\SYSTEM";
            Directory.SetCurrentDirectory(folderPath);
            string[] args = { "GmailAttachmentsDemand.py" };
            Process.Start("python.exe", String.Join(" ", args));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LoadForecast loadForm = new LoadForecast(forecastDate, todayDate);
            loadForm.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            string folderPath = "D:\\D Drive Data\\PSPCL\\STEP\\Exchange Price Projection\\All States\\SYSTEM";
            Directory.SetCurrentDirectory(folderPath);
            string[] args = { "GmailAttachments.py" };
            Process.Start("python.exe", String.Join(" ", args));
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("Predictions_price_latest_", forecastDate, ".csv");
            string folderName = @"D:\D Drive data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Univariate_Price\price_output";
            string filePath = Path.Combine(folderName, filename);
            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The output file was not generated!");
            }
        }
    }
}
