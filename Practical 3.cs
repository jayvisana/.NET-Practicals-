using System;

namespace Practical2
{
    class Expense
    {
        public int expenseId;
        public string expenseName;
        public DateTime expenseDate;
        public double amount;

        public Expense()
        {
            Console.WriteLine("Expense Object Created");
        }

        public void GetDetails()
        {
            Console.Write("Enter Expense ID: ");
            expenseId = int.Parse(Console.ReadLine());

            if (expenseId <= 0)
                throw new ArgumentException("Expense ID must be greater than 0.");

            Console.Write("Enter Expense Name: ");
            expenseName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(expenseName))
                throw new ArgumentNullException("Expense Name", "Expense Name cannot be empty.");

            Console.Write("Enter Expense Date (dd/MM/yyyy): ");
            expenseDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            if (expenseDate > DateTime.Now)
                throw new ArgumentOutOfRangeException("Expense Date", "Expense Date cannot be in the future.");

            Console.Write("Enter Expense Amount: ");
            amount = double.Parse(Console.ReadLine());

            if (amount <= 0)
                throw new ArgumentOutOfRangeException("Amount", "Expense Amount must be greater than zero.");

            if (amount > 1000000)
                throw new OverflowException("Expense Amount is too large.");
        }

        public void DisplayExpense()
        {
            Console.WriteLine("\nExpense Details");
            Console.WriteLine("Expense ID      : " + expenseId);
            Console.WriteLine("Expense Name    : " + expenseName);
            Console.WriteLine("Expense Date    : " + expenseDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Expense Amount  : " + amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Expense exp = new Expense();

            try
            {
                exp.GetDetails();
                exp.DisplayExpense();
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid format! Please enter numbers where required and date in dd/MM/yyyy format.");
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("\nExpense Tracking Completed.");
            }

            Console.ReadKey();
        }
    }
}