
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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\WorkSpace\BCA SEM-4\C# Form App\DataSetDemoWinApp\DataSetDemoWinApp\main_data.mdf';Integrated Security=True");
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM stud", conn);
        DataSet ds = new DataSet();
        da.Fill(ds,"stud");
        SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM emp", conn);
        da2.Fill(ds, "emp");
        Console.WriteLine("=== STUD ===");
        Console.WriteLine();
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            Console.WriteLine(ds.Tables[0].Rows[i][0].ToString()+" "+ds.Tables[0].Rows[i][1].ToString());
        }
        Console.WriteLine();
        Console.WriteLine("=== EMP ===");
        Console.WriteLine();
        for (int i = 0; i < ds.Tables[1].Rows.Count;i++)
        {
            Console.WriteLine(ds.Tables[1].Rows[i][0].ToString()+" "+ds.Tables[1].Rows[i][1].ToString());
        }
    }
}
