namespace WFDemos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pricesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.showMapButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pricesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(116, 29);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(307, 21);
            this.countryComboBox.TabIndex = 0;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country";
            // 
            // pricesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pricesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pricesChart.Legends.Add(legend2);
            this.pricesChart.Location = new System.Drawing.Point(23, 81);
            this.pricesChart.Name = "pricesChart";
            this.pricesChart.Size = new System.Drawing.Size(748, 332);
            this.pricesChart.TabIndex = 2;
            this.pricesChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Choose some value from combobox to display chart as line";
            // 
            // showMapButton
            // 
            this.showMapButton.Location = new System.Drawing.Point(551, 29);
            this.showMapButton.Name = "showMapButton";
            this.showMapButton.Size = new System.Drawing.Size(220, 23);
            this.showMapButton.TabIndex = 4;
            this.showMapButton.Text = "Display Google Maps";
            this.showMapButton.UseVisualStyleBackColor = true;
            this.showMapButton.Click += new System.EventHandler(this.showMapButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showMapButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pricesChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pricesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pricesChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showMapButton;
    }
}

