using System;
//Bijan Amirzadehasl 07/05/2021
namespace AccountInheritance
{
    //account class should have an Amount property, Calculateinterest methodand Balance method.
    class Account
    {
        public double Amount {get; set;}

        public void CalculateInterest(double intRate)
        {
            double interest = 0;
            interest = (Amount * (intRate / 12)) / 100;
            Amount = Amount + interest;

        }

        public double Balance()
        {
            return Amount;
        }

    }

    class Credit : Account
    {
        public double InterestRate { get; set; }

        public Credit(double rate)
        {
            InterestRate = rate;

        }
    }

    class Banking : Account
    {
        public double InterestRate { get; set; }

        public Banking(double rate)
        {
            InterestRate = rate;
        }
    }

    class Checking : Banking
    {
        public Checking(double rate) : base(rate)
        {

        }
    }

    class Savings : Banking
    {
        public Savings(double rate) : base(rate)
        {

        }
    }
    class PremiumSavings : Savings
    {
        public PremiumSavings(double rate) : base(rate)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //step 6
            Account premSav = new PremiumSavings(0.9);
            Account savings = new Savings(0.2);
            Account checking = new Checking(0.05);
            Account credit = new Credit(15);

            //step 7 create an array of accounts and add an instance of each account with the exception of banking
            Account[] accounts = { premSav, savings, checking, credit };

            //foreeach loop to loop through array above
            foreach (Account acc in accounts)
            {
                var type = acc.GetType();
                Console.WriteLine("Account Type: " + type.Name);
                acc.Amount = Program.GetRandomAmount(new Random());
                Console.WriteLine("Initial Amount: $" + acc.Amount);
               
                //switch statement to calculate account type and specific interest rate
                switch (type.Name.ToUpper())
                {

                    case "PREMIUMSAVINGS":
                        acc.CalculateInterest((acc as PremiumSavings).InterestRate);
                        break;

                    case "SAVINGS":
                        acc.CalculateInterest((acc as Savings).InterestRate);
                        break;

                    case "CHECKING":
                        acc.CalculateInterest((acc as Checking).InterestRate);
                        break;

                    case "CREDIT":
                        acc.CalculateInterest((acc as Credit).InterestRate);
                        break;

                    default:
                        break;

                }

                Console.WriteLine("Final Balance after interest: $" + acc.Balance());
                Console.WriteLine("");

            }
            Console.ReadKey();
        }

        //method used to generate a number between 1000-2000
        public static int GetRandomAmount(Random random)
        {
            return random.Next(1000, 2000);
        }

    }
    }

