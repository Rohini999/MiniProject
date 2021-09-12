using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace DataAccesslayer
{

    public class DAL
    {
        static string constr = "data source=DESKTOP-3N725GL\\SQLEXPRESS;initial catalog=Academy;integrated security=True;";
        public void DisplayStudent()
        {
            DataTable DT = ExecuteData("select * from TA");
            if (DT.Rows.Count > 0)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("=====================================================================");
                Console.WriteLine("DATABASE RECORDS");
                Console.WriteLine("=====================================================================");
                foreach (DataRow row in DT.Rows)
                {
                    Console.WriteLine(row["Stud_ID"].ToString() + " " + row["Stud_name"].ToString() + " " + row["Stud_Address"].ToString() + " " + row["Stud_Trainer"].ToString() + " " +
                        row["Stud_Batch"].ToString() + " " + row["Stud_Mark1"].ToString() + " " + row["Stud_Mark2"].ToString() + " " + row["Stud_Result"].ToString());
                }
                Console.WriteLine("======================================================================" + Environment.NewLine);
            }
            else
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine("No student found in database table!!!");
                Console.Write(Environment.NewLine);
            }
        }
        public void AddStudent()
        {
            string Stud_ID = string.Empty;
            string Stud_name = string.Empty;
            string Stud_Address = string.Empty;
            string Stud_Trainer = string.Empty;
            string Stud_Batch = string.Empty;
            int Stud_Mark1;
            int Stud_Mark2;
           // int Stud_Result;
            string Stud_Result = string.Empty;


            Console.WriteLine("Insert new Student: ");

            Console.Write("Enter Stud_ID: ");
            Stud_ID = Console.ReadLine();



            Console.Write("Enter Stud_name: ");
            Stud_name = Console.ReadLine();
           // Console.WriteLine("name is {0}", Stud_name);
            while (string.IsNullOrEmpty(Stud_name))
            {
                Console.WriteLine("Name cant be empty!");
                Console.WriteLine("Enter Student name once Again");
                Stud_name = Console.ReadLine();

            }

            Console.Write("Enter Stud_Address: ");
            Stud_Address = Console.ReadLine();
           // Console.WriteLine("address is {0}",Stud_Address);
            while (string.IsNullOrEmpty(Stud_Address))
            {
                Console.WriteLine("Name cant be empty!");
                Console.WriteLine("Enter Student Address once Again");
                Stud_Address = Console.ReadLine();

            }
            
        



            Console.Write("Enter Stud_trainer: ");
            Stud_Trainer = Console.ReadLine();

            Console.Write("Enter Batch: ");
            Stud_Batch = Console.ReadLine();

            while (true)
            {



                Console.Write("Enter Stud_Mark: ");
                Stud_Mark1 = Convert.ToInt32(Console.ReadLine());
                if (Stud_Mark1 > 50)
                {
                    Console.WriteLine("Marks cann't be Greater than 50");
                    continue;
                }
                else
                {
                    break;
                }
            }



            while (true)
            {



                Console.WriteLine("Enter Stud_Mark for subject 2: ");
                Stud_Mark2 = Convert.ToInt32(Console.ReadLine());
                if (Stud_Mark2 > 50)
                {
                    Console.WriteLine("Marks cann't be Greater than 50");
                    continue;
                }
                else
                {
                    break;
                }
            }






            Console.Write("Enter Stud_Result: ");
            //Stud_Result = Convert.ToInt32(Console.ReadLine());
            //if (((Stud_Mark1 + Stud_Mark2) / 2) > 30)
            //{
            //    Console.WriteLine("Student Fail");
            //}
            //else
            //{
            //    Console.WriteLine("Student Pass"); 
            //}
           Stud_Result = Console.ReadLine();

            

            
            ExecuteCommand(String.Format("Insert into TA (Stud_ID,Stud_name,Stud_Address,Stud_Trainer,Stud_Batch,Stud_Mark1,Stud_Mark2,Stud_Result) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Stud_ID, Stud_name, Stud_Address, Stud_Trainer, Stud_Batch,Stud_Mark1,Stud_Mark2, Stud_Result));
            
        }
        public bool ExecuteCommand(String queury)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(constr))
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(queury, sqlcon);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
            return true;
        }
   
        public DataTable ExecuteData(String Query)
        {
            DataTable result = new DataTable();

            try
            {
                using (SqlConnection sqlcon = new SqlConnection(constr))
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlcon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(result);
                    sqlcon.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }




        public void DeleteStudent()
        {
            String Stud_ID = String.Empty;


            Console.WriteLine("Delete Existing Student: ");

            Console.Write("Enter student ID: ");
            Stud_ID = Console.ReadLine();

            ExecuteCommand(String.Format("Delete from TA where Stud_ID = '{0}'", Stud_ID));

            Console.WriteLine("Employee details deleted from the database!" + Environment.NewLine);
        }


        public void EditStudent()
        {
            
            string Stud_ID = string.Empty;
            string Stud_name = string.Empty;
            string Stud_Address = string.Empty;
            string Stud_Trainer = string.Empty;
            string Stud_Batch = string.Empty;
            string Stud_Mark1 = string.Empty;
            string Stud_Mark2 = string.Empty;
            string Stud_Result = string.Empty;


            Console.WriteLine("Edit Existing student: ");

            Console.Write("Enter Stud_ID: ");
            Stud_ID = Console.ReadLine();

            Console.Write("Enter Stud_name: ");
            Stud_name = Console.ReadLine();

            Console.Write("Enter Stud_Address: ");
            Stud_Address = Console.ReadLine();

            Console.Write("Enter Stud_Trainer: ");
            Stud_Trainer = Console.ReadLine();

            Console.Write("Enter Stud_Batch : ");
            Stud_Batch = Console.ReadLine();

            Console.Write("Enter Stud_Mark1 : ");
            Stud_Mark1= Console.ReadLine();

            Console.Write("Enter Stud_Mark2 : ");
            Stud_Mark2 = Console.ReadLine();

            Console.Write("Enter Stud_Result : ");
            Stud_Result = Console.ReadLine();


            ExecuteCommand(String.Format("update TA set Stud_name ='{1}', Stud_Address='{2}',Stud_Trainer='{3}', Stud_Batch='{4}',Stud_Mark1 ='{5}',Stud_Mark2 ='{6}',Stud_Result='{7}' where Stud_ID= {0}", Stud_ID, Stud_name, Stud_Address, Stud_Trainer, Stud_Batch, Stud_Mark1, Stud_Mark2, Stud_Result));
        }
   }
}