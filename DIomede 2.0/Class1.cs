using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    //"User Id=" + nome + "; Host=hostingmysql335.register.it;Database=eribea;Persist Security Info=True;Password=" + password + ";"
    class Class1
    {
        MySqlConnection conn = new MySqlConnection();
        public void open()
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.135:3307;Database=Utenza;Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
            conn.Open();
        }
       
    }
}
