namespace Temperatyra
{
    partial class frmTempConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFarenheit = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.White;
            this.lblHeading.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(222, 42);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(358, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Фаренхайт-Целзий конвертор";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCelsius.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCelsius.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCelsius.Location = new System.Drawing.Point(21, 159);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(195, 20);
            this.lblCelsius.TabIndex = 1;
            this.lblCelsius.Text = "Градуси по Целзии";
            this.lblCelsius.Click += new System.EventHandler(this.lblCelsius_Click);
            // 
            // lblFarenheit
            // 
            this.lblFarenheit.AutoSize = true;
            this.lblFarenheit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFarenheit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFarenheit.Location = new System.Drawing.Point(21, 226);
            this.lblFarenheit.Name = "lblFarenheit";
            this.lblFarenheit.Size = new System.Drawing.Size(229, 20);
            this.lblFarenheit.TabIndex = 2;
            this.lblFarenheit.Text = "Градуси по Фаренхайт";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(303, 159);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(75, 27);
            this.txtCelsius.TabIndex = 3;
            // 
            // frmTempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblFarenheit);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblHeading);
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "frmTempConverter";
            this.Text = "Температурен конвертор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeading;
        private Label lblCelsius;
        private Label lblFarenheit;
        private TextBox txtCelsius;
    }
}