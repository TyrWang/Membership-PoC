using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    class PremiumMember : IMember
    {
        public string Play()
        {
            return "I'm at a payphone trying to call home~";
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
