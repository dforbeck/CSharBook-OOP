using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Member
    {
        protected int annualFee;
        private string name;
        private int memberId;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name +
                    "\nMember ID: " + memberId +
                    "\nMember Since: " + memberSince +
                    "\nTotal Annual Fee: " + annualFee;
        }

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter.");
        }

        public Member(string pName, int pMembershipId, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters.");

            name = pName;
            memberId = pMembershipId;
            memberSince = pMemberSince;

        }

    }
}
