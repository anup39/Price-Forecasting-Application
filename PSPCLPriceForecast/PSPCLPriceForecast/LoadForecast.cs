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
    public partial class LoadForecast : MetroForm
    {
        public LoadForecast(string _forecastDate, string _todayDate)
        {
            InitializeComponent();
            forecastDate = _forecastDate;
            todayDate = _todayDate;
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

        private void LoadForecast_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RCodeRun form = new RCodeRun(forecastDate, todayDate);
            form.Show();
            this.Hide();
        }
        
        private void metroButton3_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Maharashtra";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "Maharashtra.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_Maharashtra_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Maharashtra\output";
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

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Delhi";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "Delhi.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_Delhi_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Delhi\output";
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

        private void metroButton6_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Haryana";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "Haryana.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_Haryana_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Haryana\output";
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

        private void metroButton8_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Rajasthan";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "Rajasthan.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_Rajasthan_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Rajasthan\output";
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            LoadForecastExtend form = new LoadForecastExtend(forecastDate, todayDate);
            form.Show();
            this.Hide();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Gujarat";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "Gujarat.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_Gujarat_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Gujarat\output";
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

        private void metroButton12_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\MP";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "MP.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_MP_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\MP\output";
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
