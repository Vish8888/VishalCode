using System.Drawing;

class Program
{
    static void Main()
    {
        Console.WriteLine("------Todays Menu-------");
        Console.WriteLine("Vadapav \n Samosa \n tea \n coffee");

        int TotalBill = 0;
        string choice = "";
        int totalVadapav = 0, totalSamosa = 0, totalTea = 0, totalCoffee = 0;

        do
        {
            Console.WriteLine("What do you like to order ?");
            string Order = Console.ReadLine();


            switch (Order.ToUpper())
            {
                case "VADAPAV":
                    Console.WriteLine("How many Vadapav");
                    int tw = int.Parse(Console.ReadLine());
                    totalVadapav += tw;
                    break;

                case "SAMOSA":
                    Console.WriteLine("How many Samosa");
                    int ts = int.Parse(Console.ReadLine());
                    totalSamosa += ts;
                    TotalBill += 12;
                    break;

                case "TEA":
                    Console.WriteLine("How many Tea");
                    int tt = int.Parse(Console.ReadLine());
                    totalTea += tt;
                    TotalBill += 5;
                    break;

                case "COFFEE":
                    Console.WriteLine("How many Coffee ?");
                    int tc = int.Parse(Console.ReadLine());
                    totalCoffee += tc;
                    TotalBill += 25;
                    break;

                default:
                    Console.WriteLine("orderd Nothing");
                    break;
            }

            Console.WriteLine("Do you want to continue");
            choice = Console.ReadLine().ToUpper();
        } while (choice == "Y" || choice == "YES");

        if (totalVadapav > 0 || totalSamosa > 0 || totalTea > 0 || totalCoffee > 0)
        {
            Console.WriteLine("*************TotalBill RECEIPT*************");
        }


        if (totalVadapav > 0)
        {
            Console.WriteLine($"Vadapav:{totalVadapav} x 20 = {totalVadapav * 20}");
            TotalBill += totalVadapav * 20;
        }
        if (totalSamosa > 0)
        {
            Console.WriteLine($"Samosa:{totalSamosa} x 15 = {totalSamosa * 15}");
            TotalBill += totalSamosa * 15;
        }
        if (totalCoffee > 0)
        {
            Console.WriteLine($"Coffee:{totalCoffee} x 25 = {totalCoffee * 25}");
            TotalBill += totalCoffee * 25;
        }
        if (totalTea > 0)
        {
            Console.WriteLine($"Tea:{totalTea} x 5 = {totalTea * 5}");
            TotalBill += totalTea * 5;
        }
        if (TotalBill > 0)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Total Bill Amount: {TotalBill}");
        }
        else
        {
            Console.WriteLine(" No Bill");
        }
        Console.WriteLine("Thank You Visit Again........");
        Console.ReadLine();
    }
}