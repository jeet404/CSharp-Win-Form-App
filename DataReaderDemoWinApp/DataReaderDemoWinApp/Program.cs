using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


class main
{
    public static void Main(string[] args)
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\ParameterCommandClassDemoWinApp\ParameterCommandClassDemoWinApp\User_Data.mdf';Integrated Security=True");
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM user_detail", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine(" |- "+reader["u_name"].ToString()+" "+reader["u_pass"].ToString());
        }
        Console.ReadLine();
    }
}

