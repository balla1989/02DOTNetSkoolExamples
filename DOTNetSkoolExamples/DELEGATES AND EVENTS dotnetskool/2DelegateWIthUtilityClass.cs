//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DOTNetSkoolExamples
//{
//    public class Utility///not allowed to change this in big project. So need to change some where else and plug the funcionality to Utility class
//                        ///so it is expetected from you to plug the functionality of squaer and cuber during runtime which is possible with delegeate.
//                        ///THIS IS THE FRAMEWORK.
//                        ///soo soo back end

//    {
//        public delegate int Transformer(int x);//1 define a delegate
//        public static int Trasform(int x, Transformer t)// create a generalized method that can handle many other functions
//        {
//            return t(x);
//        }

//    }



//    class Program
//    {
//        delegate int Transformer(int x);
//        static void Main(string[] args)////FRONT END
//        {
//            Console.WriteLine("Enter a number");
//            int i = int.Parse(Console.ReadLine());


//            int j = Utility.Trasform(i, Square);// passing a method as a parameter to another function at runtime.
//            int k = Utility.Trasform(i, Cuber);
//            int l = Utility.Trasform(i, Powerfour);

//            Console.WriteLine(j.ToString() + k.ToString() + l.ToString());
//            Console.ReadLine();

//        }

//        public static int Square(int x)///backend
//        {
//            return x * x;
//        }

//        public static int Cuber(int x)//backend
//        {
//            return x * x * x;
//        }

//        public static int Powerfour(int x)//backend
//        {
//            return x ^ 4;
//        }
//    }
//}
