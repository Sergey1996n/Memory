using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public class Picture : PictureBox
    {

        public string pictureName;
        public string activatePictureName;


        public Picture(int i, int kol_picture)
        {
            Height = 80;
            Width = 80;
            Location = new Point(Height * (i % kol_picture), Width * (i / kol_picture) + 24);
            Name = "pictureBox" + (i + 1);
            Size = new Size(Height, Width);
            SizeMode = PictureBoxSizeMode.StretchImage;
            Click += new EventHandler(Pic_Click);
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            
            if (Form1.kol_step == 0 && Enabled)
            {
                VstavkaPicture();
                Form1.kol_step++;
                Enabled = false;
                Form1.onePicture = this;
            }
            else if (Form1.kol_step == 1 && Enabled)
            {
                VstavkaPicture();
                Form1.kol_step--;
                Form1.twoPicture = this;
                ProverkaIdentical();
            }
        }

        public void NewGameObject()
        {
            Enabled = true;
            Load(Application.StartupPath + "\\Pictures\\fon.bmp");
            activatePictureName = "fon";
        }

        private void ProverkaIdentical()
        {
            if (Form1.onePicture.pictureName == Form1.twoPicture.pictureName)
            {
                Form1.onePicture.Visible = false;
                Form1.twoPicture.Visible = false;
                Form1.KolOpenPicture += 2;
                Proverka();
            }
            else
            {
                for (int i = 0; i < Form1.kolelement; i++)
                {
                    if (Form1.pictures[i].Visible)
                        Form1.pictures[i].Enabled = false;
                }
                Form1.timer1.Start();
            }
        }

        private void Proverka()
        {
            if (Form1.KolOpenPicture == Form1.kolelement)
            {
                Form1.publicTimer.Stop();
                MessageBox.Show("Ваше время: " + Form1.sec / 60 + " минут и " + Form1.sec % 60 + " секунд", "Поздравляю!!! Вы победили!!!");
                //NewGame();
            }
        }

        public void VstavkaPicture()
        {
            Load(Application.StartupPath + "\\Pictures\\" + pictureName + ".bmp");
            activatePictureName= pictureName;
        }

        public void VstavkaFon()
        {
            Load(Application.StartupPath + "\\Pictures\\fon.bmp");
            activatePictureName = "fon";
        }
    }
}
