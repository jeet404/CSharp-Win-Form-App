using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

class main
{
    public static void Main()
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\ParameterCommandClassDemoWinApp\ParameterCommandClassDemoWinApp\User_Data.mdf';Integrated Security=True");
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM user_detail", conn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        for(int i = 0; i < dt.Rows.Count; i++)
        {
            Console.WriteLine(dt.Rows[i][0].ToString()+" "+dt.Rows[i][1].ToString());
        }
        Console.ReadLine();
    }
}
