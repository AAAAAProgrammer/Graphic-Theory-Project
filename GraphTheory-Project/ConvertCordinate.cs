using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory_Project
{
    class ConvertCordinate
    {
        int Width;
        int Height;
        double Lines;

       public ConvertCordinate(int Width , int Height) 
        {
            this.Width = Width;
            this.Height = Height;
        }

        public  void ConvertTOLineCordinate(ref int x,ref int y)
        {
            int new_x = x/ Width;
            int new_y = y / Height;

            //Console.WriteLine("MouseCordinate : {0}", MouseCordinate);
            //Console.WriteLine("W_Space : {0}", W_Space);
            //Console.WriteLine("new_x : {0}", new_x);

            int x_center = new_x * Width + Convert.ToInt32(0.5 * Width) - 15;
            int y_center = new_y * Height + Convert.ToInt32(0.5 * Height) - 12;

            Console.WriteLine("X center  : {0} ", x_center);

            x = x_center;
            y = y_center;
            


        }




    }
}
