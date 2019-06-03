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
        List<string> list = new List<string>(); //Список для изображения карт
        List<string> list2 = new List<string>(); //Список для сравнения с первым списком, чтоюы понять, какое кол-во очков начислять
        List<string> list3 = new List<string>();
        List<PictureBox> mas = new List<PictureBox>();
        int res; int x = 25; int y = 50; int x2 = 25; int y2 = 275; int countOp = 0; int count = 0; int col = 1;
        bool check = false;
        string str = "";
        bool lose = false;
        

        public Form1()
        {
            InitializeComponent();
            GenerateImage();
            label1.Text += count.ToString();
            label2.Text += "?";
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Start();
            checkLose();
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

            for (int i = 0; i < 2; i++)
            {
                giveCard();
                giveCoinsYour();
                giveCardOp();
                giveCoinsOp();
            }
            btn_Give.Enabled = true;
            btn_End.Enabled = true;
        }

        private void btn_Give_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                giveCard();
                giveCoinsYour();
                checkLose();
                if (lose == false)
                {
                    if (check == false)
                    {
                        if (countOp < 21)
                        {
                            res = rnd.Next(1, 100);
                            if (res >= 1 && res <= 50)
                            {
                                giveCardOp();
                                giveCoinsOp();

                            }
                            else { check = true; MessageBox.Show("Ваш противник закончил с взятием карт!"); }
                        }
                        else { check = true; MessageBox.Show("Ваш противник закончил с взятием карт!"); }
                        checkLose();
                    }
                }
                
            }
            

        }
        //Выдаёт карту ВАМ
        private void giveCard()
        {
            res = rnd.Next(list.Count);
            PictureBox pic2 = new PictureBox();
            pic2.Location = new Point(x2, y2);
            pic2.BorderStyle = BorderStyle.FixedSingle;
            pic2.Size = new Size(50, 100);
            pic2.BackColor = SystemColors.Control;
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabStop = false;
            pic2.Load(list[res]);
            Controls.Add(pic2);
            str = list[res];
            list.RemoveAt(res);
            x2 += 50;
        }

        //Выдаёт карту ПРОТИВНИКУ
        private void giveCardOp()
        {
            res = rnd.Next(list.Count);
            PictureBox pic2 = new PictureBox();
            pic2.Name = "picOp" + col.ToString();
            col++;
            pic2.Location = new Point(x, y);
            pic2.BorderStyle = BorderStyle.FixedSingle;
            pic2.Size = new Size(50, 100);
            pic2.BackColor = SystemColors.Control;
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabStop = false;
            pic2.Load("C:\\Users\\nikpl\\Desktop\\для игры\\двадцать одно\\rubaska.jpg");
            Controls.Add(pic2);
            str = list[res];
            list3.Add(list[res]);
            list.RemoveAt(res);
            x += 50;
            mas.Add(pic2);
            
        }
        //Зачисляет очки ВАМ
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
                    else if (i >= 20 && i <= 23) count += 2;
                    else if (i >= 24 && i <= 27) count += 3;
                    else if (i >= 28 && i <= 31) count += 4;
                    else if (i >= 32 && i <= 35) count += 11;
                }
                    
            }

            label1.Text = "Ваши очки: " + count.ToString();
        }
        //Зачисляет очки ПРОТИВНИКУ
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
                    else if (i >= 20 && i <= 23) { countOp += 2; break; }
                    else if (i >= 24 && i <= 27) { countOp += 3; break; }
                    else if (i >= 28 && i <= 31) { countOp += 4; break; }
                    else if (i >= 32 && i <= 35) { countOp += 11; break; }
                }
                    
            }

            
        }

        //Метод для проверки на выигрыш
        private void checkWin()
        {
            if (count > 21 || countOp > 21)
            {
                if (count > countOp) MessageBox.Show("Перебор, Вы проиграли!");
                else if (count < countOp) MessageBox.Show("Перебор, Вы выиграли!");
                else MessageBox.Show("Перебор, Ничья!");
                
            }
            else if (count == 21) MessageBox.Show("Вы выиграли!");
            else if (countOp == 21) MessageBox.Show("Вы проиграли!");
            else if (count > countOp) MessageBox.Show("Вы выиграли!");
            else if (count < countOp) MessageBox.Show("Вы проиграли!");
            else if (count == countOp) MessageBox.Show("Ничья!");
            btn_End.Enabled = false;
            btn_Give.Enabled = false;
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list3.Count; i++)
            {
                mas[i].Load(list3[i]);
            }
            checkWin();
            label2.Text = "Очки противника: " + countOp.ToString();
        }

        private void checkLose()
        {
            if (count > 21 || countOp > 21)
            {
                if (count > countOp) MessageBox.Show("Вы проиграли!");
                else if (count < countOp) MessageBox.Show("Вы выиграли!");
                else if (count == countOp) MessageBox.Show("Ничья!");
                for (int i = 0; i < list3.Count; i++)
                {
                    mas[i].Load(list3[i]);
                }
                btn_End.Enabled = false;
                btn_Give.Enabled = false;
                lose = true;
                label2.Text = "Очки противника: " + countOp.ToString();
            }
                
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
            checkLose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f1 = Application.OpenForms[0];
            f1.Show();
        }
    }
}
