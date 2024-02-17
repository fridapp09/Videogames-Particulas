using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Clase6_Particles
{
    public class Ball
    {
        static Size space;
        public float Radius, diameter, vx, vy;
        public float X, Y;
        public int index;
        public Color c;
        public bool changed;

        public Ball(Random rand, Size size, int index)
        {
            X = rand.Next(0, size.Width);
            Y = rand.Next(0, size.Height);

            vx = rand.Next(40, 80);
            vy = rand.Next(40, 80);
            diameter = rand.Next(35, 60);
            space = size;
            this.index = index;
            changed = false;
            Radius = diameter / 2;
            c = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
        }

        private void ResolveWalls()
        {
            if (X - Radius < 0 || X + Radius > space.Width)
            {
                vx = -vx;
                X = Math.Clamp(X, Radius, space.Width - Radius);
            }

            if (Y - Radius < 0 || Y + Radius > space.Height)
            {
                vy = -vy;
                Y = Math.Clamp(Y, Radius, space.Height - Radius);
            }
        }

        public void Update(List<Ball> balls, float deltaTime)
        {
            float val = .96f;
            X += (vx * deltaTime);
            Y += (vy * deltaTime);
            for (int b = index + 1; b < balls.Count; b++)
            {
                if (Collision(balls[b]))
                {
                    Resolve(balls[b]);
                }
            }
            ResolveWalls();
            vx *= val;
            vy *= val;
        }

        public bool Collision(Ball ball)
        {
            float minDistance = Radius + ball.Radius;
            float dx = X - ball.X;
            float dy = Y - ball.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);
            return distance < minDistance;
        }

        private float Distance(Ball ball)
        {
            float dx = X - ball.X;
            float dy = Y - ball.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        private void Resolve(Ball other)
        {
            float dx = other.X - X;
            float dy = other.Y - Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);
            float nx = dx / distance;
            float ny = dy / distance;

            float overlap = 0.5f * (Radius + other.Radius - distance);
            X -= overlap * nx;
            Y -= overlap * ny;
            other.X += overlap * nx;
            other.Y += overlap * ny;

            float dvx = other.vx - vx;
            float dvy = other.vy - vy;
            float dvdotn = dvx * nx + dvy * ny;

            if (dvdotn > 0)
                return;

            float j = -(1 + 1) * dvdotn / (1 / 1 + 1 / 1);

            vx -= (j / 1) * nx;
            vy -= (j / 1) * ny;
            other.vx += (j / 1) * nx;
            other.vy += (j / 1) * ny;
        }
    }
}