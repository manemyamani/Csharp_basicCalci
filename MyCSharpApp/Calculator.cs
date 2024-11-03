using System;
using System.Collections.Generic;

namespace Calci
{
    class Calculator
    {
       
        public static void Main(string[] args)  
        {
            Console.WriteLine("enter the 2 operands");
            string? s1 = Console.ReadLine();  
            string? s2 = Console.ReadLine();  
            
            if (s1 != null && s2 != null)
            {
                int a=Convert.ToInt32(s1);
                int b=Convert.ToInt32(s2);
                Console.WriteLine("enter the operator");
                string? c=Console.ReadLine();
                if(c!=null){
                    char c1=Convert.ToChar(c);
                    int temp=0;
                switch(c){
                    case "+":
                    temp = Addition.add(a,b);
                     Console.Write("Addition of numbers "+a +" , "+b+"is : "+temp);
                     break;
                     case "-":
                     temp= Substraction.sub(a,b);
                     Console.Write("Substraction of numbers "+a+" , "+b+" is: "+temp);
                     break;
                     case "*":
                     temp= Multiplication.mul(a,b);
                     Console.Write("multipliction of numbers "+a+" , "+b+" is: "+temp);
                     break;
                    case "/":
                    temp= Divison.divide(a,b);
                     Console.Write("division of numbers "+a+" , "+b+" is: "+temp);
                     break;

                    default:
                    Console.WriteLine("nothing to calculate");
                    break;
                        

                }

              
                }
               

            }
            else
            {
                Console.WriteLine("No input received");
            } 
            
        //     List<Int32> inputs=new List<Int32>();
        //     string? input;
        //     while(true){
        //         input=Console.ReadLine();
        //         if(string.IsNullOrEmpty(input)){
        //             break;
        //         }
        //         inputs.Add(Convert.ToInt32(input));

        //     }
        //     for(int i=0;i<inputs.Count;i++){
        //         Console.Write(inputs[i]);
        //     }
        // }
    }
}
}