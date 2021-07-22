using System;
//Bijan Amirzadehasl

class ATM
{
    //create a class called Account
    class Account
    {
       //variables for Account class
        private string accountNumber;
        private string pin;
        private double balance;

        //getters for Pin and Balance
        public String Pin
        {
            get { return pin; }
        }

        public Double Balance
        {
            get { return balance; }
        }

        //Constructor that takes in parameters of accountNumber, pin and balance
        public Account(string accountNumber, string pin, double balance)
        {
            //if statement that checks if initialized account number is 10 characters long
            //i couldnt figure out how to do this with a double as 000000000 equates to 0
            if (accountNumber.Length != 10)
                Console.WriteLine("The account number should be 10 digits long.");

            //if statement that checks that a pin is atleast 4 characters long and displays an error message
            if (pin.Length != 4)
                Console.WriteLine("The PIN should be 4 digits long.");

            //if statement that makes sure the initialized balance is greater 0.
            if (balance < 0)
                throw new Exception("The balance cannot be negative.");

           // values assigned to this constructor 
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.balance = balance;
        }

        //deposit method
        public void Deposit(double depositAmount)
        {
            //if statement that checks to make sure the deposit is positive
            if (depositAmount <= 0)
                Console.WriteLine("Please enter a positive amount.");
            else
            {
                //else statement that adds depositAmount to this balance
                this.balance = this.balance + depositAmount;
                Console.WriteLine("The amount is deposited.");
            }
        }

        //withdraw method
        public void Withdraw(double withdrawalAmount)
        {
            //initialize variable that calculates transaction fees
            double transactionFees = withdrawalAmount * .04;

            //initialize variable to calculate the total amount to be withdrawn
            double totalAmountToWithdraw = withdrawalAmount + transactionFees;

            //if statement to warn user insufficent funds
            if (totalAmountToWithdraw > balance)
                Console.WriteLine("Insufficent funds for transaction.");
            else
            {
                //end of if statement to subtract the amount from the current balance.
                this.balance = this.balance - totalAmountToWithdraw;
                Console.WriteLine("The amount is withdrawn.");
            }
        }
    }
    public static void Main(string[] args)
    {
       
            //create 3 accounts that accepts parameters for the account number, pin and balance
            Account a1 = new Account("2039485864", "4200", 75000);
            Account a2 = new Account("4444444444", "0123", 646000);
            Account a3 = new Account("1834982009", "2345", 1000300);

            //Store the three initialized accounts in an array to later loop through per assignment requirements
            Account[] accounts = new Account[] { a1, a2, a3 };

            //initialzing variables to use them later
            string pin = "";
            double depositAmount = 0;
            double withdrawalAmount = 0;
            string acceptTransactionFees = "y";

            //loop that will go through three times
            for (int i = 0; i < accounts.Length; i++)
            {
                //prompt user for the pin
                Console.WriteLine("\nAccount # {0}", i + 1);
                Console.Write("Enter PIN: ");
                pin = Console.ReadLine();

                //if statement that checks to see if Pin is correct
                if (pin == accounts[i].Pin)
                {
                    //prompts the user for amount they want to deposit
                    Console.Write("Enter amount to be deposited: ");
                    depositAmount = Convert.ToDouble(Console.ReadLine());

                    //calling the deposit method and passing the depositAmount parameter 
                    accounts[i].Deposit(depositAmount);
                   
                    Console.WriteLine("Balance: {0}", accounts[i].Balance.ToString("0.00"));

                    //Prompt the user for the amount to be withdrawn
                    Console.Write("Enter amount to be withdrawn: ");
                    withdrawalAmount = Convert.ToDouble(Console.ReadLine());


                    //notice that the user will have a transaction fee for their withdrawal
                    Console.Write("There will be a 4% transaction fees, Press y to accept: ");
                    acceptTransactionFees = Console.ReadLine();

                        //if statement that checks the user accepts the fees with y or uppercase Y
                    if (acceptTransactionFees == "y" || acceptTransactionFees == "Y")
                    {
                        //calling the withdraw method from the Account class
                        accounts[i].Withdraw(withdrawalAmount);
                        Console.WriteLine("Balance: {0}", accounts[i].Balance.ToString("0.00"));
                    }
                }
                //if pin is not correct, display an error message
                else
                    Console.WriteLine("PIN is not valid");
            }
        Console.ReadKey();
    }
       
        
    }



