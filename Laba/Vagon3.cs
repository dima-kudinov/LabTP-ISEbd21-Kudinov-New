using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    class Vagon3 : IVagon
    {
        public VagonCount count;

        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public int Posx;
        public int Posy;

        public Vagon3(VagonCount vagonCount, Color MainColor, Color DopColor,
            int posX, int posY)
        {
            this.MainColor = MainColor;
            this.DopColor = DopColor;
            count = vagonCount;
            Posx = posX;
            Posy = posY;
        }

        private int CountToInt(VagonCount vagonCount)
        {
            return (int)vagonCount + 1;
        }

        public void DrawVagon(Graphics g)
        {
            for (int i = 0; i < CountToInt(count); i++)
            {
                int shiftX = i * 60;

                Brush b = new SolidBrush(MainColor);
                List<Point> p = new List<Point>(7);
                p.Add(new Point(Posx + 10 - shiftX, Posy + 45));
                p.Add(new Point(Posx + 10 - shiftX, Posy + 50));
                p.Add(new Point(Posx - 50 - shiftX, Posy + 50));
                p.Add(new Point(Posx + 50 - shiftX, Posy + 15));
                p.Add(new Point(Posx + 5 - shiftX, Posy + 15));
                p.Add(new Point(Posx + 5 - shiftX, Posy + 45));
                p.Add(new Point(Posx + 5 - shiftX, Posy + 45));

                g.FillPolygon(b, p.ToArray<Point>());
            }
        }
    }
}
