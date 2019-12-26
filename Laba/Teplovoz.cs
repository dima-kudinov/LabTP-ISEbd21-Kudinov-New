using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class Teplovoz : locomotive, IComparable<Teplovoz>, IEquatable<Teplovoz>
    {
        public bool Tube { protected set; get; }
        public bool Line { protected set; get; }



        public Teplovoz(int maxSpeed, float weight, Color mainColor,
            Color dopColor, bool tube, bool line, Vagon.VagonCount count) 
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
        public Teplovoz(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Line = Convert.ToBoolean(strs[4]);
                Tube = Convert.ToBoolean(strs[5]);
               
            }
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
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Line + ";" +
           Tube;
        }

        public int CompareTo(Teplovoz other)
        {
            var res = (this is locomotive).CompareTo(other is locomotive);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Line != other.Line)
            {
                return Line.CompareTo(other.Line);
            }
            if (Tube != other.Tube)
            {
                return Tube.CompareTo(other.Tube);
            }
          
            return 0;
        }
 
        public bool Equals(Teplovoz other)
        {
            var res = (this as locomotive).Equals(other as locomotive);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Line != other.Line)
            {
                return false;
            }
          
        if (Tube != other.Tube)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Teplovoz locObj))
            {
                return false;
            }
            else
            {
                return Equals(locObj);
            }
        }
  
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
