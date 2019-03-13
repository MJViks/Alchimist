using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Alchimist
{
    public partial class fr1 : Form
    { 
        string a = "";   //задание переменных
        PictureBox po;
        public bool mus = true, eff = true;
        public int fon = 0;
        


        Options opt = new Options();


        public fr1() //инициализация
        {
            InitializeComponent();
            this.AllowDrop = true;
            del.AllowDrop = true;
        }

     
        private void pb_MouseDown(object sender, MouseEventArgs e) //при отпусчкании мыши
        {
            timer1.Enabled = true;
            po = (sender as PictureBox);
          
                a = (sender as PictureBox).Name;
                (sender as PictureBox).DoDragDrop((sender as PictureBox), DragDropEffects.None);   
        }

        private void pb_MouseUp(object sender, MouseEventArgs e) //при поднятии мыши
        {    
            timer1.Enabled = false;
        }

        private void pb_GiveFeedback(object sender, GiveFeedbackEventArgs e) //при перетаскивании
        {
            //(пользовательский курсор)
            e.UseDefaultCursors = false;
            if ((e.Effect & DragDropEffects.Move) == DragDropEffects.Move)
                Cursor.Current = Cursors.Hand;
            else
                Cursor.Current = Cursors.Hand;  
        }

        private void pictureBox1_Click(object sender, EventArgs e) //при нажатии
        {
            Random rn = new Random();
           
            PictureBox P = new PictureBox();
           
            P.Image = (sender as PictureBox).Image;
            P.Width = p1.Width;
            P.Height = p1.Height;
            P.SizeMode = PictureBoxSizeMode.StretchImage;
            P.Top = rn.Next(600);
            P.Left = rn.Next(600);
            P.AllowDrop = true;
            P.Visible = true;
            P.BackColor = Color.Transparent ;
            P.Name = (sender as PictureBox).Tag.ToString().Trim(new char[] { 'p' });
            P.MouseDown += pb_MouseDown;
            P.DragDrop += pb_DragDrop;
            P.MouseEnter += pb_MouseEnter;
            P.MouseLeave += pb_MouseLeave;
            P.MouseUp += pb_MouseUp;
            P.DragEnter += pb_DragEnter;
            P.UseWaitCursor = false;
            P.GiveFeedback += pb_GiveFeedback;
            P.Parent = this;
        }

        private void pb_DragEnter(object sender, DragEventArgs e) //при кидании
        {
            e.Effect = DragDropEffects.All;
        }

        private void timer1_Tick(object sender, EventArgs e) //таймер движения за мышю

        {
            po.Top = MousePosition.Y - Top;
            po.Left = MousePosition.X - Left;
            
        }

        private void pb_DragDrop(object sender, DragEventArgs e) //при кидании
        {
            if ((sender as PictureBox).Name == "del")
            {
                po.Visible = false;
                return;
            }
            int res = Convert.ToInt32((sender as PictureBox).Name + a);
            
            switch (res) //проверка кидаемого и кидимого
            {
                case 12:
                    pictureBox1_Click(p7, e);
                    p7.Visible = true;
                  
                    break;
                case 21:
                    pictureBox1_Click(p7, e);
                    p7.Visible = true;
                    break;
                case 43:
                    pictureBox1_Click(p5, e);
                    p5.Visible = true;
                    break;
                case 34:
                    pictureBox1_Click(p5, e);
                    p5.Visible = true;
                    break;
                case 41:
                    pictureBox1_Click(p6, e);
                    p6.Visible = true;
                    break;
                case 14:
                    pictureBox1_Click(p6, e);
                    p6.Visible = true;
                    break;
                case 53:
                    pictureBox1_Click(p8, e);
                    p8.Visible = true;
                    break;
                case 35:
                    pictureBox1_Click(p8, e);
                    p8.Visible = true;
                    break;
                case 11:
                    pictureBox1_Click(p10, e);
                    p10.Visible = true;
                    break;
                case 102:
                    pictureBox1_Click(p9, e);
                    p9.Visible = true;
                    break;
                case 210:
                    pictureBox1_Click(p9, e);
                    p9.Visible = true;
                    break;
                case 15:
                    pictureBox1_Click(p14, e);
                    p14.Visible = true;
                    break;
                case 51:
                    pictureBox1_Click(p14, e);
                    p14.Visible = true;
                    break;
                case 26:
                    pictureBox1_Click(p12, e);
                    p12.Visible = true;
                    break;
                case 62:
                    pictureBox1_Click(p12, e);
                    p12.Visible = true;
                    break;
                case 1412:
                    pictureBox1_Click(p16, e);
                    p16.Visible = true;
                    break;
                case 1214:
                    pictureBox1_Click(p16, e);
                    p16.Visible = true;
                    break;
                case 147:
                    pictureBox1_Click(p11, e);
                    p11.Visible = true;
                    break;
                case 714:
                    pictureBox1_Click(p11, e);
                    p11.Visible = true;
                    break;
                case 33:
                    pictureBox1_Click(p18, e);
                    p18.Visible = true;
                    break;
                case 167:
                    pictureBox1_Click(p13, e);
                    p13.Visible = true;
                    break;
                case 716:
                    pictureBox1_Click(p13, e);
                    p13.Visible = true;
                    break;
                case 1213:
                    pictureBox1_Click(p17, e);
                    p17.Visible = true;
                    break;
                case 1312:
                    pictureBox1_Click(p17, e);
                    p17.Visible = true;
                    break;
                case 1414:
                    pictureBox1_Click(p15, e);
                    p15.Visible = true;
                    break;
                case 1315:
                    pictureBox1_Click(p22, e);
                    p22.Visible = true;
                    break;
                case 1513:
                    pictureBox1_Click(p22, e);
                    p22.Visible = true;
                    break;
                case 222:
                    pictureBox1_Click(p23, e);
                    p23.Visible = true;
                    break;
                case 232:
                    pictureBox1_Click(p21, e);
                    p21.Visible = true;
                    break;
                case 223:
                    pictureBox1_Click(p21, e);
                    p21.Visible = true;
                    break;
                case 1122:
                    pictureBox1_Click(p19, e);
                    p19.Visible = true;
                    break;
                case 2211:
                    pictureBox1_Click(p19, e);
                    p19.Visible = true;
                    break;
                case 1119:
                    pictureBox1_Click(p20, e);
                    p20.Visible = true;
                    break;
                case 1911:
                    pictureBox1_Click(p20, e);
                    p20.Visible = true;
                    MessageBox.Show("Поздравляю! Ты дошел до венца человечества (Вейпера). Игра окончена! Дальше развлекайся сам!", "Победа!");

                    break;

                default: timer1.Enabled = false; return;

            }
            timer1.Enabled = false;
            (sender as PictureBox).Visible = false;
            po.Visible = false;
            if (eff)
            beep();

        }

        private void Form1_DragDrop(object sender, DragEventArgs e) //при перетаскивании
        {
            timer1.Enabled = false;
        }

        private void Form1_Resize(object sender, EventArgs e) //при изменении размера
        {
            del.Top = Height - del.Height - 50;
            panel1.Height = Height;
            panel1.Width = Width;
            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);
            pictureBox2.Left = (Width / 2) - (pictureBox1.Width / 2);
            pictureBox3.Left = (Width / 2) - (pictureBox1.Width / 2);
            pictureBox4.Left = (Width / 2) - (pictureBox1.Width / 2);
        }


        private void pb_MouseEnter(object sender, EventArgs e) //при наведении
        {
            
                (sender as PictureBox).Top = (sender as PictureBox).Top + 3;
                (sender as PictureBox).Left = (sender as PictureBox).Left + 3;
                (sender as PictureBox).Width = (sender as PictureBox).Width + 3;
                (sender as PictureBox).Height = (sender as PictureBox).Height + 3;
            
        }

        private void pb_MouseLeave(object sender, EventArgs e) //при не наведении
        {
            
                (sender as PictureBox).Top = (sender as PictureBox).Top - 3;
                (sender as PictureBox).Left = (sender as PictureBox).Left - 3;
                (sender as PictureBox).Width = (sender as PictureBox).Width - 3;
                (sender as PictureBox).Height = (sender as PictureBox).Height - 3;
            
        }


        private void pictureBox1_MouseEnter(object sender, EventArgs e) //при наведении
        {
            pictureBox1.Image = (Image)(Properties.Resources.Играть1);
          
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)//при наведении
        {
            pictureBox3.Image = (Image)(Properties.Resources.Настройки1);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)//при наведении
        {
            pictureBox2.Image = (Image)(Properties.Resources.Правила1);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)//при наведении
        {
            pictureBox1.Image = (Image)(Properties.Resources.Играть);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)//при наведении
        {
            pictureBox3.Image = (Image)(Properties.Resources.Настройки);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)//при наведении
        {
            pictureBox2.Image = (Image)(Properties.Resources.Правила);
        }

        bool menu = true;

        private void pictureBox1_Click_1(object sender, EventArgs e)//начало игры
        {
            panel1.Visible = false;
            if (menu)
            {
                KeyDown += Form1_KeyDown;
                menu = false;
            }

        }

        WMPLib.WindowsMediaPlayer PlayerBeep;//переменная плеера


        private void beep() //бибика
        {

            PlayerBeep = new WMPLib.WindowsMediaPlayer();
        
            PlayerBeep.URL = Directory.GetCurrentDirectory() + @"\res\Beep.mp3";
            PlayerBeep.controls.play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //нажатие ESC
        {
            if (e.KeyData == Keys.Escape)
            {
                if (panel1.Visible)
                    panel1.Visible = false;
                else
                    panel1.Visible = true;
            }
        }
        public WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();//фоновая музыка


        private void Form1_Load(object sender, EventArgs e) //при загрузки формы
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\res");
            File.WriteAllBytes("res\\Beep.mp3", Properties.Resources.Beep);
            File.WriteAllBytes("res\\Фон.mp3", Properties.Resources.Фон);
           
            Player.PlayStateChange += Player_PlayStateChange;
            Player.URL = Directory.GetCurrentDirectory() + @"\res\Фон.mp3";
            Player.controls.play();
        }
        private void Player_PlayStateChange(int NewState) //при окончании музыки
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                Player.controls.play();
            }
        }
         
        private void pictureBox2_Click(object sender, EventArgs e) //правила
        {
            Form ru = new Rules();
            ru.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//настройки
        {
            
            opt.cb_fon.SelectedIndex = fon;
            opt.cb_eff.Checked = eff;
            opt.cb_mus.Checked = mus;
            opt.Show();
        }

        public void opt_save()//сохранение настроек
        {
            eff = opt.cb_eff.Checked;
            mus = opt.cb_mus.Checked;
            fon = opt.cb_fon.SelectedIndex;

            switch (opt.cb_fon.SelectedIndex)
            {
                case 0: BackgroundImage = (Image)(Properties.Resources.u1); break;
                case 1: BackgroundImage = (Image)(Properties.Resources.u2); break;
                case 2: BackgroundImage = null; break;
            }
            if (opt.cb_mus.Checked)
                Player.controls.play();
            else
                Player.controls.pause();
            opt.Hide();
        }
    }
}
