using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiaelappc.Models
{
    public class UserModel
    {

        public string id { get; set; }

        public string nickname { get; set; }

        public string password { get; set; }

        public string mail { get; set; }

        public Int32 age { get; set; }

        public string avatar { get; set; }

        public string rol { get; set; }
        public string descripcion { get; set; }
        public IEnumerable<string> favm { get; set; }
        public IEnumerable<string> favn { get; set; }

    }
}
