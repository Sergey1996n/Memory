using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        public static int kolelement = 16;
        public static int kol_picture = 4;
        public static int kol_step = 0;
        public static int KolOpenPicture;
        public static Picture onePicture;
        public static Picture twoPicture;
        public static int sec;

        public static string[] picture_Name = new string[] { "бараш", "ёжик", "крош", "нюша", "биби", "пим", "лили", "совунья" };
        public static List<Picture> pictures = new List<Picture>();

        public static Timer timer1 = new Timer
        {
            Interval = 1000,
        };

        public static Timer publicTimer = new Timer
        {
            Interval = 1000,
            Enabled = true,
        };

        

        public Form1()
        {
            InitializeComponent();

            timer1.Tick += timer1_Tick;

            pictures.Clear();
            for (int i = 0; i < kolelement; i++)
            {
                Picture picture = new Picture(i, kol_picture);
                pictures.Add(picture);
                Controls.Add(picture);
            }

            NewGame();
            ClientSize = new Size(pictures[pictures.Count - 1].Left + pictures[pictures.Count - 1].Width, pictures[pictures.Count - 1].Top + pictures[pictures.Count - 1].Height);

            publicTimer.Tick += timer2_Tick;
        }

        public void NewGame()
        {
            KolOpenPicture = 0;
            sec = 0;
            publicTimer.Start();

            for (int i = 0; i < kolelement; i++)
                pictures[i].NewGameObject();

            var rnd = new Random();
            var knownNumbers = new HashSet<int>();
            knownNumbers.Clear();
            for (int i = 0; i < kolelement; i++)
            {
                int indexPicture;
                do
                {
                    indexPicture = rnd.Next(0, kolelement);

                } while (!knownNumbers.Add(indexPicture));

                indexPicture = indexPicture % kol_picture;
                pictures[i].pictureName = picture_Name[indexPicture];
                pictures[i].Visible = true;
            }

            int j = rnd.Next(0, 7);
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\Pictures\\" + picture_Name[j] + ".bmp");
            BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            onePicture.VstavkaFon();
            twoPicture.VstavkaFon();
            for (int i = 0; i < kolelement; i++)
            {
                if (pictures[i].Visible)
                    pictures[i].Enabled = true;
            }
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sec++;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Сохранение данных
            Application.Exit();
        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
