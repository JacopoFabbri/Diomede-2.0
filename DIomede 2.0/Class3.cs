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


        public void InserimentoCommessa(int numero, int anno, String settore, String commessa, int cliente, String settoreIntero)
        {
            try
            {
                CommessaAmministrazioneDB bDB = new CommessaAmministrazioneDB(conn);
                bDB.Inserimento(numero, anno, settore, commessa, cliente, settoreIntero);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<CommessaAmministrazione> CercaCommessa()
        {
            List<CommessaAmministrazione> lista;
            try
            {
                CommessaAmministrazioneDB bDB = new CommessaAmministrazioneDB(conn);
                lista = bDB.ListaCommessa();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<CommessaAmministrazione> CercaCommessa(String n)
        {
            List<CommessaAmministrazione> lista;
            try
            {
                CommessaAmministrazioneDB bDB = new CommessaAmministrazioneDB(conn);
                lista = bDB.ListaCommessa(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public CommessaAmministrazione CercaCommessa(int id)
        {
            CommessaAmministrazione contatto;
            try
            {
                CommessaAmministrazioneDB bDB = new CommessaAmministrazioneDB(conn);
                contatto = bDB.CercaCommessa(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<CommessaAmministrazione> FiltraPagamento(String s, String g)
        {
            List<CommessaAmministrazione> contatto;
            try
            {
                CommessaAmministrazioneDB bDB = new CommessaAmministrazioneDB(conn);
                contatto = bDB.FiltroCommessa(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdatePagamento(int id, int numero, int anno, String settore, String commessa, int cliente, String settoreIntero)
        {
            try
            {
                CommessaAmministrazioneDB bDB = new CommessaAmministrazioneDB(conn);
                bDB.AggiornaCommessa(id, numero, anno, settore, commessa, cliente, settoreIntero);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaPagamento(int id)
        {
            try
            {
                CommessaAmministrazioneDB bDB = new CommessaAmministrazioneDB(conn);
                bDB.RimuoviCommessa(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public void InserimentoCliente(String nome, String desc, String tel, String email, String partitaIva, String sdi)
        {
            try
            {
                ClienteAmministrazioneDB bDB = new ClienteAmministrazioneDB(conn);
                bDB.Inserimento(nome, desc, tel, email, partitaIva, sdi);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<ClienteAmministrazione> CercaCliente()
        {
            List<ClienteAmministrazione> lista;
            try
            {
                ClienteAmministrazioneDB bDB = new ClienteAmministrazioneDB(conn);
                lista = bDB.ListaCliente();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<ClienteAmministrazione> CercaCliente(String n)
        {
            List<ClienteAmministrazione> lista;
            try
            {
                ClienteAmministrazioneDB bDB = new ClienteAmministrazioneDB(conn);
                lista = bDB.ListaCliente(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public ClienteAmministrazione CercaCliente(int id)
        {
            ClienteAmministrazione contatto;
            try
            {
                ClienteAmministrazioneDB bDB = new ClienteAmministrazioneDB(conn);
                contatto = bDB.CercaCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<ClienteAmministrazione> FiltraCliente(String s, String g)
        {
            List<ClienteAmministrazione> contatto;
            try
            {
                ClienteAmministrazioneDB bDB = new ClienteAmministrazioneDB(conn);
                contatto = bDB.FiltroCliente(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdateCliente(int id, String nome, String desc, String tel, String email, String partitaIva, String sdi)
        {
            try
            {
                ClienteAmministrazioneDB bDB = new ClienteAmministrazioneDB(conn);
                bDB.AggiornaCliente(id, nome, desc, tel, email, partitaIva, sdi);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaCliente(int id)
        {
            try
            {
                ClienteAmministrazioneDB bDB = new ClienteAmministrazioneDB(conn);
                bDB.RimuoviCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }



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
                MySqlCommand command = new MySqlCommand("UPDATE `COMMESSA` SET `NUMMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreIntero + "' WHERE `ID` = '" + id + "'", con);
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
    public class ClienteAmministrazioneDB
    {
        readonly MySqlConnection con = null;

        public ClienteAmministrazioneDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, String desc, String tel, String email, String partitaIva, String sdi)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `CLIENTI`( `NOME`, `DESCRIZIONE`, `TEL`, `EMAIL`, `PARTITAIVA`, `SDI`) VALUES('" + nome + "','" + desc + "','" + tel + "','" + email + "','" + partitaIva + "','" + sdi + "')", con);
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
        public List<ClienteAmministrazione> ListaCliente()
        {
            List<ClienteAmministrazione> lista = new List<ClienteAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `CLIENTE`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    ClienteAmministrazione lavorazione = new ClienteAmministrazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Desc = "" + lettore[2],
                        Tel = "" + lettore[3],
                        Email = "" + lettore[4],
                        PartitaIva = "" + lettore[5],
                        Sdi = "" + lettore[6]

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
        public List<ClienteAmministrazione> ListaCliente(String n)
        {
            List<ClienteAmministrazione> lista = new List<ClienteAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `CLIENTE` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    ClienteAmministrazione lavorazione = new ClienteAmministrazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Desc = "" + lettore[2],
                        Tel = "" + lettore[3],
                        Email = "" + lettore[4],
                        PartitaIva = "" + lettore[5],
                        Sdi = "" + lettore[6]

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
        public ClienteAmministrazione CercaCliente(int id)
        {
            ClienteAmministrazione lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `CLIENTE` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    ClienteAmministrazione l = new ClienteAmministrazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Desc = "" + lettore[2],
                        Tel = "" + lettore[3],
                        Email = "" + lettore[4],
                        PartitaIva = "" + lettore[5],
                        Sdi = "" + lettore[6]

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
        public List<ClienteAmministrazione> FiltroCliente(String s, String g)
        {
            List<ClienteAmministrazione> lavorazione = new List<ClienteAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `CLIENTE` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    ClienteAmministrazione l = new ClienteAmministrazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Desc = "" + lettore[2],
                        Tel = "" + lettore[3],
                        Email = "" + lettore[4],
                        PartitaIva = "" + lettore[5],
                        Sdi = "" + lettore[6]

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
        public void AggiornaCliente(int id, String nome, String desc, String tel, String email, String partitaIva, String sdi)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `CLIENTE` SET `NOME`='" + nome + "',`DESCRIZIONE`='" + desc + "',`TEL`='" + tel + "',`EMAIL`='" + email + "',`PARTITAIVA`='" + partitaIva + "',`SDI`='" + sdi + "' WHERE `ID` = '" + id + "'", con);
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
        public void RimuoviCliente(int id)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM `CLIENTE` WHERE `ID` = '" + id + "'", con);
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
