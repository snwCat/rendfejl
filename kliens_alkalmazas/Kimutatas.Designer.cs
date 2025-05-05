namespace kliens_alkalmazas
{
    partial class Kimutatas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAlacsony = new System.Windows.Forms.Label();
            this.labelMagas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(531, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // labelAlacsony
            // 
            this.labelAlacsony.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlacsony.AutoSize = true;
            this.labelAlacsony.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAlacsony.Location = new System.Drawing.Point(12, 160);
            this.labelAlacsony.Name = "labelAlacsony";
            this.labelAlacsony.Size = new System.Drawing.Size(72, 13);
            this.labelAlacsony.TabIndex = 1;
            this.labelAlacsony.Text = "labelAlacsony";
            this.labelAlacsony.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMagas
            // 
            this.labelMagas.AutoSize = true;
            this.labelMagas.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelMagas.Location = new System.Drawing.Point(12, 9);
            this.labelMagas.Name = "labelMagas";
            this.labelMagas.Size = new System.Drawing.Size(61, 13);
            this.labelMagas.TabIndex = 2;
            this.labelMagas.Text = "labelMagas";
            // 
            // Kimutatas
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 327);
            this.Controls.Add(this.labelMagas);
            this.Controls.Add(this.labelAlacsony);
            this.Name = "Kimutatas";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelAlacsony;
        private System.Windows.Forms.Label labelMagas;
    }
}