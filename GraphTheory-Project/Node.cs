using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphTheory_Project
{

    class Node
    {

        
        Graphics G;
        Pen P;
        public PictureBox Picture;

        int X;
        int Y;
        public Label L;
        int wieght;
        public int Degree =0;
        public static Color defaultBackColor;
        public int id;
        static public int index = 0;
        public Node (int x , int y,PictureBox p)
        {
            X = x;
            Y = y;
            Picture = p;
            P = new Pen(Color.Blue, 3);
            G = p.CreateGraphics();
            CreatNode(x, y);

        }

        public Node(PictureBox p,int x,int y)
        {
            X = x;
            Y = y;
            Picture = p;
            L = new Label();
            L.Location = new Point(x + 7, y + 7);
            L.Name = index.ToString();
            L.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Underline);
            L.Size = new Size(13, 13);
            L.Text = Convert.ToString(index);
            L.TabIndex = 3;
            Picture.Controls.Add(L);
        }
        public int _X { get { return X; } }
        public int _Y { get { return Y; } }

        public void CreatNode(int x,int y)
        {
            X = x;
            Y = y;
            id = index;
            G.DrawEllipse(P, x, y, 25, 25);
            
            L = new Label();
            L.Location = new Point(x+7, y+7);
            L.Name = index.ToString();
            L.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Underline);
            L.Size = new Size(13, 13);
            L.Text = Convert.ToString(index);
            L.TabIndex = 3;
            Picture.Controls.Add(L);
            index++;
            defaultBackColor= L.BackColor;

        }

       
    
    }
}
