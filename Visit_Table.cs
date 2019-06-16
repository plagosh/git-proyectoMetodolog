using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newapp
{
    public class Visit_Table
    {
        public int ID { get; set; }
        public int Internal_ID { get; set; }
        public string VisitDateTime { get; set; }
        public string Doctor { get; set; }
        public string Ref_Doctor { get; set; }
        public string Interpretation { get; set; }
        public int Type_of_Test { get; set; }
        public int Xtra1 { get; set; }
        public int Xtra2 { get; set; }
        public int Xtra3 { get; set; }
        public int Xtra4 { get; set; }

        public ICollection<Temp_Visit_Table> Temp_Visit_Tables { get; set; }
        public Archive_ids Archive_Ids { get; set; }
        public ICollection<Temp_Visit> Temp_Visits { get; set; }
        public Groups Groups { get; set; }

    }
}
