using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    class NormalMember : IMember
    {
        public string Play()
        {
            return "Nothing happened";
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
