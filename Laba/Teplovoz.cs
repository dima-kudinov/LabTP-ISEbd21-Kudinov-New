using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class Teplovoz : locomotive
    {
        public bool Tube { protected set; get; }
        public bool Line { protected set; get; }



        public Teplovoz(int maxSpeed, float weight, Color mainColor,
            Color dopColor, bool tube, bool line,VagonCount count) 
            : base(maxSpeed, weight, mainColor, dopColor, count)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Line = line;
            Tube = tube;
            Count = count;
        }

        public override void DrawLoc(Graphics g)
        {
            base.DrawLoc(g);
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
        }

        
    }
}
