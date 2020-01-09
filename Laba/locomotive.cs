﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public class locomotive : Train
    {

        protected const int locWidth = 150;
        protected const int locHeight = 80;
        
        public Color DopColor { protected set; get; }


        public locomotive(int maxSpeed, float weight, Color mainColor, Color dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
        }
        public locomotive(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
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
                    if (Posx - step > 0 + 200)

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

        public override void DrawLoc(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

           
            
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
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

    }
}
