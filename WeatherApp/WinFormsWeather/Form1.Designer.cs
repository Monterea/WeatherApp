
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
			this.lbCity = new System.Windows.Forms.Label();
			this.lbHumidity = new System.Windows.Forms.Label();
			this.lbTemperature = new System.Windows.Forms.Label();
			this.lbWeather = new System.Windows.Forms.Label();
			this.lbWind = new System.Windows.Forms.Label();
			this.lbLocalTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBoxCities
			// 
			this.comboBoxCities.FormattingEnabled = true;
			this.comboBoxCities.Items.AddRange(new object[] {
            "Ostrava",
            "Bruntal",
            "Ottawa",
            "Sydney"});
			this.comboBoxCities.Location = new System.Drawing.Point(45, 13);
			this.comboBoxCities.Name = "comboBoxCities";
			this.comboBoxCities.Size = new System.Drawing.Size(121, 23);
			this.comboBoxCities.TabIndex = 0;
			this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.comboBoxCities_SelectedIndexChanged);
			// 
			// lbCity
			// 
			this.lbCity.AutoSize = true;
			this.lbCity.Location = new System.Drawing.Point(77, 55);
			this.lbCity.Name = "lbCity";
			this.lbCity.Size = new System.Drawing.Size(28, 15);
			this.lbCity.TabIndex = 1;
			this.lbCity.Text = "City";
			// 
			// lbHumidity
			// 
			this.lbHumidity.AutoSize = true;
			this.lbHumidity.Location = new System.Drawing.Point(77, 87);
			this.lbHumidity.Name = "lbHumidity";
			this.lbHumidity.Size = new System.Drawing.Size(57, 15);
			this.lbHumidity.TabIndex = 2;
			this.lbHumidity.Text = "Humidity";
			// 
			// lbTemperature
			// 
			this.lbTemperature.AutoSize = true;
			this.lbTemperature.Location = new System.Drawing.Point(77, 106);
			this.lbTemperature.Name = "lbTemperature";
			this.lbTemperature.Size = new System.Drawing.Size(73, 15);
			this.lbTemperature.TabIndex = 3;
			this.lbTemperature.Text = "Temperature";
			// 
			// lbWeather
			// 
			this.lbWeather.AutoSize = true;
			this.lbWeather.Location = new System.Drawing.Point(77, 125);
			this.lbWeather.Name = "lbWeather";
			this.lbWeather.Size = new System.Drawing.Size(51, 15);
			this.lbWeather.TabIndex = 4;
			this.lbWeather.Text = "Weather";
			// 
			// lbWind
			// 
			this.lbWind.AutoSize = true;
			this.lbWind.Location = new System.Drawing.Point(77, 144);
			this.lbWind.Name = "lbWind";
			this.lbWind.Size = new System.Drawing.Size(35, 15);
			this.lbWind.TabIndex = 5;
			this.lbWind.Text = "Wind";
			// 
			// lbLocalTime
			// 
			this.lbLocalTime.AutoSize = true;
			this.lbLocalTime.Location = new System.Drawing.Point(77, 163);
			this.lbLocalTime.Name = "lbLocalTime";
			this.lbLocalTime.Size = new System.Drawing.Size(64, 15);
			this.lbLocalTime.TabIndex = 6;
			this.lbLocalTime.Text = "Local Time";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(196, 226);
			this.Controls.Add(this.lbLocalTime);
			this.Controls.Add(this.lbWind);
			this.Controls.Add(this.lbWeather);
			this.Controls.Add(this.lbTemperature);
			this.Controls.Add(this.lbHumidity);
			this.Controls.Add(this.lbCity);
			this.Controls.Add(this.comboBoxCities);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxCities;
		private System.Windows.Forms.Label lbCity;
		private System.Windows.Forms.Label lbHumidity;
		private System.Windows.Forms.Label lbTemperature;
		private System.Windows.Forms.Label lbWeather;
		private System.Windows.Forms.Label lbWind;
		private System.Windows.Forms.Label lbLocalTime;
	}
}

