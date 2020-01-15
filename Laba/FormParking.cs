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
        /// Объект от класса многоуровневой парковки
        MultiLevelParking parking;
        /// Количество уровней-парковок      
        FormLocConfig form;
        private const int countLevel = 5;
        public FormParking()

        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
           pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }

        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
               pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonTakeLoc_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    var locomotive = parking[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (locomotive != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeLoc.Width,
                       pictureBoxTakeLoc.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        locomotive.SetPosition(5, 5, pictureBoxTakeLoc.Width, pictureBoxTakeLoc.Height);

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

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetLoc_Click(object sender, EventArgs e)
        {
            form = new FormLocConfig();
            form.AddEvent(AddLoc);
            form.Show();
        }

        private void AddLoc(ITransport locomotive)
        {
            if (locomotive != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + locomotive;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Локомотив не удалось поставить");
                }
            }
        }
    }
}