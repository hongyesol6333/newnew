using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 넓이를 입력하세요");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("사각형의 넓이를 입력하세요");
            int hight = int.Parse(Console.ReadLine());

            //Console.WriteLine("사각형의 넓이는 : " + width*hight + "입니다.");
            Console.WriteLine("사각형의 넓이는 : { hight } 입니다.");
        }
    }
}
