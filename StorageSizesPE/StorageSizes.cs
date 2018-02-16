using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSizesPE
{
    class StorageSizes
    {
            public List<decimal> allMBs = new List<decimal>();


            public void addMB(string stringIn)
            {
                //converts string to decimal, adds converted string to List
                allMBs.Add(decimal.Parse(stringIn));
            }

            //makes new list, sorts it, then returns it
            public List<decimal> sortMBs()
            {
                List<decimal> sortedMBs = allMBs;
                sortedMBs.Sort();

                return sortedMBs;
            }

            //finds biggest number in list
            public decimal maxList()
            {
                decimal max = allMBs[0];
                foreach (int i in allMBs)
                    max = (max < i) ? i : max;

                return max;
            }

            //finds smallest num in list
            public decimal minList()
            {
                decimal min = allMBs[0];
                foreach (int i in allMBs)
                    min = (min > i) ? i : min;

                return min;
            }

            //gets list average
            public double avgList()
            {
                return (double)totalList() / allMBs.Count();
            }

            //gets total of all list items added together
            public int totalList()
            {
                int total = 0;
                foreach (int i in allMBs)
                    total += i;

                return total;
            }
        }
    }
