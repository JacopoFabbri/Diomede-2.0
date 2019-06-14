using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Operaziones
    {

        public MySqlConnection conn = new MySqlConnection();
        public Operaziones(String nomeDB)
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.1.135;Port = 3307;Database="+ nomeDB + ";Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
        }
        public Utente CercaUtente(String u)
        {
            Utente utente;
            try
            {

                UtenteDB db = new UtenteDB(conn);
                utente = db.CercaUtente(u);

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return utente;
        }
        public Ruolo CercaRuolo(int i)
        {
            Ruolo ruolo;
            try
            {

                RuoloDB db = new RuoloDB(conn);
                ruolo = db.CercaRuolo(i);

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return ruolo;
        }
        public void ModificaDatiUtente(int id, String u, String p)
        {
            try
            {

                UtenteDB db = new UtenteDB(conn);
                db.ModificaUserPass(id, u, p);

            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

    }
    public class UtenteDB
    {
        readonly MySqlConnection con = null;
        public UtenteDB(MySqlConnection conn)
        {
            con = conn;
        }
        public Utente CercaUtente(String user)
        {
            Utente u = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `UTENTI` WHERE `USERNAME` = '" + user + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Utente utente = new Utente
                    {
                        Id = (Int32)lettore[0],
                        Username = (String)lettore[1],
                        Password = (String)lettore[2],
                        Ruolo = (Int32)lettore[3]
                    };
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
        public void ModificaUserPass(int id, String u, String p)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `UTENTI` SET `USERNAME`='" + u + "',`PASSWORD`='" + p + "' WHERE `ID` = '" + id + "'", con);
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
        readonly MySqlConnection con = null;
        public RuoloDB(MySqlConnection conn)
        {
            con = conn;
        }
        public Ruolo CercaRuolo(int id)
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
                    Ruolo ruolo = new Ruolo
                    {
                        Nome = (String)lettore[1],
                        Macro = (String)lettore[2],
                        Job = (String)lettore[3]
                    };
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
        private int id;
        private String username;
        private String password;
        private int ruolo;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Ruolo { get => ruolo; set => ruolo = value; }
        public int Id { get => id; set => id = value; }
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
