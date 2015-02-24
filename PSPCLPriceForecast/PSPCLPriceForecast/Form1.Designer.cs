namespace PSPCLPriceForecast
{
    partial class PriceForecast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceForecast));
            this.continueButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.continueButton.Location = new System.Drawing.Point(123, 114);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(110, 35);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "Continue";
            this.continueButton.UseCustomBackColor = true;
            this.continueButton.UseCustomForeColor = true;
            this.continueButton.UseSelectable = true;
            this.continueButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PriceForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 202);
            this.Controls.Add(this.continueButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriceForecast";
            this.Padding = new System.Windows.Forms.Padding(30, 83, 30, 28);
            this.Text = "PSPCL Forecasting Application";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton continueButton;


    }
}

