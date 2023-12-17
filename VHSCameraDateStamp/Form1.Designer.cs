namespace VHSCameraDateStamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.image = new System.Windows.Forms.PictureBox();
            this.startHours = new System.Windows.Forms.NumericUpDown();
            this.startMins = new System.Windows.Forms.NumericUpDown();
            this.startSecs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lengthSecs = new System.Windows.Forms.NumericUpDown();
            this.lengthMins = new System.Windows.Forms.NumericUpDown();
            this.lengthHours = new System.Windows.Forms.NumericUpDown();
            this.Location = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.Month = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Image = global::VHSCameraDateStamp.Properties.Resources.preview;
            this.image.Location = new System.Drawing.Point(30, 25);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(246, 64);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // startHours
            // 
            this.startHours.Location = new System.Drawing.Point(313, 25);
            this.startHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.startHours.Name = "startHours";
            this.startHours.Size = new System.Drawing.Size(105, 20);
            this.startHours.TabIndex = 2;
            // 
            // startMins
            // 
            this.startMins.Location = new System.Drawing.Point(448, 24);
            this.startMins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.startMins.Name = "startMins";
            this.startMins.Size = new System.Drawing.Size(120, 20);
            this.startMins.TabIndex = 3;
            // 
            // startSecs
            // 
            this.startSecs.Location = new System.Drawing.Point(598, 23);
            this.startSecs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.startSecs.Name = "startSecs";
            this.startSecs.Size = new System.Drawing.Size(120, 20);
            this.startSecs.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Video length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = ":";
            // 
            // lengthSecs
            // 
            this.lengthSecs.Location = new System.Drawing.Point(598, 63);
            this.lengthSecs.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.lengthSecs.Name = "lengthSecs";
            this.lengthSecs.Size = new System.Drawing.Size(120, 20);
            this.lengthSecs.TabIndex = 14;
            // 
            // lengthMins
            // 
            this.lengthMins.Location = new System.Drawing.Point(448, 63);
            this.lengthMins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.lengthMins.Name = "lengthMins";
            this.lengthMins.Size = new System.Drawing.Size(120, 20);
            this.lengthMins.TabIndex = 13;
            // 
            // lengthHours
            // 
            this.lengthHours.Location = new System.Drawing.Point(313, 64);
            this.lengthHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.lengthHours.Name = "lengthHours";
            this.lengthHours.Size = new System.Drawing.Size(105, 20);
            this.lengthHours.TabIndex = 12;
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(313, 149);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(378, 20);
            this.Location.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Save to file:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 64);
            this.button2.TabIndex = 22;
            this.button2.Text = "Go!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Date:";
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(313, 107);
            this.Day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(105, 20);
            this.Day.TabIndex = 24;
            this.Day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(598, 108);
            this.year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(120, 20);
            this.year.TabIndex = 25;
            this.year.Value = new decimal(new int[] {
            1998,
            0,
            0,
            0});
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.Month.Location = new System.Drawing.Point(448, 107);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(120, 21);
            this.Month.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 177);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lengthSecs);
            this.Controls.Add(this.lengthMins);
            this.Controls.Add(this.lengthHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startSecs);
            this.Controls.Add(this.startMins);
            this.Controls.Add(this.startHours);
            this.Controls.Add(this.image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 216);
            this.MinimumSize = new System.Drawing.Size(740, 216);
            this.Name = "Form1";
            this.Text = "VHS Datestamp Generator by WoodcraftWorld";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.NumericUpDown startHours;
        private System.Windows.Forms.NumericUpDown startMins;
        private System.Windows.Forms.NumericUpDown startSecs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown lengthSecs;
        private System.Windows.Forms.NumericUpDown lengthMins;
        private System.Windows.Forms.NumericUpDown lengthHours;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Day;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.ComboBox Month;
    }
}

