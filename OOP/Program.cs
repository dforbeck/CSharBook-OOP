using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//TEST comment

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalMember normalMember = new NormalMember("Special Rate", "James", 1, 2010);
            VIPMember vipMember = new VIPMember("Andy", 2, 2011);

            normalMember.CalculateAnnualFee();
            vipMember.CalculateAnnualFee();
            Console.WriteLine(normalMember.ToString());
            Console.WriteLine(vipMember.ToString());
            Console.ReadKey();


        }
    }
}
