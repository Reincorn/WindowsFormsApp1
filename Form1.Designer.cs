
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MovingY = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MovingX = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Radius = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(-1, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1022, 352);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MovingY
            // 
            this.MovingY.BackColor = System.Drawing.Color.OrangeRed;
            this.MovingY.Location = new System.Drawing.Point(63, 370);
            this.MovingY.Maximum = 300;
            this.MovingY.Minimum = 60;
            this.MovingY.Name = "MovingY";
            this.MovingY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MovingY.Size = new System.Drawing.Size(45, 80);
            this.MovingY.TabIndex = 6;
            this.MovingY.Value = 60;
            this.MovingY.Scroll += new System.EventHandler(this.MovingY_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "К\r\nр\r\nу\r\nг \r\n1";
            // 
            // MovingX
            // 
            this.MovingX.BackColor = System.Drawing.Color.OrangeRed;
            this.MovingX.Location = new System.Drawing.Point(12, 370);
            this.MovingX.Maximum = 230;
            this.MovingX.Minimum = 60;
            this.MovingX.Name = "MovingX";
            this.MovingX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MovingX.Size = new System.Drawing.Size(45, 80);
            this.MovingX.TabIndex = 4;
            this.MovingX.Value = 60;
            this.MovingX.Scroll += new System.EventHandler(this.MovingX_Scroll);
            // 
            // Radius
            // 
            this.Radius.BackColor = System.Drawing.Color.OrangeRed;
            this.Radius.Location = new System.Drawing.Point(114, 370);
            this.Radius.Maximum = 50;
            this.Radius.Name = "Radius";
            this.Radius.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Radius.Size = new System.Drawing.Size(45, 80);
            this.Radius.TabIndex = 7;
            this.Radius.Value = 50;
            this.Radius.Scroll += new System.EventHandler(this.Radius_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Gold;
            this.trackBar1.Location = new System.Drawing.Point(255, 370);
            this.trackBar1.Maximum = 450;
            this.trackBar1.Minimum = 340;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 80);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 400;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.Gold;
            this.trackBar2.Location = new System.Drawing.Point(306, 370);
            this.trackBar2.Maximum = 230;
            this.trackBar2.Minimum = 60;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 80);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Value = 60;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.Color.Gold;
            this.trackBar3.Location = new System.Drawing.Point(357, 370);
            this.trackBar3.Maximum = 50;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 80);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.Value = 50;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(408, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 85);
            this.label2.TabIndex = 11;
            this.label2.Text = "К\r\nр\r\nу\r\nг \r\n2";
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.Color.Cyan;
            this.trackBar4.Location = new System.Drawing.Point(500, 370);
            this.trackBar4.Maximum = 640;
            this.trackBar4.Minimum = 530;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 80);
            this.trackBar4.TabIndex = 12;
            this.trackBar4.Value = 600;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.Color.Cyan;
            this.trackBar5.Location = new System.Drawing.Point(551, 370);
            this.trackBar5.Maximum = 230;
            this.trackBar5.Minimum = 60;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(45, 80);
            this.trackBar5.TabIndex = 13;
            this.trackBar5.Value = 60;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.BackColor = System.Drawing.Color.Cyan;
            this.trackBar6.Location = new System.Drawing.Point(602, 370);
            this.trackBar6.Maximum = 50;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar6.Size = new System.Drawing.Size(45, 80);
            this.trackBar6.TabIndex = 14;
            this.trackBar6.Value = 50;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(653, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 85);
            this.label3.TabIndex = 15;
            this.label3.Text = "К\r\nр\r\nу\r\nг \r\n3\r\n";
            // 
            // trackBar7
            // 
            this.trackBar7.BackColor = System.Drawing.Color.Blue;
            this.trackBar7.Location = new System.Drawing.Point(752, 370);
            this.trackBar7.Maximum = 950;
            this.trackBar7.Minimum = 780;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar7.Size = new System.Drawing.Size(45, 80);
            this.trackBar7.TabIndex = 16;
            this.trackBar7.Value = 810;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // trackBar8
            // 
            this.trackBar8.BackColor = System.Drawing.Color.Blue;
            this.trackBar8.Location = new System.Drawing.Point(803, 370);
            this.trackBar8.Maximum = 230;
            this.trackBar8.Minimum = 60;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar8.Size = new System.Drawing.Size(45, 80);
            this.trackBar8.TabIndex = 17;
            this.trackBar8.Value = 60;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // trackBar9
            // 
            this.trackBar9.BackColor = System.Drawing.Color.Blue;
            this.trackBar9.Location = new System.Drawing.Point(854, 370);
            this.trackBar9.Maximum = 50;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar9.Size = new System.Drawing.Size(45, 80);
            this.trackBar9.TabIndex = 18;
            this.trackBar9.Value = 50;
            this.trackBar9.Scroll += new System.EventHandler(this.trackBar9_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(905, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 85);
            this.label4.TabIndex = 19;
            this.label4.Text = "К\r\nр\r\nу\r\nг \r\n4";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1021, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar9);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.MovingY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovingX);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar MovingY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar MovingX;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar Radius;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.Label label4;
    }
}

