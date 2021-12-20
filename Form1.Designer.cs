
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
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.tbRazbros = new System.Windows.Forms.TrackBar();
            this.tbGraviton = new System.Windows.Forms.TrackBar();
            this.tbGraviton1 = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblRazbros = new System.Windows.Forms.Label();
            this.lblKryg = new System.Windows.Forms.Label();
            this.lblKryg1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRazbros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(997, 304);
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
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(12, 322);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(104, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll_1);
            // 
            // tbRazbros
            // 
            this.tbRazbros.Location = new System.Drawing.Point(161, 322);
            this.tbRazbros.Maximum = 359;
            this.tbRazbros.Name = "tbRazbros";
            this.tbRazbros.Size = new System.Drawing.Size(104, 45);
            this.tbRazbros.TabIndex = 2;
            this.tbRazbros.Scroll += new System.EventHandler(this.tbRazbros_Scroll_1);
            // 
            // tbGraviton
            // 
            this.tbGraviton.Location = new System.Drawing.Point(319, 322);
            this.tbGraviton.Maximum = 100;
            this.tbGraviton.Name = "tbGraviton";
            this.tbGraviton.Size = new System.Drawing.Size(104, 45);
            this.tbGraviton.TabIndex = 3;
            this.tbGraviton.Scroll += new System.EventHandler(this.tbGraviton_Scroll_1);
            // 
            // tbGraviton1
            // 
            this.tbGraviton1.Location = new System.Drawing.Point(473, 322);
            this.tbGraviton1.Maximum = 100;
            this.tbGraviton1.Name = "tbGraviton1";
            this.tbGraviton1.Size = new System.Drawing.Size(104, 45);
            this.tbGraviton1.TabIndex = 4;
            this.tbGraviton1.Scroll += new System.EventHandler(this.tbGraviton1_Scroll_1);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(51, 370);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 13);
            this.lblDirection.TabIndex = 5;
            // 
            // lblRazbros
            // 
            this.lblRazbros.AutoSize = true;
            this.lblRazbros.Location = new System.Drawing.Point(206, 370);
            this.lblRazbros.Name = "lblRazbros";
            this.lblRazbros.Size = new System.Drawing.Size(0, 13);
            this.lblRazbros.TabIndex = 6;
            // 
            // lblKryg
            // 
            this.lblKryg.AutoSize = true;
            this.lblKryg.Location = new System.Drawing.Point(371, 370);
            this.lblKryg.Name = "lblKryg";
            this.lblKryg.Size = new System.Drawing.Size(0, 13);
            this.lblKryg.TabIndex = 7;
            // 
            // lblKryg1
            // 
            this.lblKryg1.AutoSize = true;
            this.lblKryg1.Location = new System.Drawing.Point(522, 370);
            this.lblKryg1.Name = "lblKryg1";
            this.lblKryg1.Size = new System.Drawing.Size(0, 13);
            this.lblKryg1.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1021, 462);
            this.Controls.Add(this.lblKryg1);
            this.Controls.Add(this.lblKryg);
            this.Controls.Add(this.lblRazbros);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbGraviton1);
            this.Controls.Add(this.tbGraviton);
            this.Controls.Add(this.tbRazbros);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRazbros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.TrackBar tbRazbros;
        private System.Windows.Forms.TrackBar tbGraviton;
        private System.Windows.Forms.TrackBar tbGraviton1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblRazbros;
        private System.Windows.Forms.Label lblKryg;
        private System.Windows.Forms.Label lblKryg1;
    }
}

