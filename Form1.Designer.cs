namespace Topics_9_11_assignment_2
{
    partial class FormTempGauge
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnFarenheight = new System.Windows.Forms.Button();
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.imgTemp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(363, 24);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "What is the temperature outside?";
            // 
            // btnCelsius
            // 
            this.btnCelsius.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelsius.Location = new System.Drawing.Point(16, 154);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(146, 67);
            this.btnCelsius.TabIndex = 2;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.MouseEnter += new System.EventHandler(this.btnCelsius_MouseEnter);
            this.btnCelsius.MouseLeave += new System.EventHandler(this.btnCelsius_MouseLeave);
            // 
            // btnFarenheight
            // 
            this.btnFarenheight.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarenheight.Location = new System.Drawing.Point(16, 302);
            this.btnFarenheight.Name = "btnFarenheight";
            this.btnFarenheight.Size = new System.Drawing.Size(146, 67);
            this.btnFarenheight.TabIndex = 3;
            this.btnFarenheight.Text = "Farenheight";
            this.btnFarenheight.UseVisualStyleBackColor = true;
            this.btnFarenheight.MouseEnter += new System.EventHandler(this.btnFarenheight_MouseEnter);
            this.btnFarenheight.MouseLeave += new System.EventHandler(this.btnFarenheight_MouseLeave);
            // 
            // numTemp
            // 
            this.numTemp.Location = new System.Drawing.Point(16, 70);
            this.numTemp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTemp.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(146, 20);
            this.numTemp.TabIndex = 4;
            // 
            // imgTemp
            // 
            this.imgTemp.Location = new System.Drawing.Point(298, 70);
            this.imgTemp.Name = "imgTemp";
            this.imgTemp.Size = new System.Drawing.Size(404, 289);
            this.imgTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTemp.TabIndex = 5;
            this.imgTemp.TabStop = false;
            this.imgTemp.Visible = false;
            // 
            // FormTempGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgTemp);
            this.Controls.Add(this.numTemp);
            this.Controls.Add(this.btnFarenheight);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.lblPrompt);
            this.Name = "FormTempGauge";
            this.Text = "Temperature Guage";
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Button btnFarenheight;
        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.PictureBox imgTemp;
    }
}

