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
    public partial class FormLocConfig : Form
    {
        ITransport locomotive = null;

        private event locDelegate eventAddLoc;
        public FormLocConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawLoc()
        {
            if (locomotive != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxLoc.Width, pictureBoxLoc.Height);
                Graphics gr = Graphics.FromImage(bmp);
                locomotive.SetPosition(5, 5, pictureBoxLoc.Width, pictureBoxLoc.Height);
                locomotive.DrawLoc(gr);
                pictureBoxLoc.Image = bmp;
            }
        }

        public void AddEvent(locDelegate ev)
        {
            if (eventAddLoc == null)
            {
                eventAddLoc = new locDelegate(ev);
            }
            else
            {
                eventAddLoc += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelLoc_MouseDown(object sender, MouseEventArgs e)
        {
            labelLoc.DoDragDrop(labelLoc.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
            
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTepl_MouseDown(object sender, MouseEventArgs e)
        {
            labelTepl.DoDragDrop(labelTepl.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelLoc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelLoc_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Локомотив":
                    locomotive = new locomotive(100, 500, Color.White, Color.White,0);
                    break;
                case "Тепловоз":
                    locomotive = new Teplovoz(100, 500, Color.White, Color.Black, true, true,
                   0);
                    break;
            }
            DrawLoc();
        }

        


 /// <summary>

 /// Отправляем цвет с панели
 /// </summary>
 /// <param name="sender"></param>
 /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (locomotive != null)
            {
                locomotive.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawLoc();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (locomotive != null)
            {
                if (locomotive is Teplovoz)
                {
                    (locomotive as
                   Teplovoz).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawLoc();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddLoc?.Invoke(locomotive);
            Close();

        }
    }
}
