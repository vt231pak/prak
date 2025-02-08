namespace WeaterConsole
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            temperature = new Label();
            wind = new Label();
            windDirection = new Label();
            humidity = new Label();
            waterTemperature = new Label();
            status = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(103, 401);
            button1.Name = "button1";
            button1.Size = new Size(153, 37);
            button1.TabIndex = 0;
            button1.Text = "Оновити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(309, 45);
            label1.TabIndex = 1;
            label1.Text = "Погода в Житомирі";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 150);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 2;
            label2.Text = "Температура";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 200);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 3;
            label3.Text = "Вітер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 241);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 4;
            label4.Text = "Напрям вітру";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(90, 291);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 5;
            label5.Text = "Вологість";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 337);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 6;
            label6.Text = "Температура води";
            // 
            // temperature
            // 
            temperature.AutoSize = true;
            temperature.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            temperature.Location = new Point(218, 150);
            temperature.Name = "temperature";
            temperature.Size = new Size(0, 25);
            temperature.TabIndex = 7;
            // 
            // wind
            // 
            wind.AutoSize = true;
            wind.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            wind.Location = new Point(218, 200);
            wind.Name = "wind";
            wind.Size = new Size(0, 25);
            wind.TabIndex = 8;
            // 
            // windDirection
            // 
            windDirection.AutoSize = true;
            windDirection.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            windDirection.Location = new Point(218, 241);
            windDirection.Name = "windDirection";
            windDirection.Size = new Size(0, 25);
            windDirection.TabIndex = 9;
            // 
            // humidity
            // 
            humidity.AutoSize = true;
            humidity.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            humidity.Location = new Point(212, 291);
            humidity.Name = "humidity";
            humidity.Size = new Size(0, 25);
            humidity.TabIndex = 10;
            // 
            // waterTemperature
            // 
            waterTemperature.AutoSize = true;
            waterTemperature.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            waterTemperature.Location = new Point(212, 337);
            waterTemperature.Name = "waterTemperature";
            waterTemperature.Size = new Size(0, 25);
            waterTemperature.TabIndex = 11;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(212, 98);
            status.Name = "status";
            status.Size = new Size(0, 23);
            status.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(95, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 68);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(374, 450);
            Controls.Add(pictureBox1);
            Controls.Add(status);
            Controls.Add(waterTemperature);
            Controls.Add(humidity);
            Controls.Add(windDirection);
            Controls.Add(wind);
            Controls.Add(temperature);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Погода в Житомирі";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label temperature;
        private Label wind;
        private Label windDirection;
        private Label humidity;
        private Label waterTemperature;
        private Label status;
        private PictureBox pictureBox1;
    }
}