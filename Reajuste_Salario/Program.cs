using System;

namespace Reajuste_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste;
                      
            Console.WriteLine("Digite seu salario");
            salario = double.Parse(Console.ReadLine());
            if (salario < 200) 
            {
               Console.WriteLine("Sem reajuste");
            }
            else             
            {
                if(salario < 400)
                {
                    reajuste = salario * 1.20;
                    Console.WriteLine("Seu novo salario e {0}", reajuste);
                }
                else
                {
                    if (salario < 600)
                    {
                        reajuste = salario * 1.40;
                        Console.WriteLine("Seu novo salario e {0}", reajuste);
                    }
                    else
                    {
                        reajuste = salario * 1.60;
                        Console.WriteLine("Seu novo salario e {0}", reajuste);
                    }
                }
            }                           
        }
    }
}
