using System;

namespace Lab1
{
    class rectangle
    {
        static void Main(string[] args)
        {
            rectangle rect = new rectangle();
            mydelegate Rectangle = new mydelegate(rect.area);
            //Alternative
            //mydelegate Rectangle = rect.area;
            Rectangle += new mydelegate (rect.perimeter);
            //Alternative
            //Rectangle += rect.perimeter;
            Rectangle.Invoke(6.3, 4.5);
            Console.WriteLine();
            Rectangle.Invoke(15.5, 11.6);

        }
        //declaring delegate
        public delegate void mydelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: " + (width * height));
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: " + (2 *(width + height)));
        }
    }
}
