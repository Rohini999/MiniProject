using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Model3
{

    public class Student
    {
        public int stud_id { get; set; }
        public string stud_name { get; set; }
        public string stud_address { get; set; }
        public string stud_trainer { get; set; }
        public string stud_batch { get; set; }
        public string stud_mark1 { get; set; }
        public string stud_mark2 { get; set; }
        public string stud_result { get; set; }

        public string stuname { get; set; }
        public int grpoint { get; set; }
        public int stuid { get; set; }

        //public list<student> gtsturec()
        //{
        //    list<student> stulist = new list<student>();
        //    stulist.add(new student { stuid = 10, stuname = " rohini jadhav ", grpoint = 800 });
        //    stulist.add(new student { stuid = 11, stuname = "amol more", grpoint = 458 });
        //    stulist.add(new student { stuid = 13, stuname = "radha kadam", grpoint = 900 });
        //    stulist.add(new student { stuid = 14, stuname = "rohi jain", grpoint = 900 });
        //    stulist.add(new student { stuid = 15, stuname = "ram solanke", grpoint = 458 });
        //    stulist.add(new student { stuid = 16, stuname = "ragini jadhavr", grpoint = 700 });
        //    stulist.add(new student { stuid = 17, stuname = "rupali", grpoint = 750 });
        //    stulist.add(new student { stuid = 18, stuname = "chirag", grpoint = 700 });
        //    stulist.add(new student { stuid = 19, stuname = "sonali", grpoint = 597 });
        //    stulist.add(new student { stuid = 20, stuname = "arti", grpoint = 450 });
        //    return stulist;
        //}
        //

    }
}





