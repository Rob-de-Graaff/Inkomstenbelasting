namespace Inkomstenbelasting
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.listBoxTariffgroup = new System.Windows.Forms.ListBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.listBoxTariffgroup);
            this.panelLayout.Controls.Add(this.labelVolume);
            this.panelLayout.Controls.Add(this.textBoxIncome);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 12);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(640, 235);
            this.panelLayout.TabIndex = 28;
            // 
            // listBoxTariffgroup
            // 
            this.listBoxTariffgroup.FormattingEnabled = true;
            this.listBoxTariffgroup.ItemHeight = 16;
            this.listBoxTariffgroup.Location = new System.Drawing.Point(6, 3);
            this.listBoxTariffgroup.Name = "listBoxTariffgroup";
            this.listBoxTariffgroup.Size = new System.Drawing.Size(243, 68);
            this.listBoxTariffgroup.TabIndex = 60;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(10, 86);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(137, 17);
            this.labelVolume.TabIndex = 56;
            this.labelVolume.Text = "Belastbaar inkomen:";
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(153, 83);
            this.textBoxIncome.MaxLength = 7;
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(96, 22);
            this.textBoxIncome.TabIndex = 55;
            this.textBoxIncome.Text = "0";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(6, 199);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(3, 128);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(3, 172);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.ListBox listBoxTariffgroup;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
    }
}

