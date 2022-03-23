using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravity = 10;
        int speed = 15;
        int score = 0;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Space) {
                gravity = 15;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            else if (e.KeyCode == Keys.Enter) {
                timer1.Start();
            }
        }

        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += gravity;
            pipe1.Left -= speed;
            pipe2.Left -= speed;
            label1.Text = $"Score: { score}";

            if (pipe1.Left < -180)
            {
                pipe1.Left = rnd.Next(200, 600);
                score++;
            }

            if (pipe2.Left < -180)
            {
                pipe2.Left = rnd.Next(400, 700);
                score++;
            }



            if (pictureBox1.Bounds.IntersectsWith(pipe1.Bounds)| pictureBox1.Bounds.IntersectsWith(pipe2.Bounds)| pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer1.Stop();
                label1.Text += " Game Over";
                System.Threading.Thread.Sleep(1500);
                Application.Restart(); 
            }

            if (score > 10 )
            {
                speed += 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pipe2_Click(object sender, EventArgs e)
        {

        }
    }
}
