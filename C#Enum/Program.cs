namespace C_Enum
{

    enum Beverage
    {
        Coffee, 
        Tea,
        Water,
        Soda,
        Juice
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            //Enum:
            // Enummeration:
            // 
            Console.WriteLine("Welcomne to the awsome vending machine!");
            Console.WriteLine("Which beverage do you prefer?(Coffee, Tea, Water, Soda or Juice)");
            string userInput = Console.ReadLine();

            switch(userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee);
                    break;
                case "tea":
                    Respond(Beverage.Tea);
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice":
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("invalid input, this drink does not exist!");
                    break;
            }
        }

        static void Respond(Beverage drink)
        {
            switch(drink)
            { 
                case Beverage.Coffee:
                    Console.WriteLine("You ordered Kaffe Latte");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("You ordered Tea")
;                   break;
                case Beverage.Water:
                    Console.WriteLine("You ordered water!");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("You ordered Coca Cola");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("You ordered applejuice");
                    break;
            }
        }

    }
}

            //GITHUB:
            //1. Stagea förrändringar pennan och tryck på +
            //2. Commita. skriv kommentar och commit knappen
            //3. Pusha med uppåt pilen  
            //4. Klart 