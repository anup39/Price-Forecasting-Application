namespace PSPCLPriceForecast
{
    partial class Dates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dates));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ForecastDate = new MetroFramework.Controls.MetroTextBox();
            this.TodayDate = new MetroFramework.Controls.MetroTextBox();
            this.NextButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Forecast Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(24, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Today\'s Date";
            // 
            // ForecastDate
            // 
            this.ForecastDate.Lines = new string[0];
            this.ForecastDate.Location = new System.Drawing.Point(168, 72);
            this.ForecastDate.MaxLength = 32767;
            this.ForecastDate.Name = "ForecastDate";
            this.ForecastDate.PasswordChar = '\0';
            this.ForecastDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ForecastDate.SelectedText = "";
            this.ForecastDate.Size = new System.Drawing.Size(169, 23);
            this.ForecastDate.TabIndex = 2;
            this.ForecastDate.UseSelectable = true;
            // 
            // TodayDate
            // 
            this.TodayDate.Lines = new string[0];
            this.TodayDate.Location = new System.Drawing.Point(168, 107);
            this.TodayDate.MaxLength = 32767;
            this.TodayDate.Name = "TodayDate";
            this.TodayDate.PasswordChar = '\0';
            this.TodayDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TodayDate.SelectedText = "";
            this.TodayDate.Size = new System.Drawing.Size(169, 23);
            this.TodayDate.TabIndex = 3;
            this.TodayDate.UseSelectable = true;
            // 
            // NextButton
            // 
            this.NextButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.NextButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NextButton.Location = new System.Drawing.Point(24, 159);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(62, 25);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseCustomBackColor = true;
            this.NextButton.UseCustomForeColor = true;
            this.NextButton.UseSelectable = true;
            this.NextButton.UseStyleColors = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(365, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Eg. [ 20012015 ]";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(365, 106);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Eg. [ 19012015 ]";
            // 
            // Dates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 207);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.TodayDate);
            this.Controls.Add(this.ForecastDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dates";
            this.Text = "Choose Dates";
            this.Load += new System.EventHandler(this.Dates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ForecastDate;
        private MetroFramework.Controls.MetroTextBox TodayDate;
        private MetroFramework.Controls.MetroButton NextButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}