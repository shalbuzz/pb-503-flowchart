using System.ComponentModel.Design;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {






            
            Console.Write("Ededi yaz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            
            bool isPrime = true;

            
      
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false; 
                        break; 
                    }
                }
        
if(n == 1 && n == 0){
     Console.WriteLine("ne sade deyil nede murekkeb deyil");
}
            else{
            if (isPrime)
            {
                Console.WriteLine($"{n} - simple.");
            }
            else
            {
                Console.WriteLine($"{n} - complex.");
            }
            }








            int n1 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int mod = 0;

            while (n1 != 0)
            {
                mod = n1 % 10;
                n1 = n1 / 10;

                count++;
            }
            Console.WriteLine($"mertebenin sayi - {count}");




        }

    }


    }



