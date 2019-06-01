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
        List<string> list2 = new List<string>(); 
        int res;
        int x = 25;
        int y = 50;
        int x2 = 25;
        int y2 = 275;
        int countOp = 0;
        int count = 0;
        bool check = false;
        string str = "";

        public Form1()
        {
            InitializeComponent();
            GenerateImage();
            label1.Text += count.ToString();
            label2.Text += countOp.ToString();
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
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\10vini.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\10tref.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\10bubi.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\10chirva.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Valetvini.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Valettref.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Valetbubi.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Valetchirva.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Damavini.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Damatref.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Damabubi.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Damachirva.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Kingvini.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Kingtref.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Kingbubi.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Kingchirva.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Avini.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Atref.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Abubi.png");
            list.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Achirva.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\6vini.jpg");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\6tref.PNG");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\6bubi.gif");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\6chirva.gif");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\7vini.jpg");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\7tref.jpeg");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\7bubi.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\7chirva.jpg");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\8vini.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\8tref.jpg");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\8bubi.jpg");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\8chirva.gif");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\9vini.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\9tref.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\9bubi.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\9chirva.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\10vini.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\10tref.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\10bubi.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\10chirva.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Valetvini.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Valettref.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Valetbubi.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Valetchirva.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Damavini.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Damatref.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Damabubi.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Damachirva.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Kingvini.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Kingtref.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Kingbubi.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Kingchirva.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Avini.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Atref.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Abubi.png");
            list2.Add("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\Achirva.png");
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
                    if (i == 0) giveCoinsOp();
                    else giveCoinsYour();
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
            if (list.Count > 0)
            {
                giveCard();
                giveCoinsYour();
            }

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
            str = list[res];
            list.RemoveAt(res);
            x += 50;
        }

        private void giveCardOp()
        {
            res = rnd.Next(list.Count);
            PictureBox pic2 = new PictureBox();
            pic2.Location = new Point(x, y);
            pic2.BorderStyle = BorderStyle.FixedSingle;
            pic2.Size = new Size(50, 100);
            pic2.BackColor = SystemColors.Control;
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabStop = false;
            pic2.Load("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\rubaska.jpg");
            Controls.Add(pic2);
            str = list[res];
            list.RemoveAt(res);
            x += 50;
        }

        private void giveCoinsYour()
        {
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].Equals(str))
                {
                    if (i >= 0 && i <= 3) count += 6;
                    else if (i >= 4 && i <= 7) count += 7;
                    else if (i >= 8 && i <= 11) count += 8;
                    else if (i >= 12 && i <= 15) count += 9;
                    else if (i >= 16 && i <= 19) count += 10;
                    else if (i >= 20 && i <= 23) count += 10;
                    else if (i >= 24 && i <= 27) count += 10;
                    else if (i >= 28 && i <= 31) count += 10;
                    else if (i >= 32 && i <= 35) count += 11;
                }
                    
            }

            label1.Text = "Ваши очки: " + count.ToString();
        }
        private void giveCoinsOp()
        {
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].Equals(str))
                {
                    if (i >= 0 && i <= 3) { countOp += 6; break; }
                    else if (i >= 4 && i <= 7) { countOp += 7; break; }
                    else if (i >= 8 && i <= 11) { countOp += 8; break; }
                    else if (i >= 12 && i <= 15) { countOp += 9; break; }
                    else if (i >= 16 && i <= 19) { countOp += 10; break; }
                    else if (i >= 20 && i <= 23) { countOp += 10; break; }
                    else if (i >= 24 && i <= 27) { countOp += 10; break; }
                    else if (i >= 28 && i <= 31) { countOp += 10; break; }
                    else if (i >= 32 && i <= 35) { countOp += 11; break; }
                }
                    
            }

            label2.Text = "Очки противника: " + countOp.ToString();
        }
    }
}
