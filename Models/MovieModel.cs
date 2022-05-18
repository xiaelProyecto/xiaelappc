using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiaelappc.Models
{
    public class MovieModel
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public string imageurl { get; set; }
        public string trailerurl { get; set; }
        public DateTime lanzamiento { get; set; }
        public IEnumerable<Object> plataformas { get; set; }
        public IEnumerable<string> reparto { get; set; }
        public Int32 edadminima { get; set; }
        public string descripcion { get; set; }
    }
}
