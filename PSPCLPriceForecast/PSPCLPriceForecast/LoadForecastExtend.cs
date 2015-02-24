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
    public partial class LoadForecastExtend : MetroForm
    {
        public LoadForecastExtend(string _forecastDate, string _todayDate)
        {
            InitializeComponent();
            forecastDate = _forecastDate;
            todayDate = _todayDate;
        }

        private void LoadForecastExtend_Load(object sender, EventArgs e)
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\UP";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "UP.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_UP_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\UP\output";
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

        private void metroButton5_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\UK";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "UK.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_UK_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\UK\output";
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\WB";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "WB.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_WB_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\WB\output";
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

        private void metroButton7_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Orissa";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "Orissa.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            string filename = String.Concat("latest_Orissa_", forecastDate, ".csv");
            string folderName = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Orissa\output";
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

        private void metroButton9_Click(object sender, EventArgs e)
        {
            LoadForecast form = new LoadForecast(forecastDate, todayDate);
            form.Show();
            this.Hide();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            PriceCombination form = new PriceCombination(forecastDate, todayDate);
            form.Show();
            this.Hide();
        }

        private void runTogether_Click(object sender, EventArgs e)
        {
            // Run R script for Maharashtra
            Process maharashtra = new Process();
            string inputPathMa = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Maharashtra";
            Directory.SetCurrentDirectory(inputPathMa);
            string[] argsMa = { "Maharashtra.R", forecastDate, todayDate };
            maharashtra.StartInfo.FileName = "rscript.exe";
            maharashtra.StartInfo.Arguments = String.Join(" ", argsMa);
            maharashtra.Start();
            maharashtra.WaitForExit();

            //Run R script for Delhi
            Process delhi = new Process();
            string inputPathDl = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Delhi";
            Directory.SetCurrentDirectory(inputPathDl);
            string[] argsDl = { "Delhi.R", forecastDate, todayDate };
            delhi.StartInfo.FileName = "rscript.exe";
            delhi.StartInfo.Arguments = String.Join(" ", argsDl);
            delhi.Start();
            delhi.WaitForExit();

            // Run R script for Haryana
            Process haryana = new Process();
            string inputPathHr = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Haryana";
            Directory.SetCurrentDirectory(inputPathHr);
            string[] argsHr = { "Haryana.R", forecastDate, todayDate };
            haryana.StartInfo.FileName = "rscript.exe";
            haryana.StartInfo.Arguments = String.Join(" ", argsHr);
            haryana.Start();
            haryana.WaitForExit();


            // Run R script for Rajasthan
            Process rajasthan = new Process();
            string inputPathRj = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Rajasthan";
            Directory.SetCurrentDirectory(inputPathRj);
            string[] argsRj = { "Rajasthan.R", forecastDate, todayDate };
            rajasthan.StartInfo.FileName = "rscript.exe";
            rajasthan.StartInfo.Arguments = String.Join(" ", argsRj);
            rajasthan.Start();
            rajasthan.WaitForExit();


            // Run R script for Gujarat
            Process gujarat = new Process();
            string inputPathGj = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Gujarat";
            Directory.SetCurrentDirectory(inputPathGj);
            string[] argsGj = { "Gujarat.R", forecastDate, todayDate };
            gujarat.StartInfo.FileName = "rscript.exe";
            gujarat.StartInfo.Arguments = String.Join(" ", argsGj);
            gujarat.Start();
            gujarat.WaitForExit();


            // Run R script for Madhya Pradesh
            Process madhyaPradesh = new Process();
            string inputPathMp = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\MP";
            Directory.SetCurrentDirectory(inputPathMp);
            string[] argsMp = { "MP.R", forecastDate, todayDate };
            madhyaPradesh.StartInfo.FileName = "rscript.exe";
            madhyaPradesh.StartInfo.Arguments = String.Join(" ", argsMp);
            madhyaPradesh.Start();
            madhyaPradesh.WaitForExit();


            // Run R script for Uttar Pradesh
            Process uttarPradesh = new Process();
            string inputPathUp = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\UP";
            Directory.SetCurrentDirectory(inputPathUp);
            string[] argsUp = { "UP.R", forecastDate, todayDate };
            uttarPradesh.StartInfo.FileName = "rscript.exe";
            uttarPradesh.StartInfo.Arguments = String.Join(" ", argsUp);
            uttarPradesh.Start();
            uttarPradesh.WaitForExit();


            // Run R script for Uttarakhand
            Process uttarakhand = new Process();
            string inputPathUk = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\UK";
            Directory.SetCurrentDirectory(inputPathUk);
            string[] argsUk = { "UK.R", forecastDate, todayDate };
            uttarakhand.StartInfo.FileName = "rscript.exe";
            uttarakhand.StartInfo.Arguments = String.Join(" ", argsUk);
            uttarakhand.Start();
            uttarakhand.WaitForExit();


            // Run R script for West Bengal 
            Process westBengal = new Process();
            string inputPathWb = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\WB";
            Directory.SetCurrentDirectory(inputPathWb);
            string[] argsWb = { "WB.R", forecastDate, todayDate };
            westBengal.StartInfo.FileName = "rscript.exe";
            westBengal.StartInfo.Arguments = String.Join(" ", argsWb);
            westBengal.Start();
            westBengal.WaitForExit();


            // Run R script for Orissa
            Process orissa = new Process();
            string inputPathOr = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Orissa";
            Directory.SetCurrentDirectory(inputPathOr);
            string[] argsOr = { "UK.R", forecastDate, todayDate };
            orissa.StartInfo.FileName = "rscript.exe";
            orissa.StartInfo.Arguments = String.Join(" ", argsOr);
            orissa.Start();
            orissa.WaitForExit();

        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            string inputPath = @"D:\D Drive Data\PSPCL\STEP\Exchange Price Projection\All States\SYSTEM\Combination";
            Directory.SetCurrentDirectory(inputPath);
            string[] args = { "load forecasts_All States.R", forecastDate, todayDate };
            Process.Start("rscript.exe", String.Join(" ", args));
        }




    }
}
