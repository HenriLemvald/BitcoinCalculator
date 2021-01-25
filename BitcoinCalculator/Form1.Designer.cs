
namespace BitcoinCalculator
{
    partial class Form1
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
            this.CurrencyBox = new System.Windows.Forms.ComboBox();
            this.nupuke = new System.Windows.Forms.Button();
            this.AmountOfBitcoins = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.resultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrencyBox
            // 
            this.CurrencyBox.FormattingEnabled = true;
            this.CurrencyBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.CurrencyBox.Location = new System.Drawing.Point(12, 49);
            this.CurrencyBox.Name = "CurrencyBox";
            this.CurrencyBox.Size = new System.Drawing.Size(121, 21);
            this.CurrencyBox.TabIndex = 0;
            this.CurrencyBox.Text = "Select currency";
            this.CurrencyBox.SelectedIndexChanged += new System.EventHandler(this.CurrencyBox_SelectedIndexChanged);
            // 
            // nupuke
            // 
            this.nupuke.Location = new System.Drawing.Point(149, 109);
            this.nupuke.Name = "nupuke";
            this.nupuke.Size = new System.Drawing.Size(75, 23);
            this.nupuke.TabIndex = 1;
            this.nupuke.Text = "Get rates";
            this.nupuke.UseVisualStyleBackColor = true;
            this.nupuke.Click += new System.EventHandler(this.nupuke_Click);
            // 
            // AmountOfBitcoins
            // 
            this.AmountOfBitcoins.Location = new System.Drawing.Point(12, 109);
            this.AmountOfBitcoins.Name = "AmountOfBitcoins";
            this.AmountOfBitcoins.Size = new System.Drawing.Size(121, 20);
            this.AmountOfBitcoins.TabIndex = 2;
            this.AmountOfBitcoins.Text = "Amount of bitcion";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 168);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(120, 20);
            this.Result.TabIndex = 3;
            this.Result.Visible = false;
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Location = new System.Drawing.Point(12, 152);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(37, 13);
            this.resultlabel.TabIndex = 4;
            this.resultlabel.Text = "Result";
            this.resultlabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BitcoinCalculator.Properties.Resources.https___d1e00ek4ebabms_cloudfront_net_production_969e5d7d_8d61_48ae_86ec_8c6b04ab5b7e;
            this.ClientSize = new System.Drawing.Size(687, 393);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.AmountOfBitcoins);
            this.Controls.Add(this.nupuke);
            this.Controls.Add(this.CurrencyBox);
            this.Name = "Form1";
            this.Text = "Bitcoin Caclculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyBox;
        private System.Windows.Forms.Button nupuke;
        private System.Windows.Forms.TextBox AmountOfBitcoins;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label resultlabel;
    }
}

