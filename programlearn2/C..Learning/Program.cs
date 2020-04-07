using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._.Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canVote = true;

            char grade = 'A';

            //integer w/ max num of 2,147,483,647
            int maxInt = int.MaxValue;

            //long w/ maximum value of 7,376,347,985,347,532,937
            long maxLong = long.MaxValue;

            //Decimal has maximum value of 79,543,287,348,534,254,765,427,357,432,467,897,447
            //if you need something bigger, look up BigInteger
            decimal maxDec = decimal.MaxValue;

            //a float is a 32 bit num w/ maxValue of 3.4927678E+38 w/ 7 decimals of precision
            float maxFloat = float.MaxValue;

            //a float is a 32 bit num w/ maxValue of 1.4567738822E+308 w/ 15 decimals of precision
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int:" + maxInt);

            //var stands for varible, use var to make separate varibles
            var anotherName = "Tom";
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());



        }
    }
}
