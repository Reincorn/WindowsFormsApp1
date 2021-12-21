using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        GravityPoint point;//первая точка
        GravityPoint point1;//первая точка
        public PainterPoint paint1;
        public PainterPoint paint2;
        public PainterPoint paint3;
        public PainterPoint paint4;
        Particle part = new Particle();
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);//Привязка изображения

            emitter = new TopEmitter

            {
                Width = picDisplay.Width,
                GravitationY = 0.2f,
                ParticlesPerTick = 2,
            };
            emitters.Add(this.emitter);

            paint1 = new PainterPoint
            {
                PointColor = Color.Orange,
                X = (picDisplay.Width / 2) - 300,
                Y = (picDisplay.Height / 2) - 10,
                Rad = 50,
            };

            paint2 = new PainterPoint
            {
                PointColor = Color.Yellow,
                X = (picDisplay.Width / 2) - 120,
                Y = (picDisplay.Height / 2) + 50,
                Rad = 50,
            };

            paint3 = new PainterPoint
            {
                PointColor = Color.Cyan,
                X = (picDisplay.Width / 2) + 60,
                Y = (picDisplay.Height / 2) + 50,
                Rad = 50,
            };

            paint4 = new PainterPoint
            {
                PointColor = Color.Blue,
                X = (picDisplay.Width / 2) + 300,
                Y = (picDisplay.Height / 2) - 10,
                Rad = 50,
            };

            point1 = new GravityPoint
            {
                PointColor = Color.White,
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2
            };
            emitter.impactPoints.Add(paint1);
            emitter.impactPoints.Add(paint2);
            emitter.impactPoints.Add(paint3);
            emitter.impactPoints.Add(paint4);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.UpdateState();//обновление эмиттера
                using (var g = Graphics.FromImage(picDisplay.Image))
                {
                    g.Clear(Color.Black);//Очистка экрана, заливка формы в чёрный цвет
                    emitter.Render(g); //Рендеринг системы через эмиттер
                }
            }
            picDisplay.Invalidate();//обновление формы
        }

        //Фиксация положения мыши
        

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        { 
                //положение мыши в переменные для хранения положения мыши
                foreach (var emitter in emitters)
                {
                    emitter.MousePositionX = e.X;
                    emitter.MousePositionY = e.Y;

                    point1.X = e.X;
                    point1.Y = e.Y;
                }
        }

        private void MovingX_Scroll(object sender, EventArgs e)
        {
            paint1.X = MovingX.Value;
        }

        private void MovingY_Scroll(object sender, EventArgs e)
        {
            paint1.Y = MovingY.Value;
        }
    }
}