//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DOTNetSkoolExamples
//{



//    class Program
//    {
//        delegate void Transformer(int x);
//        static void Main(string[] args)////FRONT END
//        {
//            Console.WriteLine("Enter a number");
//            int i = int.Parse(Console.ReadLine());


//            Transformer t = Square;
//            t += Cuber;
//            t -= Cuber;
//            t.Invoke(i);


//            //Console.WriteLine(k);


//            Console.ReadLine();

//        }

//        public static void Square(int x)///backend
//        {
//            Console.WriteLine(x * x);
//        }

//        public static void Cuber(int x)//backend
//        {
//            Console.Write(x * x * x);
//        }

//        public static int Powerfour(int x)//backend
//        {
//            return x ^ 4;
//        }
//    }
//}
