using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Operazione
    {

        MySqlConnection conn = new MySqlConnection();
        public Operazione()
        {
            conn.ConnectionString = "User Id=; Host=192.168.1.135;Port = 3307;Database=Utenza;Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
        }
        public Utente cercaUtente(String u)
        {
            Utente utente = null;
            try
            {

                UtenteDB db = new UtenteDB(conn);
                utente = db.cercaUtente(u);

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return utente;
        }
        public Ruolo cercaRuolo(int i)
        {
            Ruolo ruolo = null;
            try
            {

                RuoloDB db = new RuoloDB(conn);
                ruolo = db.cercaRuolo(i);

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return ruolo;
        }
        public void modificaDatiUtente(int id, String u, String p)
        {
            try
            {

                UtenteDB db = new UtenteDB(conn);
                db.modificaUserPass(id, u, p);

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

    }
    public class UtenteDB
    {
        MySqlConnection con = null;
        public UtenteDB(MySqlConnection conn)
        {
            con = conn;
        }
        public Utente cercaUtente(String user)
        {
            Utente u = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `UTENTI` WHERE `USERNAME` = '" + u + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Utente utente = new Utente();
                    utente.Username = (String)lettore[1];
                    utente.Password = (String)lettore[2];
                    utente.Ruolo = (Int32)lettore[3];
                    u = utente;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return u;
        }
        public void modificaUserPass(int id, String u, String p)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `UTENTI` SET `USERNAME`=" + u + ",`PASSWORD`=" + p + " WHERE `ID` = '" + id + "'", con);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
    public class RuoloDB
    {
        MySqlConnection con = null;
        public RuoloDB(MySqlConnection conn)
        {
            con = conn;
        }
        public Ruolo cercaRuolo(int id)
        {
            Ruolo r = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `Ruoli` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Ruolo ruolo = new Ruolo();
                    ruolo.Nome = (String)lettore[1];
                    ruolo.Macro = (String)lettore[2];
                    ruolo.Job = (String)lettore[3];
                    r = ruolo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return r;
        }
    }
    public class Utente
    {
        private String username;
        private String password;
        private int ruolo;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Ruolo { get => ruolo; set => ruolo = value; }
    }
    public class Ruolo
    {
        private String nome;
        private String macro;
        private String job;

        public string Nome { get => nome; set => nome = value; }
        public string Macro { get => macro; set => macro = value; }
        public string Job { get => job; set => job = value; }
    }
}
