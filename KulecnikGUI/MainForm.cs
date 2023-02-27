using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KulecnikGUI
{
    public partial class MainForm : Form
    {
        public static Random rnd = new Random(); //vytvoreni random
        public static List<Kulicka> kulicky = new List<Kulicka>(); //vytvoreni listu
        //Vytvoreni stetce s nahodnymi barvy
        public Brush b = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));

        public MainForm()
        {
            InitializeComponent();
            GenerujKulicky(15); //vytvoreni 15 kulicek
            timer1.Start();
        }

        void Timer1Tick(object sender, EventArgs e)
        {
            // mechanika pohybu kulicek
            foreach (Kulicka k in kulicky)
            {
                // kontrola hranic prostoru a pripadne prenastaveni vektoru
                if (k.X == 0)//PRAVA HRANICE
                    k.vektorX = 1; //v levo (1,0,-1)
                if (k.X == pictureBox1.Width - 20)//LEVA HRANICE
                    k.vektorX = -1; //vpravo
                if (k.Y == 0) //SPODNI HRANICE
                    k.vektorY = 1; //nahoru
                if (k.Y == pictureBox1.Height - 20)//DOLNI HRANICE
                    k.vektorY = -1; //dolu

                // vlastni pohyb kuličky osou x a y
                k.X += k.vektorX;
                k.Y += k.vektorY;
            }
            // zaktualizuje zmeny ve zobrazeni pictureboxu
            pictureBox1.Refresh();
        }

        void PictureBox1Paint(object sender, PaintEventArgs e)
        {
            foreach (Kulicka k in kulicky)
            {
                Graphics g = e.Graphics; //pro ulehceni zivota
                g.FillEllipse(b, k.X, k.Y, 20, 20); //brush, pozice horizont, pozice verti, velikost kulicky 20px
            }
        }

        public static void GenerujKulicky(int pocet)
        {
            for (int i = 0; i < pocet; i++)
            {
                PridejKulicku();
            }
        }

        public static void PridejKulicku()
        {
            int[] nums = new int[4];
            nums[0] = rnd.Next(0, 285); //pozice sirka
            nums[1] = rnd.Next(0, 239); //pozice vyska
            nums[2] = rnd.Next(-1, 2);  //pohyb sirka
            if (nums[2] == 0) nums[2] = 1; //at se vsechno hybe
            nums[3] = rnd.Next(-1, 2);  //pohyb vyska
            kulicky.Add(new Kulicka(nums[0], nums[1], nums[2], nums[3]));
        }

        private void pomalaToolStripMenuItem_Click(object sender, EventArgs e) //rychlost pomala
        {
            timer1.Interval = 50;
        }

        private void rychlaToolStripMenuItem_Click(object sender, EventArgs e) //rychlost rychla
        {
            timer1.Interval = 10;
        }

        private void cervenaToolStripMenuItem_Click(object sender, EventArgs e) //nahodny odstin cervene
        {
            b = new SolidBrush(Color.FromArgb(rnd.Next(150, 255), 0, 0)); //omezeno na 150-255, moc nizke
                                                                          //hodnoty vypadaji cerne
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e) //konec aplikace
        {
            Application.Exit();
        }
    }
}
