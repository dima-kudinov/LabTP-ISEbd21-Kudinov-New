﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    public abstract class Train: ITransport
    {
        protected int Posx;
        protected int Posy;
        protected int pctrWidth;
        protected int pctrHeight;

        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            Posx = x;
            Posy = y;
            pctrWidth = width;
            pctrHeight = height;
        }

        public void SetMainColor(Color color)
        {
            MainColor = color;
        }

        public abstract void MoveTransport(Direction direction);
        public abstract void DrawLoc(Graphics g);
    }
}
