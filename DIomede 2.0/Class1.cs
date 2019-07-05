using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Database
{
    public class Operaziones
    {
        public MySqlConnection conn = new MySqlConnection();

        public Operaziones(string nomeDB)
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.1.135;Port = 3307;Database=" + nomeDB + ";Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
        }

        public void inserisciUtente(string user, string pass, int ruolo)
        {
            try
            {
                var db = new UtenteDB(conn);
                db.inserisciUtente(user, pass, ruolo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Utente CercaUtente(string u)
        {
            Utente utente;
            try
            {
                var db = new UtenteDB(conn);
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
                var db = new RuoloDB(conn);
                ruolo = db.CercaRuolo(i);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return ruolo;
        }

        public List<Ruolo> CercaRuolo()
        {
            List<Ruolo> ruolo;
            try
            {
                var db = new RuoloDB(conn);
                ruolo = db.CercaRuolo();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return ruolo;
        }

        public void ModificaDatiUtente(int id, string u, string p)
        {
            try
            {
                var db = new UtenteDB(conn);
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
        private readonly MySqlConnection con;

        public UtenteDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void inserisciUtente(string user, string pass, int ruolo)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("INSERT INTO `UTENTI` `USERNAME`, `PASSWORD`, `RUOLO`) VALUES ('" +
                                               user + "','" + pass + "','" + ruolo + "')");
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

        public Utente CercaUtente(string user)
        {
            Utente u = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `UTENTI` WHERE `USERNAME` = '" + user + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var utente = new Utente
                    {
                        Id = (int) lettore[0],
                        Username = (string) lettore[1],
                        Password = (string) lettore[2],
                        Ruolo = (int) lettore[3]
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

        public void ModificaUserPass(int id, string u, string p)
        {
            try
            {
                con.Open();
                var command =
                    new MySqlCommand(
                        "UPDATE `UTENTI` SET `USERNAME`='" + u + "',`PASSWORD`='" + p + "' WHERE `ID` = '" + id + "'",
                        con);
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
        private readonly MySqlConnection con;

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
                var command = new MySqlCommand("SELECT * FROM `Ruoli` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var ruolo = new Ruolo
                    {
                        ID = (int) lettore[0],
                        Nome = (string) lettore[1],
                        Macro = (string) lettore[2],
                        Job = (string) lettore[3]
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

        public List<Ruolo> CercaRuolo()
        {
            var r = new List<Ruolo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `Ruoli`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var ruolo = new Ruolo
                    {
                        ID = (int) lettore[0],
                        Nome = (string) lettore[1],
                        Macro = (string) lettore[2],
                        Job = (string) lettore[3]
                    };
                    r.Add(ruolo);
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
        public string Username { get; set; }

        public string Password { get; set; }

        public int Ruolo { get; set; }

        public int Id { get; set; }
    }

    public class Ruolo
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Macro { get; set; }

        public string Job { get; set; }
    }
}