using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace{
    public class ConvertType{
        public static void myConvertType(){
            // create sting veriable
            string str = "987.654321";
            Console.WriteLine("Original string velue:"+str);

            // convert string to double
            Double newDouble = Convert.ToDouble(str);
            Console.WriteLine("Converted Double value:"+newDouble);

            // create double variable
            double num = 98.7;
            Console.WriteLine("Original double velue:"+num);

            // convert double to string
            string newString = Convert.ToString(num);
            Console.WriteLine("Converted string velue:"+str);


        }

    }
}


// namespace ConsoleApp1 {
//     public class Program{
//         public static void Main(string[] args){ 
//            MyNamespace.ConvertType.myConvertType();
//            Console.ReadLine();
//         }
//     }
// }