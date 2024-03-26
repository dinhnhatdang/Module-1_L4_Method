using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_L4_Method
{
    internal class Program
    {
        //Phuong thuc có giá trị trả về
        //public static int Tong(int a, int b) 
        //{
        //    return a + b;
        //}

        public static int Hieu(int n, int m)
        {
            int KetQua = n - m;
            return KetQua;
        }
        //Phương thúc ko có giá trị trả về
        public static void HienThiTen(string ten) => Console.WriteLine("Tên của bạn là: {0}", ten); 

        public static void Sum(int x, int y)
        {
            int kq = x + y;
            Console.WriteLine("Tong la {0}", kq);
        }


        public static double TimX(int a, int b, int y)
        {
          return (y - b) /(double) a;
        }
        static void Main(string[] args)
        {
            //int c = Tong(1, 2);
            //Console.WriteLine(c);
            //////////
            HienThiTen("Nhật");

            /////
            Sum(1, 2);
            //

            Console.WriteLine(Hieu(4, 2));


          int a = 4; int b = 5;int y = 8;
            double x = TimX(a, b, y);
            Console.WriteLine(x);

            Console.ReadKey();

        }
    }
}
