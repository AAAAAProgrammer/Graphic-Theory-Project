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
        int X;
        int Y;
        System.Windows.Forms.Label L;
        int wieght;
        int Degree;
        static int index = 0;
        public Node ()
        {

        }

        public int _X { get; }
        public int _Y { get; }

        public void CreatNode(int x,int y)
        {
            X = x;
            Y = y;

            index++;
            L = new Label();
            L.Location = new Point(x, y);
            L.Name = index.ToString();
            L.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Underline);
            L.Size = new Size(13, 13);
            L.Text = Convert.ToString(index);
            L.TabIndex = 3;
        }

       
    
    }
}
