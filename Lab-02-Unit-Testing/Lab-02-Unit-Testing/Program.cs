using System;

namespace Lab_02_Unit_Testing
{
    public class Program
    {
        public static decimal StartingAmount = 1000;

        public static void Main(string[] args)
        {
            MainMenu();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("This is your Bank ATM. Please enter choices 1, 2, 3 or 4.");
            string userValue = Console.ReadLine();
            if (userValue == "1") Deposit();
            if (userValue == "2") Withdraw();
            if (userValue == "3") SeeBalance();
            if (userValue == "4") Exit();
            Console.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Deposit()
        {
            try
            {
                Console.WriteLine("How much would you like to deposit?");
                string userValue = Console.ReadLine();
                decimal value = Convert.ToDecimal(userValue);
                AddDeposit(value);
                Console.WriteLine($"You have deposited ${userValue}. Press any key to continue...");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Problem();
                throw (new Exception(e.Message));
            }
            finally
            {
                Console.WriteLine("You were in the deposit section");
                MainMenu();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal AddDeposit(decimal value)
        {
            if (value<0)
            {
                Console.WriteLine("You cannot negatively deposit.");
                return value;
            }
            else
            {
            StartingAmount = StartingAmount += value;
                return value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Withdraw()
        {
            try
            {
                Console.WriteLine("How much would you like to withdraw?");
                string userValue = Console.ReadLine();
                decimal value = Convert.ToDecimal(userValue);
                AddWithdraw(value);
                if (StartingAmount < 0)
                {
                    Console.WriteLine("You withdrew too much.");
                    Console.ReadLine();
                    MainMenu();
                }
            }
            catch (Exception)
            {
                Problem();
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static decimal AddWithdraw(decimal value)
        {
            StartingAmount = StartingAmount - value;
            return StartingAmount;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SeeBalance()
        {
            try
            {
                Console.WriteLine($"You have ${StartingAmount} at this time.");
                MainMenu();
            }
            catch (Exception)
            {
                Problem();
                MainMenu();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Exit()
        {
            try
            {
                Console.WriteLine("Have a nice day");
            }
            catch (Exception b)
            {
                Problem();
                throw (new Exception(b.Message));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Problem()
        {
            Console.WriteLine("Problem occurred...");
        }
    }
}
