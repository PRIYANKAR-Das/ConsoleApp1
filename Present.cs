using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Present
    {
        public Nullable<int> num10;
        public int num11;
        static void Main(string[] args)
        {
            // What if we try to set null value to an int ?
            //int num1 = null;

            //Nullable<int> num2 = null; //Works

            // Various types of nullable types

            /*
            int? num3 = 1;
            Console.WriteLine(num3);
            Console.ReadKey();

            float? num4 = 2.5f;
            Console.WriteLine(num4);
            Console.ReadKey();

            double? num5 = 3.27;
            Console.WriteLine(num5);
            Console.ReadKey();
            */

            // null-coalescing operator ??

            /*
            int? num6 = 1;
            int? num7 = 2;
            int? num8 = 3;

            int? num9 = num6 ?? num7 ?? num8;
            Console.WriteLine(num9);
            */

            // Every Nullable<T> has .HasValue property

            /*
            Console.ReadKey();

            bool? b = false;
            Console.WriteLine(b.HasValue);
            Console.ReadKey();

            b = null;
            Console.WriteLine(b.HasValue);
            Console.ReadKey();

            b = true;
            Console.WriteLine(b.HasValue);
            */

            // Nullable instance variable

            /*
            Console.ReadKey();

            Present obj = new Present();

            Console.WriteLine(obj.num11);
            Console.ReadKey();

            Console.WriteLine(obj.num10.HasValue);

            Console.ReadKey();
            */

            // Why use nullable ? Real-world example
            // Suppose we want to create a voting app
            // We can easily represent who voted yes and who voted no using bool
            // But how can we represent who did not give any vote ?

            Console.WriteLine("Press 1 for Yes");
            Console.WriteLine("Press 2 for No");
            Console.WriteLine("Press any other for Neutral");

            Console.WriteLine("Enter the total number of voters: ");

            int n = int.Parse(Console.ReadLine());

            Nullable<bool>[] voters = new Nullable<bool>[n];

            int totalYes = 0;
            int totalNo = 0;
            int totalNeutral = 0;

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Choice: ");
                // get int as response
                int response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    voters[i] = true;
                    totalYes += 1;
                }
                else if (response == 2)
                {
                    voters[i] = false;
                    totalNo += 1;
                }
                else
                {
                    voters[i] = null;
                    totalNeutral += 1;
                }
            }

            double percentWon = ((double)totalYes / n) * 100;

            if (percentWon > 60)
            {
                Console.WriteLine("Won");
            }
            else
            {
                Console.WriteLine("Lost");
            }

            Console.WriteLine("Summary: ");
            Console.WriteLine("Yes%: " + percentWon);
            Console.WriteLine("Yes: " + totalYes);
            Console.WriteLine("No: " + totalNo);
            Console.WriteLine("Neutral: " + totalNeutral);

            Console.ReadKey();
        }
    }
}
