using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newapp
{
    public class Archive_ids
    {
        public int ID { get; set; }
        public int Internal_Id { get; set; }
        public Visit_Table Visit_Table { get; set; }
        public UserTable UserTable { get; set; }
        public Patient_Table Patient_Table { get; set; }
        public Training_parameters Training_Parameters { get; set; }

    }
}
