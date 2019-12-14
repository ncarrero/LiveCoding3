using System;
using System.Collections.Generic;

namespace LiveCoding3
{
    //Zip Arrays
    //in this problem you are given 2 arrays of identical size
    //you need to zip the two arrays together maintaining their order
    //example:
    //array one = [1, 5, 2]
    //array two = [3, 6, 4]
    //zipped array = [1, 3, 5, 6, 2, 4]
    class Program
    {
        static void Main(string[] args)
        {
            //create first list
            List<int> one = new List<int>();
            one.Add(1);
            one.Add(5);
            one.Add(2);

            //create second list
            List<int> two = new List<int>();
            two.Add(3);
            two.Add(6);
            two.Add(4);

            //create third list for zipped array
            List<int> three = new List<int>();

            //loop through each list and add same index integer from each list
            //TODO: fix loop body
            for (int i = 0; i < (one.Count); i++)
            {
                three.Add(one[i]);
                three.Add(two[i]);
            }

            Console.WriteLine(three.ToString());

            Console.ReadLine();
        }
    }
}
