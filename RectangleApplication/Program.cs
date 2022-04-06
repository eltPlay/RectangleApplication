namespace RectangleApplication
{
    class Rectangle
    {
        //成员变量
        double length;

        double width;

        //构造函数
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("该矩形的长为: {0}", length);
            Console.WriteLine("该矩形的宽为: {0}", width);
            Console.WriteLine("该矩形的面积为: {0}", GetArea());
        }
    } //矩形类结束

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩形的长和宽:");
            double len = Convert.ToDouble(Console.ReadLine());
            double wid = Convert.ToDouble(Console.ReadLine());
            Rectangle r = new Rectangle(len, wid);
            r.Display();
            Console.ReadKey();
        }
    }
}