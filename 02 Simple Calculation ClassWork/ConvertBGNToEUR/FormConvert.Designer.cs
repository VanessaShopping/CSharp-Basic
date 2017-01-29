namespace ConvertBGNToEUR
{
    partial class FormConvert
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
            this.labelChange = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bgntoeur = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.labelChange2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.eurtobgn = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(13, 13);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(120, 24);
            this.labelChange.TabIndex = 0;
            this.labelChange.Text = "Convert BGN";
            this.labelChange.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown.DecimalPlaces = 2;
            this.numericUpDown.Location = new System.Drawing.Point(155, 8);
            this.numericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // bgntoeur
            // 
            this.bgntoeur.AutoSize = true;
            this.bgntoeur.Location = new System.Drawing.Point(309, 13);
            this.bgntoeur.Name = "bgntoeur";
            this.bgntoeur.Size = new System.Drawing.Size(69, 24);
            this.bgntoeur.TabIndex = 2;
            this.bgntoeur.Text = "to EUR";
            this.bgntoeur.Click += new System.EventHandler(this.label2_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Magenta;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(21, 54);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(356, 33);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // labelChange2
            // 
            this.labelChange2.AutoSize = true;
            this.labelChange2.Location = new System.Drawing.Point(17, 108);
            this.labelChange2.Name = "labelChange2";
            this.labelChange2.Size = new System.Drawing.Size(119, 24);
            this.labelChange2.TabIndex = 4;
            this.labelChange2.Text = "Convert EUR";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(155, 105);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // eurtobgn
            // 
            this.eurtobgn.AutoSize = true;
            this.eurtobgn.Location = new System.Drawing.Point(309, 111);
            this.eurtobgn.Name = "eurtobgn";
            this.eurtobgn.Size = new System.Drawing.Size(70, 24);
            this.eurtobgn.TabIndex = 6;
            this.eurtobgn.Text = "to BGN";
            // 
            // result2
            // 
            this.result2.BackColor = System.Drawing.Color.Magenta;
            this.result2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result2.Location = new System.Drawing.Point(22, 155);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(354, 36);
            this.result2.TabIndex = 7;
            this.result2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result2.Click += new System.EventHandler(this.result2_Click);
            // 
            // FormConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(398, 213);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.eurtobgn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelChange2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.bgntoeur);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.labelChange);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConvert";
            this.Text = "ЛевоСменячка";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label bgntoeur;
        public System.Windows.Forms.Label result;
        private System.Windows.Forms.Label labelChange2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label eurtobgn;
        public System.Windows.Forms.Label result2;
    }
}

