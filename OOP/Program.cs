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

            /*CAN USE THIS EXAMPLE LATER, IF NEEDED
            NormalMember normalMember = new NormalMember("Special Rate", "James", 1, 2010);
            VIPMember vipMember = new VIPMember("Andy", 2, 2011);

            normalMember.CalculateAnnualFee();
            vipMember.CalculateAnnualFee();
            Console.WriteLine(normalMember.ToString());
            Console.WriteLine(vipMember.ToString());
            Console.ReadKey();
            */

            Member[] clubMembers = new Member[5]; // don't need separate arrays for each child object

            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
                Console.ReadKey();
            }

        }
    }
}
