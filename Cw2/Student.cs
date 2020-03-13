using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    public class Student
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string studName { get; set; }
        public string stuMode { get; set; }
        public string index { get; set; }
        public string dateBirth { get; set; }
        public string email { get; set; }
        public string mom { get; set; }
        public string dad { get; set; }
        
        public override string ToString()
        {
            return "FirstName: "+fName+
                " LastName: "+lName+
                " StudiesName: "+studName+
                " StudiesMode: "+stuMode+
                " Index: "+index+
                " DateBirth: "+dateBirth+
                " Email: "+email+
                " Mother: "+mom+
                " Father: "+dad;
        }

    }
}
