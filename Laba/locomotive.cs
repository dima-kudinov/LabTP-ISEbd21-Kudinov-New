using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    class locomotive
    {
        private int Posx;
        private int Posy;

        private int pctrWidth;
        private int pctrHeight;

        private const int locWidth = 150;
        private const int locHeight = 80;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }

        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }

        public VagonCount Count { private set; get; }

        public bool Tube { private set; get; }
        public bool Line { private set; get; }

        public locomotive(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool tube, bool line, VagonCount count)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Line = line;
            Tube = tube;
            Count = count;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            Posx = x;
            Posy = y;
            pctrWidth = width;
            pctrHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step1 = MaxSpeed * 100 / Weight;
            int step = Convert.ToInt32(step1);
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (Posx + step < pctrWidth - locWidth)
                    {
                        Posx += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (Posx - step > 0)

                    {
                        Posx -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (Posy - step > 0)
                    {
                        Posy -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (Posy + step < pctrHeight - locHeight)
                    {
                        Posy += step;
                    }
                    break;
            }
        }

        public void DrawLoc(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            if (Tube)
            {
                Brush n = new SolidBrush(MainColor);
                List<Point> l = new List<Point>(4);
                l.Add(new Point(Posx + 85, Posy + 35));
                l.Add(new Point(Posx + 85, Posy + 20));
                l.Add(new Point(Posx + 90, Posy + 20));
                l.Add(new Point(Posx + 90, Posy + 35));
                
                g.FillPolygon(n, l.ToArray<Point>());
            }
            
            Brush b = new SolidBrush(MainColor);
            List<Point> p = new List<Point>(11);
            p.Add(new Point(Posx + 10, Posy + 15));
            p.Add(new Point(Posx + 10, Posy + 50));
            p.Add(new Point(Posx + 80, Posy + 50));
            p.Add(new Point(Posx + 90, Posy + 40));
            p.Add(new Point(Posx + 90, Posy + 35));
            p.Add(new Point(Posx + 75, Posy + 35));
            p.Add(new Point(Posx + 75, Posy + 15));

            g.FillPolygon(b, p.ToArray<Point>());

            if (Line)
            {
                Brush m = new SolidBrush(DopColor);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 10, Posy + 40));
                tp.Add(new Point(Posx + 10, Posy + 35));
                tp.Add(new Point(Posx + 90, Posy + 35));
                tp.Add(new Point(Posx + 90, Posy + 40));

                g.FillPolygon(m, tp.ToArray<Point>());
            }
            Vagon vagon = new Vagon(Count,
               MainColor, DopColor, Posx, Posy);
            vagon.DrawVagon(g);
        }
    }
}
