using System;

namespace bai1
{
    class Diem
    {
        private double x;
        private double y;
        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y:");
            y = double.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Toa do la ({0},{1})", x, y);
        }
        public double Khoangcach( Diem b)
        {
            return Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));
        }
    }
    class APP
    {
        static void Main(string[] args)
        {
            Diem a = new Diem();
            a.Nhap();
            a.Hien();
            Diem b = new Diem();
            b.Nhap();
            b.Hien();
            Console.WriteLine("khoang cach la" + a.Khoangcach(b));
            Console.ReadKey();

        }
    }
}
