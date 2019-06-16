using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newapp
{
    public class Patient_Table
    {
        public int Internal_ID { get; set; }
        public int External_ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string First_Name { get; set; }
        public string Birth_Name { get; set; }
        public int Sex { get; set; }
        public string Date_of_birth { get; set; }
        public int Age { get; set; }
        public string Place_of_birth { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Post_Code { get; set; }
        public int Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Ward_Room { get; set; }
        public string Insure_No { get; set; }
        public string Remarks { get; set; }
        public int Referral_Doctor_id { get; set; }
        public int Deleted { get; set; }
        public int isKgs { get; set; }
        public int isCms { get; set; }
        public int Group_id { get; set; }
        public int UsrID { get; set; }
        public ICollection<Archive_ids> Archive_Ids { get; set; }
    }
}
