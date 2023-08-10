using System.Security.Principal;

namespace Encapsulation
{
    
    class SimCard
    {
        public string CarrierName { get; set; }
        public string Number { get; set; }
        public Decimal Balance { get; set; }
        public Decimal Tarif { get; set; }
        
        public void IncreaseBalance(Decimal amount)
        {
            if (amount<=0)
            {
                return;
            }
            Balance += amount;
        }
        
        public void Call(decimal amount)
        {
            if (Balance>=0) 
            {
                Console.WriteLine("You have not enought balance!");

                return;
            }
           Balance -= amount;
        }

    }
          
    
    internal class Program
    {
        static void Main(string[] args)
        {
           var simCard = new SimCard();

            simCard.CarrierName = "Azelcell";
            simCard.Number = "0513854544";
            simCard.Balance = 13m;
            simCard.Tarif = 0.10m;

            simCard.IncreaseBalance(0);
            Console.WriteLine(simCard.Balance);

            simCard.Call(15);
            Console.WriteLine(simCard.Balance);


        }
    }
}