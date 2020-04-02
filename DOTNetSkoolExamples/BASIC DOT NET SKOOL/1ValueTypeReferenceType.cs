//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualBasic;
//using System.Threading;
//using DOTNetSkoolExamples.EVENTS_AND_DELEGATES_YOUTUBE_MOSH;

//namespace DOTNetSkoolExamples
//{
//    //30/10/2019 5 pm

//    //int,long,float, struts are Value type
//    //String is a reference type. so is an object

//    //Value type stored on Stack
//    // References are actually stored on stack but the objects they referis stored on Heap
//    //When we update a value type it creates a new copy of the variable
//    //When we update a reference type both the references will refer to the same object.

//    public class Utility
//    {
//        public int firstValue;
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //_________________________________________value type_______________________________________________//
//            int firstValue = 5; //value type(int long float )
//            int secondVale = firstValue; // value type
//            Console.WriteLine("first value = " + firstValue + " Second value = " + secondVale);

//            secondVale = 10;//updated the copy of second value, 2 copies
//            Console.WriteLine("first value = " + firstValue + " Second value = " + secondVale);

//            //_________________________________________value type_______________________________________________//




//            //_________________________________________Reference Type_______________________________________________//
//            Utility obj1 = new Utility();
//            obj1.firstValue = 10;
//            Utility obj2 = obj1;
//            Utility obj3 = obj2;
//            Console.WriteLine(" Value of object is " + obj1.firstValue + " " + "Value of object 2 is " + obj2.firstValue + " Value of 3rd object = " + obj3.firstValue);
//            obj2.firstValue = 25;//We changed only obj2.firstValue but it also update obj1.firstValue coz its a reference type//
//                                 // we are not copying obj1 to obj2 but they are both same object
//                                 //both obj1 and obj2 are references to the same object//
//            Console.WriteLine(" Value of object is " + obj1.firstValue + " " + "Value of object 2 is " + obj2.firstValue + " Value of 3rd object = " + obj3.firstValue);
//            Console.ReadLine();
//            //_________________________________________Reference Type_______________________________________________//

//        }






//    }
//}
