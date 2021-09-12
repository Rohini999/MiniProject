using System;
using Model3;
using DataAccesslayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
namespace TAM
{
    class Academy
    {
        static void Main(string[] args)
        {
            DAL n = new DAL();
          
            n.DisplayStudent();

            n.AddStudent();
            n.DisplayStudent();

           n.EditStudent();
            n.DisplayStudent();

            n.DeleteStudent();
            n.DisplayStudent();




            


            //Student n = new Student();


            //Console.Write(" Find the nth Maximum Grade Point achieved by the students from the list of student : ");
            //Console.Write("\n------------------------------------------------------------------------------------------\n");

            //Console.Write("Which maximum grade point(1st, 2nd, 3rd,4th,5th ...) you want to find  : ");
            //int grPointRank = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\n");
            //var stulist = e.GtStuRec();
            //var students = (from stuMast in stulist
            //                group stuMast by stuMast.GrPoint into g
            //                orderby g.Key descending
            //                select new
            //                {
            //                    StuRecord = g.ToList()
            //                }).ToList();

            //students[grPointRank - 1].StuRecord
            //    .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.StuId, i.StuName, i.GrPoint));

            //Console.ReadKey();

        }




    }
 }
