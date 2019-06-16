using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newapp
{
    public class Groups
    {
        public int Group_id { get; set; }
        public string Group_Name { get; set; }
        
        public Doctors Doctor { get; set; }
        public Visit_Table Visit_Table { get; set; }
    }
}
