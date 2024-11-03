 using System;
 namespace Calci{
 class Divison{
            public static int divide(int a,int b){
                try{
                    return a/b;
                }
                catch(DivideByZeroException ex){
                    Console.WriteLine(ex);
                    throw;
                }
                catch(ArithmeticException ex){
                    Console.WriteLine(ex);
                    throw;
                }
                
                
            
        }
 }
 }