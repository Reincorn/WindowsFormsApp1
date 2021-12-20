using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;

        // абстрактный метод с помощью которого изменяутся состояние частиц
        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                new SolidBrush(Color.Red),
                X - 5,
                Y - 5,
                10,
                10
            );
        }
    }

    public class GravityPoint : IImpactPoint//круг притяжения
    {
        public int Power = 100;// сила притяжения
        public Color PointColor = Color.White;
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < Power / 2)
            {
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }
        public override void Render(Graphics g)
        {
            //рисуем окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
            );
        }
    }

    public class AntiGravityPoint : IImpactPoint //круг отталкивания
    {
        public int Power = 100;// сила притяжения
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2;
            particle.SpeedY -= gY * Power / r2;
        }
    }

    public class PainterPoint : IImpactPoint
    {
        public Color PointColor = Color.White;
        public float Rad = 15;

        public override void ImpactParticle(Particle particle)
        {
            //Проверка попадания частицы в радиус круга
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r - particle.Radius < Rad)
            {
                particle.Color1 = PointColor;
                particle.Color0 = Color.FromArgb(0, PointColor);
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(new SolidBrush(PointColor), 2), X - Rad, Y - Rad, Rad * 2, Rad * 2);
        }
    }
}
