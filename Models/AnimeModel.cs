using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiaelappc.Models
{
    public class AnimeModel
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public string imageurl { get; set; }
        public string trailerurl { get; set; }
        public DateTime lanzamiento { get; set; }
        public string director { get; set; }
        public IEnumerable<string>categoria{ get; set; }
        public string descripcion { get; set; }
    }
}
