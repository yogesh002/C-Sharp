using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortProject
{
    class BubbleSorter
    {
        public static void SortArray<T>(IList<T> listOfObj, Func<T, T, bool> comparision)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < listOfObj.Count - 1; i++)
                {
                    if (comparision(listOfObj[i + 1], listOfObj[i]))
                    {
                        T temp = listOfObj[i+1];
                        listOfObj[i + 1] = listOfObj[i];
                        listOfObj[i] = temp;
                        swapped = true;

                    }
                }

            }
            while (swapped);
        }
    }
}
