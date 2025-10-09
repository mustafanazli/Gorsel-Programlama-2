using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] buttons = new Button[4];
        Point[] startPositions = new Point[4];
        Point[] targetPositions = new Point[4];
        bool movingToCorner = true;
        int speed = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            for (int i = 0; i < 4; i++)
            {
                buttons[i] = new Button();
                buttons[i].Size = new Size(60, 60);
                buttons[i].Text = $"{i + 1}";
                buttons[i].BackColor = Color.Black;
                buttons[i].ForeColor = Color.White;
                buttons[i].Location = new Point(centerX - 30, centerY - 30);
                this.Controls.Add(buttons[i]);
                startPositions[i] = buttons[i].Location;
            }

            targetPositions[0] = new Point(0, 0);
            targetPositions[1] = new Point(this.ClientSize.Width - buttons[1].Width, 0);
            targetPositions[2] = new Point(0, this.ClientSize.Height - buttons[2].Height);
            targetPositions[3] = new Point(this.ClientSize.Width - buttons[3].Width, this.ClientSize.Height - buttons[3].Height);

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                Point current = buttons[i].Location;
                Point target = movingToCorner ? targetPositions[i] : startPositions[i];

                int dx = target.X - current.X;
                int dy = target.Y - current.Y;

                if (Math.Abs(dx) < speed && Math.Abs(dy) < speed)
                {
                    buttons[i].Location = target;
                }
                else
                {
                    int moveX = speed * Math.Sign(dx);
                    int moveY = speed * Math.Sign(dy);
                    buttons[i].Location = new Point(current.X + moveX, current.Y + moveY);
                }
            }

            bool allReached = true;
            for (int i = 0; i < 4; i++)
            {
                if (buttons[i].Location != (movingToCorner ? targetPositions[i] : startPositions[i]))
                {
                    allReached = false;
                    break;
                }
            }

            if (allReached)
                movingToCorner = !movingToCorner;
        }
    }
}
