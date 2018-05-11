namespace Yufei_Lin_IA_Linear_Regression
{
    partial class Linear_Regression
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Linear_Regression));
            this.calculate = new System.Windows.Forms.Button();
            this.chartRelationship = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Input_File = new System.Windows.Forms.Button();
            this.rel_Choices = new System.Windows.Forms.ComboBox();
            this.bestFitLine = new System.Windows.Forms.TextBox();
            this.variance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_fileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalNum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.chartRelationship)).BeginInit();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(895, 664);
            this.calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(113, 33);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartRelationship
            // 
            this.chartRelationship.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.White;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chartRelationship.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 20;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Times New Roman", 12F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartRelationship.Legends.Add(legend1);
            this.chartRelationship.Location = new System.Drawing.Point(64, 138);
            this.chartRelationship.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartRelationship.Name = "chartRelationship";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Relationship";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Data";
            this.chartRelationship.Series.Add(series1);
            this.chartRelationship.Series.Add(series2);
            this.chartRelationship.Size = new System.Drawing.Size(926, 430);
            this.chartRelationship.TabIndex = 4;
            this.chartRelationship.Text = "Relationship";
            title1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Relationship";
            this.chartRelationship.Titles.Add(title1);
            this.chartRelationship.Click += new System.EventHandler(this.chartRelationship_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btn_Input_File
            // 
            this.btn_Input_File.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Input_File.Location = new System.Drawing.Point(775, 665);
            this.btn_Input_File.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Input_File.Name = "btn_Input_File";
            this.btn_Input_File.Size = new System.Drawing.Size(96, 32);
            this.btn_Input_File.TabIndex = 6;
            this.btn_Input_File.Text = "Import";
            this.btn_Input_File.UseVisualStyleBackColor = true;
            this.btn_Input_File.Click += new System.EventHandler(this.btn_Input_File_Click);
            // 
            // rel_Choices
            // 
            this.rel_Choices.BackColor = System.Drawing.SystemColors.Window;
            this.rel_Choices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rel_Choices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rel_Choices.FormattingEnabled = true;
            this.rel_Choices.Location = new System.Drawing.Point(621, 66);
            this.rel_Choices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rel_Choices.Name = "rel_Choices";
            this.rel_Choices.Size = new System.Drawing.Size(138, 31);
            this.rel_Choices.TabIndex = 9;
            this.rel_Choices.SelectedIndexChanged += new System.EventHandler(this.rel_Choices_SelectedIndexChanged);
            // 
            // bestFitLine
            // 
            this.bestFitLine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestFitLine.Location = new System.Drawing.Point(12, 64);
            this.bestFitLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bestFitLine.Multiline = true;
            this.bestFitLine.Name = "bestFitLine";
            this.bestFitLine.ReadOnly = true;
            this.bestFitLine.Size = new System.Drawing.Size(208, 27);
            this.bestFitLine.TabIndex = 10;
            this.bestFitLine.Text = "Best-fit Line";
            // 
            // variance
            // 
            this.variance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variance.Location = new System.Drawing.Point(312, 64);
            this.variance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.variance.Name = "variance";
            this.variance.ReadOnly = true;
            this.variance.Size = new System.Drawing.Size(271, 30);
            this.variance.TabIndex = 11;
            this.variance.Text = "Variance of the Best-fit Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Best-fit Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Variance";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 662);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 32);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Progress";
            this.label1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "Graph Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(617, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total: ";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(692, 30);
            this.total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(68, 30);
            this.total.TabIndex = 18;
            this.total.Text = "0";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(895, 728);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "End";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 714);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "File Name";
            // 
            // txtbx_fileName
            // 
            this.txtbx_fileName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_fileName.Location = new System.Drawing.Point(124, 714);
            this.txtbx_fileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_fileName.Multiline = true;
            this.txtbx_fileName.Name = "txtbx_fileName";
            this.txtbx_fileName.ReadOnly = true;
            this.txtbx_fileName.Size = new System.Drawing.Size(376, 55);
            this.txtbx_fileName.TabIndex = 21;
            this.txtbx_fileName.Text = "File Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(800, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Number of Data";
            // 
            // totalNum
            // 
            this.totalNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNum.Location = new System.Drawing.Point(868, 66);
            this.totalNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalNum.Name = "totalNum";
            this.totalNum.ReadOnly = true;
            this.totalNum.Size = new System.Drawing.Size(140, 30);
            this.totalNum.TabIndex = 23;
            this.totalNum.Text = "0";
            this.totalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(775, 728);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Linear_Regression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1055, 778);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.totalNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_fileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.variance);
            this.Controls.Add(this.bestFitLine);
            this.Controls.Add(this.rel_Choices);
            this.Controls.Add(this.btn_Input_File);
            this.Controls.Add(this.chartRelationship);
            this.Controls.Add(this.calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Linear_Regression";
            this.Text = "Linear Regression";
            this.Load += new System.EventHandler(this.Linear_Regression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRelationship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRelationship;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Input_File;
        private System.Windows.Forms.ComboBox rel_Choices;
        private System.Windows.Forms.TextBox bestFitLine;
        private System.Windows.Forms.TextBox variance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_fileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

