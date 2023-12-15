namespace ViewDesemp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            ramtotal = new Label();
            ramusada = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // ramtotal
            // 
            ramtotal.AutoSize = true;
            ramtotal.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ramtotal.ForeColor = SystemColors.ActiveCaptionText;
            ramtotal.Location = new Point(38, 197);
            ramtotal.Name = "ramtotal";
            ramtotal.Size = new Size(119, 46);
            ramtotal.TabIndex = 2;
            ramtotal.Text = "00000 ";
            ramtotal.UseMnemonic = false;
            ramtotal.Visible = false;
            ramtotal.Click += ramtotal_Click;
            // 
            // ramusada
            // 
            ramusada.AutoSize = true;
            ramusada.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            ramusada.ForeColor = SystemColors.ActiveCaptionText;
            ramusada.Location = new Point(38, 243);
            ramusada.Name = "ramusada";
            ramusada.Size = new Size(119, 46);
            ramusada.TabIndex = 3;
            ramusada.Text = "00000 ";
            ramusada.Visible = false;
            ramusada.Click += ramusada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(86, 182);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "RAM TOTAL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(72, 289);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "RAM UTILIZADA";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(137, 197);
            label3.Name = "label3";
            label3.Size = new Size(62, 46);
            label3.TabIndex = 6;
            label3.Text = "GB";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(137, 243);
            label4.Name = "label4";
            label4.Size = new Size(62, 46);
            label4.TabIndex = 7;
            label4.Text = "GB";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(369, 43);
            label7.Name = "label7";
            label7.Size = new Size(93, 46);
            label7.TabIndex = 10;
            label7.Text = "RAM";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(768, 43);
            label8.Name = "label8";
            label8.Size = new Size(83, 46);
            label8.TabIndex = 11;
            label8.Text = "CPU";
            label8.Click += label8_Click;
            // 
            // chart1
            // 
            chart1.BackColor = Color.Transparent;
            chart1.BackgroundImageLayout = ImageLayout.None;
            chart1.BackImageTransparentColor = Color.Transparent;
            chart1.BackSecondaryColor = Color.Black;
            chart1.BorderlineColor = Color.Black;
            chart1.BorderSkin.PageColor = Color.Black;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(221, 92);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart1.PaletteCustomColors = new Color[] { Color.Green, Color.FromArgb(255, 128, 0) };
            chart1.Size = new Size(388, 351);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chart2.BackgroundImageLayout = ImageLayout.Zoom;
            chart2.BackImageTransparentColor = Color.Transparent;
            chart2.BackSecondaryColor = Color.Black;
            chart2.BorderlineColor = Color.Black;
            chart2.BorderSkin.BackColor = Color.Transparent;
            chart2.BorderSkin.PageColor = Color.Black;
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            chart2.Location = new Point(615, 92);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chart2.PaletteCustomColors = new Color[] { Color.YellowGreen, Color.OrangeRed };
            chart2.Size = new Size(388, 351);
            chart2.TabIndex = 13;
            chart2.Text = "chart2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            CausesValidation = false;
            ClientSize = new Size(1076, 486);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ramusada);
            Controls.Add(ramtotal);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MaximumSize = new Size(1092, 525);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1092, 525);
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ramtotal;
        private Label ramusada;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}