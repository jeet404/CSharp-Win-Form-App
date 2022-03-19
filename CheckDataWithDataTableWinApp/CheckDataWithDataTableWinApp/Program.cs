using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

class main
{
    public static void Main()
    {
        int chkid;
        int choice;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\ParameterCommandClassDemoWinApp\ParameterCommandClassDemoWinApp\User_Data.mdf';Integrated Security=True");
        conn.Open();
        do
        {
            Console.Write("Enter Id : ");
            chkid = Int32.Parse(Console.ReadLine());
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM user_detail WHERE Id = "+chkid+"", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Data Found");
                Console.WriteLine("_____________");
                Console.WriteLine("Id = "+dt.Rows[0][0].ToString());
                Console.WriteLine("Username = "+dt.Rows[0][1].ToString());
                Console.WriteLine("Password = "+dt.Rows[0][2].ToString());
                Console.WriteLine("_____________");
            }
            else
            {
                Console.WriteLine("Data Not Exist!!");
            }
            Console.WriteLine("For To Continue Press 1...");
            choice = Int32.Parse(Console.ReadLine());
        }while(choice == 1);
    }
}
