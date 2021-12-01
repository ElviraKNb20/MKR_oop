using System;

namespace MKR_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square();
            s1.side = 5;
            s1.type = "quadrate";
            s1.DrawType();
            s1.DrawSquare();
        }
    }
    public interface IShape
    {
        void DrawType();
        void DrawSquare();
    }
    public class Square : IShape
    {
        public string type;
        public int side;
        public void DrawType()
        {
            Console.WriteLine("This is: " + type);
        }
        public void DrawSquare()
        {
            Console.WriteLine("Square equal: " + side*side);
        }
    }
}
