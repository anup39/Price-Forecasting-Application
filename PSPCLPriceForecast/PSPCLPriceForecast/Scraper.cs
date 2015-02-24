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
    public partial class Scraper : MetroForm
    {
        public Scraper()
        {
            InitializeComponent();
        }

        private void Scraper_Load(object sender, EventArgs e)
        {

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

        private void scrapeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = "D:\\D Drive Data\\PSPCL\\STEP\\Exchange Price Projection\\All States\\SYSTEM";
                Directory.SetCurrentDirectory(directoryPath);
                string[] args = { "scraper.py", todayDate };
                Process.Start("python.exe", String.Join(" ", args));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void showData_Click(object sender, EventArgs e)
        {
            string csvPath = "D:\\D Drive Data\\PSPCL\\STEP\\Exchange Price Projection\\All States\\SYSTEM\\User Input";
            Directory.SetCurrentDirectory(csvPath);
            string csvFile = Path.Combine(csvPath, "user_input.csv");
            try
            {
                Process.Start(csvFile);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Data could not be downloaded!");
            }
        }

        private void inputFormat_Click(object sender, EventArgs e)
        {
            string inputPath = "D:\\D Drive Data\\PSPCL\\STEP\\Exchange Price Projection\\All States\\SYSTEM\\Input Files_Format";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "Automation_price.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("Price_", forecastDate, ".csv");
            string folderName  = "D:\\D Drive Data\\PSPCL\\STEP\\Exchange Price Projection\\All States\\SYSTEM\\Input Files_Format";
            string filePath = Path.Combine(folderName, filename);
            try
            {
                Process.Start(filePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The output file was not generated!");
            }
            
        }

        private void goNext_Click(object sender, EventArgs e)
        {
            RCodeRun form = new RCodeRun(forecastDate, todayDate);
            form.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Dates dateForm = new Dates();
            dateForm.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.iexindia.com/marketdata/areaprice.aspx");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.iexindia.com/marketdata/market_snapshot.aspx");
        }
    }
}
