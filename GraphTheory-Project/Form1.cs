using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphTheory_Project;

namespace GraphTheory_Project
{

   

    public partial class Form1 : Form
    {
        LinkedList<int>[] AdjList = new LinkedList<int>[10]; 
        
        bool[,] AdjMatrix = new bool[10, 10];
        int[,] IncMatrix = new int[10, 10];
        Point MouseCordinate;
        bool Selected_point;
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
        
        int X_startLine = 0;
        int Y_startLine = 0;

        int index_of_selectedPoint;
        List<node> Line = new List<node>();

        Node [] Vertices;
        List<Node> N;
        List<Node> N_Copy;
        Label[] index = new Label[20];
        AdjacencyList adjacencyList = new AdjacencyList(10);
        Node selectedPoint;
        class node
        {
            public Point p;
            public int index;
            
            public node(Point P,int I)
            {
                p = P;
                index = I;
            }
            
        }
        public Form1()
        {

            //Array.Clear(loc2, 0, loc2.Length);
            InitializeComponent();
            Vertices = new Node[10];
            t = pictureBox1.CreateGraphics();
            
            P = new Pen(Color.Blue, 3);
            P_backcolor = new Pen(this.BackColor, 3);
            P_line = new Pen(Color.Black, 3);
            W_Space = pictureBox1.Width / 20;
            H_Space = pictureBox1.Height / 20;

           N = new List<Node>();
           N_Copy = new List<Node>();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   
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

     

        private void DrawLines(int x, int y)
        {
            //Console.WriteLine("bbbb in drwa line");
            if (chxDrwaLine.Checked)
            {
               // Console.WriteLine("in drwa line");
                foreach (var item in points)
                {   
                   // Console.WriteLine("P.X {0} P.Y {1}", item.X, item.Y);
                }
                bool find = false;
                foreach (var p in points)
                {
                    if (p == null)
                        return;
                    //t.DrawLine(P_line, p.X - 26, p.Y - 26, p.X + 26, p.Y + 26);
                    if ((x >= p.X - 26 && x <= p.X + 26) && (y >= p.Y - 26 && y <= p.Y + 26) && !Drwa)
                    {
                       // Console.WriteLine("in if ");
                        Drwa = true;
                        X_startLine = x;
                        Y_startLine = y;
                        find = true;
                    }
                    else if (x != p.X && y != p.Y && Drwa)
                    {
                       // Console.WriteLine("in elif ");
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
               // Console.WriteLine("ADD POINT");
                foreach (var item in points)
                {
                   // Console.WriteLine("P.X {0} P.Y {1}", item.X, item.Y);
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
                        //Console.WriteLine("HHHHHH");
                        return;
                       
                    }
                }

                points[k] = new Point(x, y);

                //Vertices[k] = new Node();
                //Vertices[k].CreatNode(x, y);
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
        
        public void ConvertTOLineCordinate(ref int x, ref int y)
        {
            int new_x = x / W_Space;
            int new_y = y / H_Space;

            
            int x_center = new_x * W_Space + Convert.ToInt32(0.5 * W_Space) - 15;
            int y_center = new_y * H_Space + Convert.ToInt32(0.5 * H_Space) - 12;

            Console.WriteLine("X center  : {0} ", x_center);
            Console.WriteLine("Y center  : {0} ", y_center);
            x = x_center;
            y = y_center;



        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            int new_x = MouseCordinate.X / W_Space;
            int new_y = MouseCordinate.Y / H_Space;

            int x_center = new_x * W_Space + Convert.ToInt32(0.5 * W_Space) - 15;
            int y_center = new_y * H_Space + Convert.ToInt32(0.5 * H_Space) - 12;



            if (!chxDrwaLine.Checked)
            {
                
                int i = 0;

                foreach (var item in N)
                {
                    

                    if (x_center == item._X && y_center == item._Y)
                    {
                        if (!Selected_point)
                        {
                            Selected_point = true;
                            index_of_selectedPoint = i;
                        }
                        else Selected_point = false;
                       
                       
                        
                    }
                    i++;
                }

                if (!Selected_point)
                {
                    N.Add(new Node(x_center, y_center, pictureBox1));
                    
                }
                       

               
               
            }
            else
            {
                foreach (var item in N)
                {   
                    

                    if (x_center == item._X && y_center == item._Y)
                    {
                        item.L.BackColor = Color.Green;
                        item.Degree++;
                        Line.Add(new node(new Point(x_center+10, y_center+10),item.id));
                        
                        //Line.Add(new Point(x_center+12, y_center+12));
                        break;
                    }

                   
                }
            }
        }
       

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseCordinate = pictureBox1.PointToClient(Cursor.Position);
            Console.WriteLine("selected0 {0}", Selected_point);
            int X = MouseCordinate.X;
            int Y = MouseCordinate.Y;
            Console.WriteLine("X befor : {0}", X);

            Console.WriteLine("Y befor : {0}", Y);

            ConvertTOLineCordinate(ref X,ref Y);
           
          
            Console.WriteLine("X after : {0}", X);

            Console.WriteLine("Y after : {0}", Y);
            if (Selected_point)
            {
                N[index_of_selectedPoint].L.BackColor = Color.Green;
            }
            
                


            if (chxDrwaLine.Checked)
            {
                if (Line.Count >= 2)
                {   
                    t.DrawLine(P, Line[0].p, Line[1].p);
                    adjacencyList.addEdgeAtEnd(Line[0].index, Line[1].index, 0);
                    adjacencyList.addEdgeAtEnd(Line[1].index, Line[0].index, 0);
                    AdjMatrix[Line[0].index, Line[1].index] = true;
                    AdjMatrix[Line[1].index, Line[0].index] = true;
                    Line.Clear();
                }
                foreach (var item in N)
                {   
                    
                    if (X == item._X && Y == item._Y)
                    {
                        item.L.BackColor = Color.Red;
                    }
                    else
                    {
                        item.L.BackColor = Node.defaultBackColor;
                    }
                }
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
               //pictureBox1.Invalidated();
            }
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

        

        private void button2_Click(object sender, EventArgs e)
        {

            //dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" {0} : ",i);
                for (int j = 0; j < 10; j++)
                {   
                    Console.Write(AdjMatrix[i, j] + "  ");

                }
                Console.WriteLine();
                
            }


            for (int i = 0; i < AdjMatrix.GetLength(0); i++)// array rows
            {
                string[] row = new string[AdjMatrix.GetLength(1)];

                for (int j = 0; j < AdjMatrix.GetLength(1); j++)
                {
                    row[j] =Convert.ToInt32( AdjMatrix[i, j]).ToString();
                }

                dataGridView1.Rows.Add(row);
            }
            
        }
        private void InciMatrix()
        {
            int edges = 0;
            for (int i = 0; i < AdjMatrix.GetLength(0); i++)
            {
                for (int j =i+1; j < AdjMatrix.GetLength(0); j++)
                {
                    if (AdjMatrix[i, j] == true)
                    {
                        if (AdjList[i] == null)
                        {
                            AdjList[i] = new LinkedList<int>();
                        }
                        if (AdjList[j] == null)
                        {
                            AdjList[j] = new LinkedList<int>();
                        }
                        AdjList[i].Append(j);
                        AdjList[j].Append(i);
                        
                        IncMatrix[i, edges] = 1;
                        IncMatrix[j, edges] = 1;
                        edges++;
                    }
                    
                }

            }
        }
        private void btn_Incidence_Click(object sender, EventArgs e)
        {
            InciMatrix();

            for (int i = 0; i < IncMatrix.GetLength(0); i++)// array rows
            {
                string[] row = new string[IncMatrix.GetLength(1)];

                for (int j = 0; j < IncMatrix.GetLength(1); j++)
                {
                    row[j] = IncMatrix[i, j].ToString();
                }

                dataGridView2.Rows.Add(row);
            }
        }

        private void btnAdjLIst_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write(i);
            //    Console.Write("{0} :", AdjList[i]);



            //    foreach (var item in AdjList[i])
            //    {
            //        Console.Write("{0} -->", i);
            //        Console.Write("{0} -->", item);
            //    }
            //    Console.WriteLine();

            //}


            adjacencyList.printAdjacencyList();


            //foreach (var item in AdjList)
            //{
            //    Console.Write("{0} : ", item);
            //    if (item != null)
            //    {


            //        foreach (var x in item)
            //        {
            //            Console.Write("{0} --> ", x);
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}
