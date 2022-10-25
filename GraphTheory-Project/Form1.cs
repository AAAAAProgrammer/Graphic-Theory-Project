using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphTheory_Project
{
    public partial class Form1 : Form
    { Point MouseCordinate;
        Graphics g;
        Pen P;
        int k = 0;
        Point[] points = new Point[50];

        
        int new_X = 0;
        int new_Y = 0;
        int lines = 20;
        int W_Space;
        int H_Space;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            P = new Pen(Color.Black, 3);
            W_Space = pictureBox1.Width / 20;
            H_Space = pictureBox1.Height / 20;
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panl1_MouseClick(object sender, MouseEventArgs e)
        {
            
            

        }

        private void DrawGrid()
        {
            Graphics gr = pictureBox1.CreateGraphics();
            Pen P_gr = new Pen(Brushes.Black, 1);
            
            float x = 0f;
            float y = 0f;
            float xSpace = pictureBox1.Width / lines;
            float ySpace = pictureBox1.Height / lines;




            
            for (int i = 0; i < lines; i++)
            {
                
                gr.DrawLine(P_gr, x, y, x, pictureBox1.Height);
                x += xSpace;
            }
            x = 0f;
            for (int i = 0; i < lines; i++)
            {
                
                gr.DrawLine(P_gr, x, y, pictureBox1.Width, y);
                y+=ySpace;
            }


        }

        private void panl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int new_x = MouseCordinate.X / W_Space;
            int new_y = MouseCordinate.Y / H_Space;
            
            int x_center = new_x * W_Space + Convert.ToInt32(0.5 * W_Space);
            int y_center = new_y * H_Space + Convert.ToInt32(0.5 * H_Space);

            g.DrawEllipse(P, x_center-12 , y_center - 12 , 25, 25);
            points[k++] = new Point(MouseCordinate.X, MouseCordinate.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseCordinate = pictureBox1.PointToClient(Cursor.Position);
            
            Console.WriteLine(MouseCordinate);
            

        }

        private void chboxGrid_CheckStateChanged(object sender, EventArgs e)
        {
            if (chboxGrid.Checked)
            {
                DrawGrid();
            }
            else
            {
                //pictureBox1.Invalidated();
            }
        }
    }
}
