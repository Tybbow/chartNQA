namespace ChartNQA
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labeltrack = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackPoints = new System.Windows.Forms.TrackBar();
            this.groupOpt = new System.Windows.Forms.GroupBox();
            this.checkboxGridY = new System.Windows.Forms.CheckBox();
            this.checkboxGridX = new System.Windows.Forms.CheckBox();
            this.CheckboxSta = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDateTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDateFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturePDF = new System.Windows.Forms.PictureBox();
            this.picturePNG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPoints)).BeginInit();
            this.groupOpt.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePNG)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(227, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1228, 773);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "mychart";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.picturePDF);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.picturePNG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labeltrack);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.trackPoints);
            this.panel1.Controls.Add(this.groupOpt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textDateTo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textDateFrom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textTitle);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 758);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(174, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(11, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "1";
            // 
            // labeltrack
            // 
            this.labeltrack.AutoSize = true;
            this.labeltrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltrack.ForeColor = System.Drawing.Color.IndianRed;
            this.labeltrack.Location = new System.Drawing.Point(163, 362);
            this.labeltrack.Name = "labeltrack";
            this.labeltrack.Size = new System.Drawing.Size(25, 15);
            this.labeltrack.TabIndex = 19;
            this.labeltrack.Text = "NA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Number of Points";
            // 
            // trackPoints
            // 
            this.trackPoints.Enabled = false;
            this.trackPoints.LargeChange = 10;
            this.trackPoints.Location = new System.Drawing.Point(5, 375);
            this.trackPoints.Name = "trackPoints";
            this.trackPoints.Size = new System.Drawing.Size(190, 45);
            this.trackPoints.SmallChange = 5;
            this.trackPoints.TabIndex = 17;
            this.trackPoints.TickFrequency = 3;
            this.trackPoints.ValueChanged += new System.EventHandler(this.trackPoints_ValueChanged);
            // 
            // groupOpt
            // 
            this.groupOpt.Controls.Add(this.checkboxGridY);
            this.groupOpt.Controls.Add(this.checkboxGridX);
            this.groupOpt.Controls.Add(this.CheckboxSta);
            this.groupOpt.Location = new System.Drawing.Point(5, 522);
            this.groupOpt.Name = "groupOpt";
            this.groupOpt.Size = new System.Drawing.Size(190, 109);
            this.groupOpt.TabIndex = 16;
            this.groupOpt.TabStop = false;
            this.groupOpt.Text = "Options :";
            // 
            // checkboxGridY
            // 
            this.checkboxGridY.AutoSize = true;
            this.checkboxGridY.Location = new System.Drawing.Point(6, 69);
            this.checkboxGridY.Name = "checkboxGridY";
            this.checkboxGridY.Size = new System.Drawing.Size(92, 17);
            this.checkboxGridY.TabIndex = 17;
            this.checkboxGridY.Text = "Display Grid Y";
            this.checkboxGridY.UseVisualStyleBackColor = true;
            this.checkboxGridY.CheckStateChanged += new System.EventHandler(this.checkboxGridY_CheckStateChanged);
            // 
            // checkboxGridX
            // 
            this.checkboxGridX.AutoSize = true;
            this.checkboxGridX.Location = new System.Drawing.Point(6, 46);
            this.checkboxGridX.Name = "checkboxGridX";
            this.checkboxGridX.Size = new System.Drawing.Size(92, 17);
            this.checkboxGridX.TabIndex = 16;
            this.checkboxGridX.Text = "Display Grid X";
            this.checkboxGridX.UseVisualStyleBackColor = true;
            this.checkboxGridX.CheckStateChanged += new System.EventHandler(this.checkboxGridX_CheckStateChanged);
            // 
            // CheckboxSta
            // 
            this.CheckboxSta.AutoSize = true;
            this.CheckboxSta.Location = new System.Drawing.Point(6, 23);
            this.CheckboxSta.Name = "CheckboxSta";
            this.CheckboxSta.Size = new System.Drawing.Size(105, 17);
            this.CheckboxSta.TabIndex = 15;
            this.CheckboxSta.Text = "Display Statistics";
            this.CheckboxSta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date To :";
            // 
            // textDateTo
            // 
            this.textDateTo.Location = new System.Drawing.Point(5, 484);
            this.textDateTo.Name = "textDateTo";
            this.textDateTo.Size = new System.Drawing.Size(190, 20);
            this.textDateTo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date From :";
            // 
            // textDateFrom
            // 
            this.textDateFrom.Location = new System.Drawing.Point(5, 442);
            this.textDateFrom.Name = "textDateFrom";
            this.textDateFrom.Size = new System.Drawing.Size(190, 20);
            this.textDateFrom.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Multiple X value :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title : ";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(5, 80);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(190, 20);
            this.textTitle.TabIndex = 6;
            this.textTitle.Text = "NA";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(102, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Run...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(194, 225);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select File...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1467, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "About !";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // picturePDF
            // 
            this.picturePDF.BackColor = System.Drawing.SystemColors.Window;
            this.picturePDF.Enabled = false;
            this.picturePDF.Image = global::ChartNQA.Properties.Resources.PDF;
            this.picturePDF.Location = new System.Drawing.Point(68, 703);
            this.picturePDF.Name = "picturePDF";
            this.picturePDF.Size = new System.Drawing.Size(48, 48);
            this.picturePDF.TabIndex = 5;
            this.picturePDF.TabStop = false;
            this.picturePDF.Click += new System.EventHandler(this.picturePDF_Click);
            // 
            // picturePNG
            // 
            this.picturePNG.BackColor = System.Drawing.SystemColors.Window;
            this.picturePNG.Enabled = false;
            this.picturePNG.Image = global::ChartNQA.Properties.Resources.PNG;
            this.picturePNG.InitialImage = null;
            this.picturePNG.Location = new System.Drawing.Point(11, 703);
            this.picturePNG.Name = "picturePNG";
            this.picturePNG.Size = new System.Drawing.Size(48, 48);
            this.picturePNG.TabIndex = 4;
            this.picturePNG.TabStop = false;
            this.picturePNG.Click += new System.EventHandler(this.picturePNG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 797);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ChartNQA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPoints)).EndInit();
            this.groupOpt.ResumeLayout(false);
            this.groupOpt.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePNG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupOpt;
        private System.Windows.Forms.CheckBox CheckboxSta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackPoints;
        private System.Windows.Forms.Label labeltrack;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkboxGridX;
        private System.Windows.Forms.PictureBox picturePNG;
        private System.Windows.Forms.PictureBox picturePDF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.CheckBox checkboxGridY;
    }
}

