using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8; //tốc độ trò chơi
        int gravity = 10; //trọng lực
        int score = 0; //biến điểm
        
        public Form1()
        {
            InitializeComponent();
            labelRestart.Hide();

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            
            
            pictureBoxflappybird.Top += gravity; //thay đổi con chim lên xuống
            //di chuyển các ống
            pictureBoxPipeBottom.Left -= pipeSpeed;
            pictureBoxPipeTop.Left -= pipeSpeed;
            labelScore.Text ="Score: "+ score.ToString();

            //đưa 2 cái ống tiếp tục chạy
            if(pictureBoxPipeBottom.Left<-150)
            {
               
                Random a = new Random(); 
                pictureBoxPipeBottom.Left = a.Next(350,500);               
                score++;
            }    
            if(pictureBoxPipeTop.Left<-180)
            {
                Random b = new Random();
                pictureBoxPipeTop.Left = b.Next(300,500);
                score++;
            }  
            if(pictureBoxflappybird.Bounds.IntersectsWith(pictureBoxPipeBottom.Bounds)||pictureBoxflappybird.Bounds.IntersectsWith(pictureBoxPipeTop.Bounds)
                ||pictureBoxflappybird.Bounds.IntersectsWith(pictureBoxGround.Bounds))//giao nhau
                {
                endGame();

            }
           
            if(score>5) //tăng tốc độ 
            {
                pipeSpeed = 10; 
            }
            else if(score>10)
            {
                pipeSpeed = 15;
            }
            else if(score >50)
            {
                pipeSpeed = 20;
            }
            else if(score>80)
            {
                pipeSpeed = 50;
            }
            else if(score>100)
            {
                pipeSpeed = 30;
            }    
            if(score>200)
            {
                timerGameTimer.Stop();
                labelScore.Text += "You Win";
            }  
            //tránh bug game bay quá cao
            if(pictureBoxflappybird.Top<-25)
            {
                endGame(); 
            }    
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

           
                if (e.KeyCode == Keys.Space) //kiểm tra có bấm nút space ko
                {
               
                    gravity = -10; //thay đổi trọng lực

                }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //kiểm tra có bấm nút space ko
            {
                gravity = 10; //thay đổi trọng lực
               
            }
        }
        private void endGame()
        {
            
            timerGameTimer.Stop();
            labelScore.Text += " game over!!!";
            labelRestart.Show();
            labelQuit.Show();
            
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
            timerGameTimer.Stop();
            pictureBoxflappybird.Parent = this.pictureBoxBackGround;
            pictureBoxPipeBottom.Parent = this.pictureBoxBackGround;
           
           
            
            labelStart.Parent = this.pictureBoxBackGround;
           
            //làm ẩn phông nền màu
            labelQuit.Parent = pictureBoxBackGround;
            labelQuit.BackColor = Color.Transparent;
            labelRestart.Parent =pictureBoxBackGround;
            labelRestart.BackColor = Color.Transparent;
            pictureBoxflappybird.Parent = pictureBoxBackGround;
            pictureBoxflappybird.BackColor = Color.Transparent;

            pictureBoxPipeTop.Parent = pictureBoxBackGround;
            pictureBoxPipeTop.BackColor = Color.Transparent;

            
          
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBoxGround_Click(object sender, EventArgs e)
        {

        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            timerGameTimer.Start();
            labelRestart.Hide();
            labelQuit.Hide();
            pictureBoxflappybird.Location = new Point(23, 320);
            //spon xa ra
            pictureBoxPipeBottom.Left = 600;
            pictureBoxPipeTop.Left = 650;
            score = 0;
            labelScore.Text = "Score: " + score.ToString();
        }

        private void labelStar_Click(object sender, EventArgs e)
        {
            timerGameTimer.Start();
            labelStart.Hide();
            labelQuit.Hide();
        }

        private void labelQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
