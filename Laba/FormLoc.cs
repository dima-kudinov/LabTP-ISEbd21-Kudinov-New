
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba
{
    public partial class FormLoc : Form
    {
        private ITransport loc;

        public FormLoc()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLoc.Width, pictureBoxLoc.Height);
            Graphics gr = Graphics.FromImage(bmp);
            
            loc.DrawLoc(gr);
            pictureBoxLoc.Image = bmp;
        }
        
        private void buttonCreateLoc_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            loc = new locomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green,
           Color.Red);

            loc.SetPosition(rnd.Next(500, 600), rnd.Next(10, 100), pictureBoxLoc.Width,
           pictureBoxLoc.Height);
            
            Draw();
        }

        private void buttonCreateTepl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            loc = new Teplovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green,
           Color.Red, true, true);

            loc.SetPosition(rnd.Next(500, 600), rnd.Next(10, 100), pictureBoxLoc.Width,
           pictureBoxLoc.Height);

            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    loc.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    loc.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    loc.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    loc.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }  
    }
}

