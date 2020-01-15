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

        Parking<ITransport,IVagon> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport,IVagon>(20, pictureBoxParking.Width,
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
                var locomotive = new locomotive(100, 1000, dialog.Color, Color.Red,0);
                int place = parking + locomotive;
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
                    var locomotive = new Teplovoz(100, 1000, dialog.Color, dialogDop.Color,
                   true, true,0);
                    int place = parking + locomotive;
                    Draw();
                }
            }
        }

        private void buttonTakeLoc_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var locomotive = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (locomotive != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeLoc.Width,
                   pictureBoxTakeLoc.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    locomotive.SetPosition(5, 5, pictureBoxTakeLoc.Width,
                   pictureBoxTakeLoc.Height);
                    locomotive.DrawLoc(gr);
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
