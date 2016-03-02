using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Comparator
    {
        List<string> items;

        public Comparator()
        {
            items = new List<string>();
        }

        public void addItem(string item)
        {
            items.Add(item);
        }

        public void run()
        {
            int size = items.Count;
            int[,] a = new int[size, size];
            int[] b = new int[size];

            
            // Fill with 5
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    a[i, j] = 5;
                }
            }

            int blanks = size * size;
            //Console.WriteLine("Blanks: " + blanks);

            // Fill in same items
            for (int i = 0; i < size; i++)
            {
                a[i, i] = 0;
                blanks--;
                b[i] = 0;
            }
            //Console.WriteLine("Blanks: " + blanks);

            Random rnd = new Random();
            int first = 0;
            int second = 0;
            string firstName = "";
            string secondName = "";
            int answer = 0;
            int nmb = 1;
            while (blanks > 0)
            {
                //Console.WriteLine("Blanks: " + blanks);
                first = rnd.Next(0, size);
                second = rnd.Next(0, size);
                //Console.WriteLine("First: " + first + " Second: " + second);
                if(a[first,second] == 5)
                {
                    firstName = items[first];
                    secondName = items[second];
                    Console.WriteLine("\n" + nmb + ".");
                    nmb++;
                    Console.WriteLine("Which is better: ");
                    Console.WriteLine("1. " + firstName);
                    Console.WriteLine("2. " + secondName);
                    answer = Convert.ToInt32(Console.ReadLine());
                    while(answer != 1 && answer != 2)
                    {
                        Console.WriteLine("Please type either 1 or 2");
                        Console.WriteLine("Which is better: ");
                        Console.WriteLine("1. " + firstName);
                        Console.WriteLine("2. " + secondName);
                        answer = Convert.ToInt32(Console.ReadLine());
                    }

                    if(answer == 1)
                    {
                        a[first, second] = 1;
                        a[second, first] = -1;
                    }
                    else
                    {
                        a[first, second] = -1;
                        a[second, first] = 1;
                    }

                    blanks--;
                    blanks--;

                    //Update table
                    for(int i = 0; i < size; i++)
                    {
                        for(int j = 0; j < size; j++)
                        {
                            // If left is better than right,
                            // Is right better than anything else?
                            if(a[i,j] == 1)
                            {
                                for(int k = 0; k < size; k++)
                                {
                                    // If j is better than k and i,k hasnt been filled yet
                                    if((a[j,k] == 1) && (a[i,k] == 5))
                                    {
                                        a[i, k] = 1;
                                        a[k, i] = -1;
                                        blanks--;
                                        blanks--;
                                        b[i]++;
                                    }
                                }
                            }
                        }
                    }

                }
                //Console.WriteLine("Blanks: " + blanks);
            }
            //Console.WriteLine("Blanks: " + blanks);
            //Console.WriteLine("Blanks == 0");

            for(int i = 0; i < size; i++)
            {
                //Console.WriteLine(items[i] + ": " + b[i]);
            }

            int[] counts = new int[size];
            int rowCount = 0;
            for(int i = 0; i < size; i++)
            {
                rowCount = 0;
                for(int j = 0; j < size; j++)
                {
                    if(a[i,j] == 1)
                    {
                        rowCount++;
                    }
                }
                counts[i] = rowCount;
            }

            int[] countsUnsorted = new int[size];
            int[] countsSorted = new int[size];

            for(int i = 0; i < size; i++)
            {
                countsUnsorted[i] = counts[i];
                countsSorted[i] = counts[i];
            }

            Array.Sort(countsSorted);
            Array.Reverse(countsSorted);

            Console.WriteLine("\n\n\n\nResults");

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(countsUnsorted[j] == countsSorted[i])
                    {
                        Console.WriteLine((i + 1) + ". " + items[j]); // + " count: " + countsUnsorted[j]);
                    }
                }
            }

            for(int i = 0; i < size; i++)
            {
                
                for(int j = 0; j < size; j++)
                {
                    //Console.Write("[" + a[i, j] + "]");
                } 
            }
        }



    }
}
