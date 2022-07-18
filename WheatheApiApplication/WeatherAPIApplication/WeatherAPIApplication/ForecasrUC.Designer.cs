
namespace WeatherAPIApplication
{
    partial class ForecasrUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDT = new System.Windows.Forms.Label();
            this.pictWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labelMainWeather = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDT.Location = new System.Drawing.Point(136, 3);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(93, 29);
            this.labelDT.TabIndex = 1;
            this.labelDT.Text = "Sunday";
            // 
            // pictWeatherIcon
            // 
            this.pictWeatherIcon.Location = new System.Drawing.Point(3, 3);
            this.pictWeatherIcon.Name = "pictWeatherIcon";
            this.pictWeatherIcon.Size = new System.Drawing.Size(128, 112);
            this.pictWeatherIcon.TabIndex = 0;
            this.pictWeatherIcon.TabStop = false;
            // 
            // labelMainWeather
            // 
            this.labelMainWeather.AutoSize = true;
            this.labelMainWeather.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainWeather.Location = new System.Drawing.Point(137, 45);
            this.labelMainWeather.Name = "labelMainWeather";
            this.labelMainWeather.Size = new System.Drawing.Size(72, 29);
            this.labelMainWeather.TabIndex = 2;
            this.labelMainWeather.Text = "Clear";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labWeatherDescription.Location = new System.Drawing.Point(136, 86);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(140, 29);
            this.labWeatherDescription.TabIndex = 3;
            this.labWeatherDescription.Text = "Description";
            // 
            // ForecasrUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labelMainWeather);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.pictWeatherIcon);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ForecasrUC";
            this.Size = new System.Drawing.Size(483, 126);
            ((System.ComponentModel.ISupportInitialize)(this.pictWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictWeatherIcon;
        public System.Windows.Forms.Label labelDT;
        public System.Windows.Forms.Label labelMainWeather;
        public System.Windows.Forms.Label labWeatherDescription;
    }
}
