using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyOne
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<string> list = new List<string>(); //Списко для изображения карт
        int res;
        int x = 25;
        int y = 50;

        public Form1()
        {
            InitializeComponent();
            GenerateImage();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Start();
        }

        //Заливаем в наш список пути с изображениями карт
        private void GenerateImage()
        {
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\6vini.jpg");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\6tref.PNG");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\6bubi.gif");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\6chirva.gif");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\7vini.jpg");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\7tref.jpeg");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\7bubi.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\7chirva.jpg");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\8vini.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\8tref.jpg");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\8bubi.jpg");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\8chirva.gif");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\9vini.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\9tref.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\9bubi.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\9chirva.png");

        }

        //Метод для добавлении первых двух случайных карт
        private void Start()
        {
            btn_Start.Enabled = false;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    giveCard();

                }

                y = 275;
                x = 25;
            }
            x = 125;
            btn_Give.Enabled = true;
            btn_End.Enabled = true;
        }

        private void btn_Give_Click(object sender, EventArgs e)
        {
            giveCard();
        }

        private void giveCard()
        {
            res = rnd.Next(list.Count);
            PictureBox pic2 = new PictureBox();
            pic2.Location = new Point(x, y);
            pic2.BorderStyle = BorderStyle.FixedSingle;
            pic2.Size = new Size(50, 100);
            pic2.BackColor = SystemColors.Control;
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabStop = false;
            pic2.Load(list[res]);
            Controls.Add(pic2);
            list.RemoveAt(res);
            x += 50;
        }
    }
}
