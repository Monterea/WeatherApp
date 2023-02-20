
namespace WinFormsWeather {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbWeather = new System.Windows.Forms.Label();
            this.lbCloudcover = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.lbWind = new System.Windows.Forms.Label();
            this.lbHuminidy = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.lbLocalTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(new object[] {
            "Ostrava",
            "Karvina",
            "Havirov",
            "Bohumin",
            "Cesky_Tesin",
            "Madrid",
            "Helsinki",
            "Sydney"});
            this.comboBoxCities.Location = new System.Drawing.Point(103, 32);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCities.TabIndex = 0;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Počasí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teplota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vlhkost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vítr:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Oblačnost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tlak:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Aktuální čas:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(151, 82);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(56, 20);
            this.lbCity.TabIndex = 9;
            this.lbCity.Text = "MĚSTO";
            // 
            // lbWeather
            // 
            this.lbWeather.AutoSize = true;
            this.lbWeather.Location = new System.Drawing.Point(134, 139);
            this.lbWeather.Name = "lbWeather";
            this.lbWeather.Size = new System.Drawing.Size(0, 20);
            this.lbWeather.TabIndex = 10;
            // 
            // lbCloudcover
            // 
            this.lbCloudcover.AutoSize = true;
            this.lbCloudcover.Location = new System.Drawing.Point(134, 172);
            this.lbCloudcover.Name = "lbCloudcover";
            this.lbCloudcover.Size = new System.Drawing.Size(0, 20);
            this.lbCloudcover.TabIndex = 11;
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(134, 208);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(0, 20);
            this.lbTemperature.TabIndex = 12;
            // 
            // lbWind
            // 
            this.lbWind.AutoSize = true;
            this.lbWind.Location = new System.Drawing.Point(134, 244);
            this.lbWind.Name = "lbWind";
            this.lbWind.Size = new System.Drawing.Size(0, 20);
            this.lbWind.TabIndex = 13;
            // 
            // lbHuminidy
            // 
            this.lbHuminidy.AutoSize = true;
            this.lbHuminidy.Location = new System.Drawing.Point(134, 281);
            this.lbHuminidy.Name = "lbHuminidy";
            this.lbHuminidy.Size = new System.Drawing.Size(0, 20);
            this.lbHuminidy.TabIndex = 14;
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.Location = new System.Drawing.Point(134, 319);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(0, 20);
            this.lbPressure.TabIndex = 15;
            // 
            // lbLocalTime
            // 
            this.lbLocalTime.AutoSize = true;
            this.lbLocalTime.Location = new System.Drawing.Point(134, 356);
            this.lbLocalTime.Name = "lbLocalTime";
            this.lbLocalTime.Size = new System.Drawing.Size(0, 20);
            this.lbLocalTime.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 388);
            this.Controls.Add(this.lbLocalTime);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.lbHuminidy);
            this.Controls.Add(this.lbWind);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.lbCloudcover);
            this.Controls.Add(this.lbWeather);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbWeather;
        private System.Windows.Forms.Label lbCloudcover;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbWind;
        private System.Windows.Forms.Label lbHuminidy;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.Label lbLocalTime;
    }
}

