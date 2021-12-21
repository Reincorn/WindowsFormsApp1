
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
            this.MovingX = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MovingY = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingY)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(-1, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(914, 438);
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
            // MovingX
            // 
            this.MovingX.Location = new System.Drawing.Point(919, 28);
            this.MovingX.Maximum = 230;
            this.MovingX.Minimum = 60;
            this.MovingX.Name = "MovingX";
            this.MovingX.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MovingX.Size = new System.Drawing.Size(45, 80);
            this.MovingX.TabIndex = 1;
            this.MovingX.Value = 60;
            this.MovingX.Scroll += new System.EventHandler(this.MovingX_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Круг 1";
            // 
            // MovingY
            // 
            this.MovingY.Location = new System.Drawing.Point(970, 28);
            this.MovingY.Maximum = 300;
            this.MovingY.Minimum = 60;
            this.MovingY.Name = "MovingY";
            this.MovingY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MovingY.Size = new System.Drawing.Size(45, 80);
            this.MovingY.TabIndex = 3;
            this.MovingY.Value = 60;
            this.MovingY.Scroll += new System.EventHandler(this.MovingY_Scroll);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1021, 462);
            this.Controls.Add(this.MovingY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovingX);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovingY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar MovingX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar MovingY;
    }
}

