using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSPCLPriceForecast
{
    public partial class Dates : MetroForm
    {
        public Dates()
        {
            InitializeComponent();
        }

        private void Dates_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Scraper form = new Scraper();
            form.passForecastDate = ForecastDate.Text;
            form.passTodaysDate = TodayDate.Text;
            form.Show();
            this.Hide();
        }
    }
}
