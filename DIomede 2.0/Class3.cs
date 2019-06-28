using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diomede2
{
    public class OperazioneAmministrazione
    {

        public MySqlConnection conn = new MySqlConnection();
        public OperazioneAmministrazione(String nomeDB)
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.1.135;Port = 3307;Database=" + nomeDB + ";Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
        }
        public class CommessaAmministrazioneDB
        {
            readonly MySqlConnection con = null;

            public CommessaAmministrazioneDB(MySqlConnection conn)
            {
                con = conn;
            }
            public void Inserimento(int numero, int anno, String settore, String commessa, int cliente, String settoreIntero)
            {
                try
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `COMMESSA`(`NUMMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `CLIENTE`, `SETTOREINTERO`) VALUES('" + numero + "','" + anno + "','" + settore + "','" + commessa + "','" + cliente + "','" + settoreIntero + "')", con);
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
            public List<CommessaAmministrazione> ListaCommessa()
            {
                List<CommessaAmministrazione> lista = new List<CommessaAmministrazione>();
                try
                {
                    con.Open();
                    MySqlDataReader lettore = null;
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA`", con);
                    lettore = command.ExecuteReader();

                    while (lettore.Read())
                    {
                        CommessaAmministrazione lavorazione = new CommessaAmministrazione
                        {
                            Id = (Int32)lettore[0],
                            Numero = (int)lettore[1],
                            Anno = (int)lettore[2],
                            Settore = "" + lettore[3],
                            Commessa = "" + lettore[4],
                            Cliente = (int)lettore[5],
                            SettoreIntero = "" + lettore[6]

                        };

                        lista.Add(lavorazione);
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
                return lista;
            }
            public List<CommessaAmministrazione> ListaCommessa(String n)
            {
                List<CommessaAmministrazione> lista = new List<CommessaAmministrazione>();
                try
                {
                    con.Open();
                    MySqlDataReader lettore = null;
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + n + "'", con);
                    lettore = command.ExecuteReader();

                    while (lettore.Read())
                    {
                        CommessaAmministrazione lavorazione = new CommessaAmministrazione
                        {
                            Id = (Int32)lettore[0],
                            Numero = (int)lettore[1],
                            Anno = (int)lettore[2],
                            Settore = "" + lettore[3],
                            Commessa = "" + lettore[4],
                            Cliente = (int)lettore[5],
                            SettoreIntero = "" + lettore[6]

                        };

                        lista.Add(lavorazione);
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
                return lista;
            }
            public CommessaAmministrazione CercaCommessa(int id)
            {
                CommessaAmministrazione lavorazione = null;
                try
                {
                    con.Open();
                    MySqlDataReader lettore = null;
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + id + "'", con);
                    lettore = command.ExecuteReader();

                    while (lettore.Read())
                    {
                        CommessaAmministrazione l = new CommessaAmministrazione
                        {
                            Id = (Int32)lettore[0],
                            Numero = (int)lettore[1],
                            Anno = (int)lettore[2],
                            Settore = "" + lettore[3],
                            Commessa = "" + lettore[4],
                            Cliente = (int)lettore[5],
                            SettoreIntero = "" + lettore[6]

                        };

                        lavorazione = l;
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
                return lavorazione;
            }
            public List<CommessaAmministrazione> FiltroCommessa(String s, String g)
            {
                List<CommessaAmministrazione> lavorazione = new List<CommessaAmministrazione>();
                try
                {
                    con.Open();
                    MySqlDataReader lettore = null;
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `" + s + "` = '" + g + "'", con);
                    lettore = command.ExecuteReader();

                    while (lettore.Read())
                    {
                        CommessaAmministrazione l = new CommessaAmministrazione
                        {
                            Id = (Int32)lettore[0],
                            Numero = (int)lettore[1],
                            Anno = (int)lettore[2],
                            Settore = "" + lettore[3],
                            Commessa = "" + lettore[4],
                            Cliente = (int)lettore[5],
                            SettoreIntero = "" + lettore[6]

                        };

                        lavorazione.Add(l);
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
                return lavorazione;
            }
            public void AggiornaCommessa(int id, int numero, int anno, String settore, String commessa, int cliente, String settoreIntero)
            {
                try
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE `COMMESSA` SET `NUMMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreIntero +"' WHERE `ID` = '" + id + "'", con);
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
            public void RimuoviCommessa(int id)
            {
                try
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand("DELETE FROM `COMMESSA` WHERE `ID` = '" + id + "'", con);
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





    }
    public class ClienteAmministrazione
    {
        private int id;
        private String nome;
        private String desc;
        private String tel;
        private String email;
        private String partitaIva;
        private String sdi;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string PartitaIva { get => partitaIva; set => partitaIva = value; }
        public string Sdi { get => sdi; set => sdi = value; }
    }
    public class CommessaAmministrazione
    {
        private int id;
        private int numero;
        private int anno;
        private String settore;
        private String commessa;
        private int cliente;
        private String settoreIntero;

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Anno { get => anno; set => anno = value; }
        public string Settore { get => settore; set => settore = value; }
        public string Commessa { get => commessa; set => commessa = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public string SettoreIntero { get => settoreIntero; set => settoreIntero = value; }
    }
}
