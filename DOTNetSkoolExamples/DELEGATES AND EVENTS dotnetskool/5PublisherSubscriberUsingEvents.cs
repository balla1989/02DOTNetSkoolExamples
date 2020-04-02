//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualBasic;

//namespace DOTNetSkoolExamples
//{

//    public delegate void Transformer(int x);


//    public class Program
//    {

//        static void Main(string[] args)////FRONT END
//        {
//            Console.WriteLine("Enter a number");
//            int i = int.Parse(Console.ReadLine());


//            Transformer t = Square;
//            t += Cuber;
//            //t -= Cuber;
//            t.Invoke(i);



//            NotificationOfMethods obj = new NotificationOfMethods();
//            obj.transformerEvent += Subscriber1.Xhandler;
//            obj.transformerEvent += Subscriber2.Yhandler;//You can just subscribe or unsubscribe the event by += or -= operators and nothing else
//                                                         //Cannot use only = 
//                                                         //the moment we used "event" keywork in the delegates we prevented subscibers inter
//                                                         //ference with other subscribers
//                                                         //obj.transformerEvent(i);
//            obj.NotifyOnCell(i);
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


//    }

//    public class NotificationOfMethods
//    {
//        public event Transformer transformerEvent;//this delegate instance will be responsible for notifying the subscribers



//        public void NotifyOnCell(int x)
//        {
//            if (transformerEvent != null)
//            {
//                transformerEvent(x);
//            }
//        }


//    }


//    class Subscriber1
//    {
//        public static void Xhandler(int x)
//        {
//            Console.WriteLine("\nEvent Received by subscriber1");
//        }
//    }
//    class Subscriber2
//    {
//        public static void Yhandler(int x)
//        {
//            Console.WriteLine("\nEvent Recived by subscriber2");
//        }
//    }
//}
