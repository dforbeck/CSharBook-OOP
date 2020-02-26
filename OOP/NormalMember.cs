using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameter.");
           //Console.ReadLine();
        }

        public NormalMember(string remarks, string name, int memberId, int memberSince): base (name, memberId, memberSince)
        {
            Console.WriteLine("Child constructor with 4 parameters.");
            Console.WriteLine("Remarks = {0}", remarks);
            //Console.ReadLine();
        }

        public void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }

       

    }
}
