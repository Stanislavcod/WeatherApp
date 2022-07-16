
namespace WeatherAPIApplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCity = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.labelSunriseN_A = new System.Windows.Forms.Label();
            this.labelSunsetN_A = new System.Windows.Forms.Label();
            this.labelPressureN_A = new System.Windows.Forms.Label();
            this.labelWindSpeedN_A = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labelHumidityH_A = new System.Windows.Forms.Label();
            this.labelTempN_A = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.ForeColor = System.Drawing.Color.Transparent;
            this.labelCity.Location = new System.Drawing.Point(245, 69);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(67, 29);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "City:";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBCity.Location = new System.Drawing.Point(315, 66);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(239, 34);
            this.TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(565, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 43);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.BackColor = System.Drawing.Color.Transparent;
            this.labelCondition.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCondition.ForeColor = System.Drawing.Color.Transparent;
            this.labelCondition.Location = new System.Drawing.Point(166, 237);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(122, 29);
            this.labelCondition.TabIndex = 3;
            this.labelCondition.Text = "Condition";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelDetails.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetails.ForeColor = System.Drawing.Color.Transparent;
            this.labelDetails.Location = new System.Drawing.Point(166, 296);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(89, 29);
            this.labelDetails.TabIndex = 4;
            this.labelDetails.Text = "Details";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labelSunrise.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSunrise.ForeColor = System.Drawing.Color.Transparent;
            this.labelSunrise.Location = new System.Drawing.Point(166, 365);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(103, 29);
            this.labelSunrise.TabIndex = 5;
            this.labelSunrise.Text = "Sunrise:";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.BackColor = System.Drawing.Color.Transparent;
            this.labelSunset.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSunset.ForeColor = System.Drawing.Color.Transparent;
            this.labelSunset.Location = new System.Drawing.Point(166, 431);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(96, 29);
            this.labelSunset.TabIndex = 6;
            this.labelSunset.Text = "Sunset:";
            // 
            // labelSunriseN_A
            // 
            this.labelSunriseN_A.AutoSize = true;
            this.labelSunriseN_A.BackColor = System.Drawing.Color.Transparent;
            this.labelSunriseN_A.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSunriseN_A.ForeColor = System.Drawing.Color.Transparent;
            this.labelSunriseN_A.Location = new System.Drawing.Point(269, 365);
            this.labelSunriseN_A.Name = "labelSunriseN_A";
            this.labelSunriseN_A.Size = new System.Drawing.Size(53, 29);
            this.labelSunriseN_A.TabIndex = 7;
            this.labelSunriseN_A.Text = "N/A";
            // 
            // labelSunsetN_A
            // 
            this.labelSunsetN_A.AutoSize = true;
            this.labelSunsetN_A.BackColor = System.Drawing.Color.Transparent;
            this.labelSunsetN_A.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSunsetN_A.ForeColor = System.Drawing.Color.Transparent;
            this.labelSunsetN_A.Location = new System.Drawing.Point(269, 431);
            this.labelSunsetN_A.Name = "labelSunsetN_A";
            this.labelSunsetN_A.Size = new System.Drawing.Size(53, 29);
            this.labelSunsetN_A.TabIndex = 8;
            this.labelSunsetN_A.Text = "N/A";
            // 
            // labelPressureN_A
            // 
            this.labelPressureN_A.AutoSize = true;
            this.labelPressureN_A.BackColor = System.Drawing.Color.Transparent;
            this.labelPressureN_A.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPressureN_A.ForeColor = System.Drawing.Color.Transparent;
            this.labelPressureN_A.Location = new System.Drawing.Point(730, 296);
            this.labelPressureN_A.Name = "labelPressureN_A";
            this.labelPressureN_A.Size = new System.Drawing.Size(53, 29);
            this.labelPressureN_A.TabIndex = 12;
            this.labelPressureN_A.Text = "N/A";
            // 
            // labelWindSpeedN_A
            // 
            this.labelWindSpeedN_A.AutoSize = true;
            this.labelWindSpeedN_A.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeedN_A.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindSpeedN_A.ForeColor = System.Drawing.Color.Transparent;
            this.labelWindSpeedN_A.Location = new System.Drawing.Point(730, 237);
            this.labelWindSpeedN_A.Name = "labelWindSpeedN_A";
            this.labelWindSpeedN_A.Size = new System.Drawing.Size(53, 29);
            this.labelWindSpeedN_A.TabIndex = 11;
            this.labelWindSpeedN_A.Text = "N/A";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.BackColor = System.Drawing.Color.Transparent;
            this.labelPressure.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPressure.ForeColor = System.Drawing.Color.Transparent;
            this.labelPressure.Location = new System.Drawing.Point(581, 296);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(118, 29);
            this.labelPressure.TabIndex = 10;
            this.labelPressure.Text = "Pressure:";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeed.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWindSpeed.ForeColor = System.Drawing.Color.Transparent;
            this.labelWindSpeed.Location = new System.Drawing.Point(581, 237);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(154, 29);
            this.labelWindSpeed.TabIndex = 9;
            this.labelWindSpeed.Text = "Wind Speed:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(171, 161);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(136, 73);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // labelHumidityH_A
            // 
            this.labelHumidityH_A.AutoSize = true;
            this.labelHumidityH_A.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidityH_A.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHumidityH_A.ForeColor = System.Drawing.Color.Transparent;
            this.labelHumidityH_A.Location = new System.Drawing.Point(730, 431);
            this.labelHumidityH_A.Name = "labelHumidityH_A";
            this.labelHumidityH_A.Size = new System.Drawing.Size(53, 29);
            this.labelHumidityH_A.TabIndex = 17;
            this.labelHumidityH_A.Text = "N/A";
            // 
            // labelTempN_A
            // 
            this.labelTempN_A.AutoSize = true;
            this.labelTempN_A.BackColor = System.Drawing.Color.Transparent;
            this.labelTempN_A.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTempN_A.ForeColor = System.Drawing.Color.Transparent;
            this.labelTempN_A.Location = new System.Drawing.Point(730, 363);
            this.labelTempN_A.Name = "labelTempN_A";
            this.labelTempN_A.Size = new System.Drawing.Size(53, 29);
            this.labelTempN_A.TabIndex = 16;
            this.labelTempN_A.Text = "N/A";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidity.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHumidity.ForeColor = System.Drawing.Color.Transparent;
            this.labelHumidity.Location = new System.Drawing.Point(581, 431);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(124, 29);
            this.labelHumidity.TabIndex = 15;
            this.labelHumidity.Text = "Humidity:";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.ForeColor = System.Drawing.Color.Transparent;
            this.labelTemp.Location = new System.Drawing.Point(581, 363);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(83, 29);
            this.labelTemp.TabIndex = 14;
            this.labelTemp.Text = "Temp:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WeatherAPIApplication.Properties.Resources._1625697505_8_kartinkin_com_p_groza_oboi_krasivie_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.labelHumidityH_A);
            this.Controls.Add(this.labelTempN_A);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labelPressureN_A);
            this.Controls.Add(this.labelWindSpeedN_A);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelSunsetN_A);
            this.Controls.Add(this.labelSunriseN_A);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.labelCity);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Label labelSunriseN_A;
        private System.Windows.Forms.Label labelSunsetN_A;
        private System.Windows.Forms.Label labelPressureN_A;
        private System.Windows.Forms.Label labelWindSpeedN_A;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labelHumidityH_A;
        private System.Windows.Forms.Label labelTempN_A;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelTemp;
    }
}

