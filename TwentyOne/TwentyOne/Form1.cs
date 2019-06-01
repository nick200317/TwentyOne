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
        }

        //Метод для добавлении первых двух случайных карт
        private void Start()
        {
            int res;
            int x = 25;
            int y = 50;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    res = rnd.Next(3);
                    PictureBox pic2 = new PictureBox();
                    pic2.Location = new Point(x, y);
                    pic2.BorderStyle = BorderStyle.FixedSingle;
                    pic2.Size = new Size(50, 100);
                    pic2.BackColor = SystemColors.Control;
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic2.TabStop = false;
                    pic2.Load(list[res]);
                    x += 50;
                    Controls.Add(pic2);

                }

                y = 275;
                x = 25;
            }
        }
    }
}
