namespace PSPCLPriceForecast
{
    partial class Scraper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scraper));
            this.scrapeButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.showData = new MetroFramework.Controls.MetroButton();
            this.inputFormat = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.goNext = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // scrapeButton
            // 
            this.scrapeButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.scrapeButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.scrapeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scrapeButton.Location = new System.Drawing.Point(24, 87);
            this.scrapeButton.Name = "scrapeButton";
            this.scrapeButton.Size = new System.Drawing.Size(208, 38);
            this.scrapeButton.TabIndex = 0;
            this.scrapeButton.Text = "Scrape Data from IEX Website";
            this.scrapeButton.UseCustomBackColor = true;
            this.scrapeButton.UseCustomForeColor = true;
            this.scrapeButton.UseSelectable = true;
            this.scrapeButton.UseStyleColors = true;
            this.scrapeButton.Click += new System.EventHandler(this.scrapeButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 142);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(331, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "* Data will be downloaded for the today\'s date entered";
            // 
            // showData
            // 
            this.showData.BackColor = System.Drawing.Color.DodgerBlue;
            this.showData.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.showData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showData.Location = new System.Drawing.Point(258, 87);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(208, 38);
            this.showData.TabIndex = 2;
            this.showData.Text = "Show data";
            this.showData.UseCustomBackColor = true;
            this.showData.UseCustomForeColor = true;
            this.showData.UseSelectable = true;
            this.showData.UseStyleColors = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // inputFormat
            // 
            this.inputFormat.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.inputFormat.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.inputFormat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputFormat.Location = new System.Drawing.Point(24, 296);
            this.inputFormat.Name = "inputFormat";
            this.inputFormat.Size = new System.Drawing.Size(208, 38);
            this.inputFormat.TabIndex = 3;
            this.inputFormat.Text = "Convert to Input Format";
            this.inputFormat.UseCustomBackColor = true;
            this.inputFormat.UseCustomForeColor = true;
            this.inputFormat.UseSelectable = true;
            this.inputFormat.UseStyleColors = true;
            this.inputFormat.Click += new System.EventHandler(this.inputFormat_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(258, 296);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(208, 38);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Show File";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 350);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(340, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "*This is Input to Univariate and Machine Learning models";
            // 
            // goNext
            // 
            this.goNext.Location = new System.Drawing.Point(391, 411);
            this.goNext.Name = "goNext";
            this.goNext.Size = new System.Drawing.Size(75, 26);
            this.goNext.TabIndex = 6;
            this.goNext.Text = "Next";
            this.goNext.UseSelectable = true;
            this.goNext.Click += new System.EventHandler(this.goNext_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(24, 411);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(77, 26);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Back";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroButton3.Location = new System.Drawing.Point(24, 195);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(208, 38);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Check Area Price Url";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.White;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroButton4.Location = new System.Drawing.Point(258, 195);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(208, 38);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "Check Market Snapshot Url";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseStyleColors = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 245);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(329, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "* If scraper doesn\'t work check if the website is working";
            // 
            // Scraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 484);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.goNext);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.inputFormat);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.scrapeButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Scraper";
            this.Text = "Get data for forecasting";
            this.Load += new System.EventHandler(this.Scraper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton scrapeButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton showData;
        private MetroFramework.Controls.MetroButton inputFormat;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton goNext;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}