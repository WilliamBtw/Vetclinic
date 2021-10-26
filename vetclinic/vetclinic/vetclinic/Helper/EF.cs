using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetclinic.Helper
{
    class EF
    {
        public static vetEntities Context { get; } = new vetEntities();
        public static Helper.User user = new User();
        public static Helper.Auth auth = new Auth();
    }
}
