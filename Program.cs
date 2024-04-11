

namespace Encapsulation
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            BeerEncapsulator Bottles = new BeerEncapsulator();

           

            

            while (true) {
               
                Console.WriteLine("How many Bottles do you want to produce ?");
                string bottlesNb = Console.ReadLine();
                if (bottlesNb == "q") { 
                  Environment.Exit(0); 
                }
                int bottles = int.Parse(bottlesNb);

                Bottles.ProduceEncapsulatedBeerBottles(bottles);

            }


        }
       
    }
}
