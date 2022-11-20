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
    {
        
        Point MouseCordinate;
        Graphics g;
        Graphics t;
        Pen P;
        bool Move = false;
        Pen P_backcolor;
        Pen P_line;
        int k = 1;
        bool Drwa = false;
         Point[] points = new Point[10] ;
        Label[] labl = new Label[10];
        int loc = 0;
        private TextBox text;
        int new_X = 0;
        int new_Y = 0;
        int lines = 20;
        int W_Space;
        int H_Space;
        Location[] loc2 = new Location[100] ;
        int X_startLine = 0;
        int Y_startLine = 0;
        int x1_old;
        int x2_old;
        int y1_old;
        int y2_old;


        Label[] index = new Label[20];
        public Form1()
        {
       
            //Array.Clear(loc2, 0, loc2.Length);
            InitializeComponent();
            t = pictureBox1.CreateGraphics();
            g = pictureBox1.CreateGraphics();
            P = new Pen(Color.Blue, 3);
            P_backcolor = new Pen(this.BackColor, 3);
            P_line = new Pen(Color.Black, 3);
            W_Space = pictureBox1.Width / 20;
            H_Space = pictureBox1.Height / 20;
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panl1_MouseClick(object sender, MouseEventArgs e)
        {
            
            

        }
        private void CreateMatrix(int Vertex)
        {

            //this.panl1.Controls.Clear();

            for (int i = Vertex - 1; i <= Vertex; i++)
            {
                labl[0] = new Label();
                labl[0].BorderStyle = BorderStyle.FixedSingle;
                labl[0].Location = new Point(50+loc, 50 );
                labl[0].Size = new Size(30, 30);
                labl[0].Name = "lbl";
                labl[0].TabIndex = 0;
                loc += 30;
                this.panl1.Controls.Add(labl[0]);
            }
            if (Vertex != 0)
            {
                for (int j = Vertex - 1; j <= Vertex; j++)
                {
                    labl[0] = new Label();
                    labl[0].BorderStyle = BorderStyle.FixedSingle;
                    labl[0].Location = new Point(50, 50 + loc-30);
                    labl[0].Size = new Size(30, 30);
                    labl[0].Name = "lbl";
                    labl[0].TabIndex = 0;
                    //loc += 30;
                    this.panl1.Controls.Add(labl[0]);
                }
            }

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

        private void DrawLines(int x, int y)
        {
            Console.WriteLine("bbbb in drwa line");
            if (chxDrwaLine.Checked)
            {
                Console.WriteLine("in drwa line");
                foreach (var item in points)
                {   
                    Console.WriteLine("P.X {0} P.Y {1}", item.X, item.Y);
                }
                bool find = false;
                foreach (var p in points)
                {
                    if (p == null)
                        return;
                    //t.DrawLine(P_line, p.X - 26, p.Y - 26, p.X + 26, p.Y + 26);
                    if ((x >= p.X - 26 && x <= p.X + 26) && (y >= p.Y - 26 && y <= p.Y + 26) && !Drwa)
                    {
                        Console.WriteLine("in if ");
                        Drwa = true;
                        X_startLine = x;
                        Y_startLine = y;
                        find = true;
                    }
                    else if (x != p.X && y != p.Y && Drwa)
                    {
                        Console.WriteLine("in elif ");
                        Drwa = false;
                        t.DrawLine(P_line, X_startLine, Y_startLine, x, y);
                        find = true;
                        
                        
                        break;
                    }
                    if (find)
                        break;
                }


            }
        }


        private void Vertces(int x, int y)
        {
            

            if (!chxDrwaLine.Checked)
            {
                Console.WriteLine("ADD POINT");
                foreach (var item in points)
                {
                    Console.WriteLine("P.X {0} P.Y {1}", item.X, item.Y);
                }
                if (k >= points.Length)
                {
                    MessageBox.Show("This is MAXMUM OF POINTS");
                    return;
                }

                foreach (var p in points)
                {
                    //Console.WriteLine("P.X {0} P.Y {1}", p.X, p.Y);
                    if (p == null)
                        break;
                    if (x == p.X && y == p.Y)
                    {
                        Console.WriteLine("HHHHHH");
                        return;
                    }
                }

                points[k] = new Point(x, y);


                t.DrawEllipse(P, x - 12, y - 12, 25, 25);
                labl[k] = new Label();
                labl[k].Location = new Point(x - 5, y - 8);
                labl[k].Name = k.ToString();
                labl[k].Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Underline);
                labl[k].Size = new Size(13, 13);
                labl[k].Text = Convert.ToString(k);
                labl[k].TabIndex = 3;


                this.pictureBox1.Controls.Add(this.labl[k]);

                k++;

            }
        }

        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int new_x = MouseCordinate.X / W_Space;
            int new_y = MouseCordinate.Y / H_Space;
            
            int x_center = new_x * W_Space + Convert.ToInt32(0.5 * W_Space);
            int y_center = new_y * H_Space + Convert.ToInt32(0.5 * H_Space);

            

            
            // CreateMatrix(k);
            Vertces(x_center, y_center);
            DrawLines(x_center, y_center);

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseCordinate = pictureBox1.PointToClient(Cursor.Position);
            lblMouse.Text = MouseCordinate.X.ToString() + " , " + MouseCordinate.Y.ToString();

            if (chxDrwaLine.Checked)
            {   foreach (var p in points)
                {
                    if (MouseCordinate.X == p.X && MouseCordinate.Y == p.Y)
                    {

                    }
                }
            }

            //Console.WriteLine(MouseCordinate);
            if (false)
            {
                //foreach (var item in points)
                //{
                //    g.DrawEllipse(P, item.X - 12, item.Y - 12, 25, 25);
                //}
               // pictureBox1.Invalidate();
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                t = g;
                //g.Clear(panl1.BackColor);
                Point s = new Point(X_startLine, Y_startLine);
                //ControlPaint.DrawReversibleLine(s,MouseCordinate,this.BackColor);
                //if (Move)
                //{
                //    g.DrawLine(P_backcolor, x1_old, y1_old, x2_old, y2_old);
                //}
                //g.DrawLine(P_line, X_startLine, Y_startLine, MouseCordinate.X, MouseCordinate.Y);
                x1_old = X_startLine;
                y1_old = Y_startLine;
                x2_old = MouseCordinate.X;
                y2_old = MouseCordinate.Y;
                Move = true;
            }

        }

        private void chboxGrid_CheckStateChanged(object sender, EventArgs e)
        {
            if (chboxGrid.Checked)
            {
                DrawGrid();
            }
            else
            {
               // pictureBox1.Invalidated();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // pictureBox1.Invalidated();
            //t.Clear(Color.Blue);
            t.Clear(pictureBox1.BackColor);
            pictureBox1.Controls.Clear();
            points = new Point[10];
            k = 0;
            chboxGrid.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
