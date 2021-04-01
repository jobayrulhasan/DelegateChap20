using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap20Delegate
{
    class Program
    {
        public delegate void MyDelegate(string message); //delegate is onekind of method type.It has no body.
        public static void MyMethod(string voice)
        {
            Console.WriteLine(voice);
        }
        static void myMethodCallBack(int param1 ,int param2, MyDelegate callBack)
        {
            callBack("number is :" + (param1 + param2).ToString());

        }
        static void Main(string[] args)
        {
            MyDelegate handle = MyMethod; //Call by handle
            handle ("Dhaka is the capital city of Bangladesh");
            myMethodCallBack(2, 4, handle); //Call by callback
            Console.ReadKey();
        }
        
    }
}
