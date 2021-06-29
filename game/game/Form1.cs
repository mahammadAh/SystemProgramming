using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace game
{
    public partial class Form1 : Form
    {
        
        double gameTime = 0;
        double oldGameTime = 0;
        double difference = 10;
        float points = 0;
    
        string sym = "A";
        Random randForSym = new Random();
       
        public Form1()
        {
            InitializeComponent();
           
            timer1.Tick += new EventHandler(Timer_Tick);
            timer1.Interval = 100;


        }

        private void Timer_Tick(object sender, EventArgs e)
        {         
            gameTime+=0.1;           
            TimeLabel.Text =  gameTime.ToString();                   
        }

      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(Convert.ToChar(e.KeyCode).ToString()== label1.Text)
            {
                points++;
                Pointlabel.Text = points.ToString();
                label1.Text = Convert.ToChar(randForSym.Next(65, 90)).ToString();
                Point point = new Point(randForSym.Next(0, 700), randForSym.Next(0, 350));
                label1.Location = point;
                if ((gameTime - oldGameTime) < difference)
                {
                    difference = gameTime - oldGameTime;
                    oldGameTime = gameTime;
                    Bestlabel.Text = difference.ToString();
                   
                }
            }
        }

     

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
           
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            gameTime = 0;
            oldGameTime = 0;
            difference = 0;
            points = 0;
            label1.Text = Convert.ToChar(randForSym.Next(65, 90)).ToString();
            Pointlabel.Text = points.ToString();
            Bestlabel.Text = difference.ToString();
            timer1.Enabled = true;
            this.ActiveControl = null;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.ActiveControl = null;
        }
    }
}
