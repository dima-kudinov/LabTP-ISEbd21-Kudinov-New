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
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetLoc_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new locomotive(100, 1000, dialog.Color, Color.Red);
                int place = parking + car;
                Draw();
            }
        }

        private void buttonSetTepl_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new Teplovoz(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    int place = parking + car;
                    Draw();
                }
            }
        }

        private void buttonTakeLoc_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeLoc.Width,
                   pictureBoxTakeLoc.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5, pictureBoxTakeLoc.Width,
                   pictureBoxTakeLoc.Height);
                    car.DrawLoc(gr);
                    pictureBoxTakeLoc.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeLoc.Width,
                   pictureBoxTakeLoc.Height);
                    pictureBoxTakeLoc.Image = bmp;
                }
                Draw();
            }
        }
    }
}
