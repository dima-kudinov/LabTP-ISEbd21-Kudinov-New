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
        /// Метод отрисовки парковки
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
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        private void buttonSetLoc_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var loc = new locomotive(100, 1000, dialog.Color, dialog.Color, 0);
                    int place = parking[listBoxLevels.SelectedIndex] + loc;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        private void buttonSetTepl_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {

                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var loc = new Teplovoz(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, 0);
                        int place = parking[listBoxLevels.SelectedIndex] + loc;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }
        /// Обработка нажатия кнопки "Забрать"
        private void buttonTakeLoc_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var car = parking[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
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
        /// Метод обработки выбора элемента на listBoxLevels
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();

        }
    }
}
