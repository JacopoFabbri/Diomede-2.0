using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Diomede2
{
    public class OperazioneAmministrazione
    {
        public MySqlConnection conn = new MySqlConnection();

        public OperazioneAmministrazione(string nomeDB)
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.1.135;Port = 3307;Database=" + nomeDB +
                                    ";Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
        }


        public void InserimentoCommessa(int numero, int anno, string settore, string commessa, int cliente,
            string settoreIntero)
        {
            try
            {
                var bDB = new CommessaAmministrazioneDB(conn);
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
                var bDB = new CommessaAmministrazioneDB(conn);
                lista = bDB.ListaCommessa();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }

        public List<CommessaAmministrazione> CercaCommessa(string n)
        {
            List<CommessaAmministrazione> lista;
            try
            {
                var bDB = new CommessaAmministrazioneDB(conn);
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
                var bDB = new CommessaAmministrazioneDB(conn);
                contatto = bDB.CercaCommessa(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }

        public List<CommessaAmministrazione> FiltraCommessa(string s, string g)
        {
            List<CommessaAmministrazione> contatto;
            try
            {
                var bDB = new CommessaAmministrazioneDB(conn);
                contatto = bDB.FiltroCommessa(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }

        public void UpdatePagamento(int id, int numero, int anno, string settore, string commessa, int cliente,
            string settoreIntero)
        {
            try
            {
                var bDB = new CommessaAmministrazioneDB(conn);
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
                var bDB = new CommessaAmministrazioneDB(conn);
                bDB.RimuoviCommessa(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public void InserimentoCliente(string nome, string tel, string email, string partitaIva, string sdi)
        {
            try
            {
                var bDB = new ClienteAmministrazioneDB(conn);
                bDB.Inserimento(nome, tel, email, partitaIva, sdi);
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
                var bDB = new ClienteAmministrazioneDB(conn);
                lista = bDB.ListaCliente();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }

        public List<ClienteAmministrazione> CercaCliente(string n)
        {
            List<ClienteAmministrazione> lista;
            try
            {
                var bDB = new ClienteAmministrazioneDB(conn);
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
                var bDB = new ClienteAmministrazioneDB(conn);
                contatto = bDB.CercaCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }

        public List<ClienteAmministrazione> FiltraCliente(string s, string g)
        {
            List<ClienteAmministrazione> contatto;
            try
            {
                var bDB = new ClienteAmministrazioneDB(conn);
                contatto = bDB.FiltroCliente(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }

        public void UpdateCliente(int id, string nome, string tel, string email, string partitaIva, string sdi)
        {
            try
            {
                var bDB = new ClienteAmministrazioneDB(conn);
                bDB.AggiornaCliente(id, nome, tel, email, partitaIva, sdi);
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
                var bDB = new ClienteAmministrazioneDB(conn);
                bDB.RimuoviCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        public void InserimentoBozza(int numero, int anno, string settore, string commessa, int cliente,
            string settoreIntero)
        {
            try
            {
                var bDB = new PreventivoAmministrazioneDB(conn);
                bDB.Inserimento(numero, anno, settore, commessa, cliente, settoreIntero);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }


        public List<PreventivoAmministrazione> FiltraPreventivo(string s, string g)
        {
            List<PreventivoAmministrazione> contatto;
            try
            {
                var bDB = new PreventivoAmministrazioneDB(conn);
                contatto = bDB.FiltroCommessa(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }

        public string GeneraCommessa(string s, ClienteAmministrazione c, string settore, bool bozza)
        {
            try
            {

                string commessa = "";
                if (bozza == false)
                {
                    var anno = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                    var lista = FiltraCommessa("ANNO", "" + anno);
                    if (lista.Count > 0)
                    {
                        InserimentoCommessa(lista[lista.Count - 1].Numero + 1, anno, s,
                            "" + (lista[lista.Count - 1].Numero + 1) + "/" + anno + "/" + s, c.Id, settore);

                        commessa = "" + (lista[lista.Count - 1].Numero + 1) + "/" + anno + "/" + s;
                    }
                    else
                    {
                        InserimentoCommessa(1, anno, s, "" + 1 + "/" + anno + "/" + s, c.Id, settore);
                        commessa = "" + 1 + "/" + anno + "/" + s;
                    }
                }
                else
                {
                    var anno = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                    var lista = FiltraPreventivo("ANNO", "" + anno);
                    if (lista.Count > 0)
                    {
                        InserimentoBozza(lista[lista.Count - 1].Numero + 1, anno, s,
                            "" + (lista[lista.Count - 1].Numero + 1) + "/" + anno + "/" + s, c.Id, settore);

                        commessa = "" + (lista[lista.Count - 1].Numero + 1) + "/" + anno + "/" + s;
                    }
                    else
                    {
                        InserimentoBozza(1, anno, s, "" + 1 + "/" + anno + "/" + s, c.Id, settore);
                        commessa = "" + 1 + "/" + anno + "/" + s;
                    }
                }
                return commessa;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        
    }

    public class CommessaAmministrazioneDB
    {
        private readonly MySqlConnection con;

        public CommessaAmministrazioneDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(int numero, int anno, string settore, string commessa, int cliente,
            string settoreIntero)
        {
            try
            {
                MySqlCommand command;
                con.Open();
                    command = new MySqlCommand(
                        "INSERT INTO `COMMESSA`(`NUMMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `CLIENTE`, `SETTOREINTERO`) VALUES('" +
                        numero + "','" + anno + "','" + settore + "','" + commessa + "','" + cliente + "','" +
                        settoreIntero +  "')", con);

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
            var lista = new List<CommessaAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `COMMESSA`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    CommessaAmministrazione lavorazione;
                        lavorazione = new CommessaAmministrazione
                        {
                            Id = (int) lettore[0],
                            Numero = (int) lettore[1],
                            Anno = (int) lettore[2],
                            Settore = "" + lettore[3],
                            Commessa = "" + lettore[4],
                            Cliente = (int) lettore[5],
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

        public List<CommessaAmministrazione> ListaCommessa(string n)
        {
            var lista = new List<CommessaAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    CommessaAmministrazione lavorazione;
                        lavorazione = new CommessaAmministrazione
                        {
                            Id = (int) lettore[0],
                            Numero = (int) lettore[1],
                            Anno = (int) lettore[2],
                            Settore = "" + lettore[3],
                            Commessa = "" + lettore[4],
                            Cliente = (int) lettore[5],
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
                var command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    CommessaAmministrazione l;
                        l = new CommessaAmministrazione
                        {
                            Id = (int) lettore[0],
                            Numero = (int) lettore[1],
                            Anno = (int) lettore[2],
                            Settore = "" + lettore[3],
                            Commessa = "" + lettore[4],
                            Cliente = (int) lettore[5],
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

        public List<CommessaAmministrazione> FiltroCommessa(string s, string g)
        {
            var lavorazione = new List<CommessaAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var l = new CommessaAmministrazione
                    {
                        Id = (int) lettore[0],
                        Numero = (int) lettore[1],
                        Anno = (int) lettore[2],
                        Settore = "" + lettore[3],
                        Commessa = "" + lettore[4],
                        Cliente = (int) lettore[5],
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

        public void AggiornaCommessa(int id, int numero, int anno, string settore, string commessa, int cliente,
            string settoreIntero)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "UPDATE `COMMESSA` SET `NUMMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore +
                    "',`COMMESSA`='" + commessa + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreIntero +
                    "' WHERE `ID` = '" + id + "'", con);
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
                var command = new MySqlCommand("DELETE FROM `COMMESSA` WHERE `ID` = '" + id + "'", con);
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
    public class PreventivoAmministrazioneDB
    {
        private readonly MySqlConnection con;

        public PreventivoAmministrazioneDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(int numero, int anno, string settore, string commessa, int cliente,
            string settoreIntero)
        {
            try
            {
                MySqlCommand command;
                con.Open();
                command = new MySqlCommand(
                    "INSERT INTO `PREVENTIVO`(`NUMMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `CLIENTE`, `SETTOREINTERO`) VALUES('" +
                    numero + "','" + anno + "','" + settore + "','" + commessa + "','" + cliente + "','" +
                    settoreIntero + "')", con);

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


        public List<PreventivoAmministrazione> FiltroCommessa(string s, string g)
        {
            var lavorazione = new List<PreventivoAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PREVENTIVO` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var l = new PreventivoAmministrazione
                    {
                        Id = (int)lettore[0],
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

        public void AggiornaCommessa(int id, int numero, int anno, string settore, string commessa, int cliente,
            string settoreIntero)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "UPDATE `PREVENTIVO` SET `NUMMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore +
                    "',`COMMESSA`='" + commessa + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreIntero +
                    "' WHERE `ID` = '" + id + "'", con);
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
                var command = new MySqlCommand("DELETE FROM `COMMESSA` WHERE `ID` = '" + id + "'", con);
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
        private readonly MySqlConnection con;

        public ClienteAmministrazioneDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(string nome, string tel, string email, string partitaIva, string sdi)
        {
            try
            {
                con.Open();
                var command =
                    new MySqlCommand(
                        "INSERT INTO `CLIENTI`( `NOME`, `TEL`, `EMAIL`, `PARTITAIVA`, `SDI`) VALUES('" + nome + "','" +
                        tel + "','" + email + "','" + partitaIva + "','" + sdi + "')", con);
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
            var lista = new List<ClienteAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CLIENTI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var lavorazione = new ClienteAmministrazione
                    {
                        Id = (int) lettore[0],
                        Nome = "" + lettore[1],
                        Tel = "" + lettore[2],
                        Email = "" + lettore[3],
                        PartitaIva = "" + lettore[4],
                        Sdi = "" + lettore[5]
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

        public List<ClienteAmministrazione> ListaCliente(string n)
        {
            var lista = new List<ClienteAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CLIENTI` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var lavorazione = new ClienteAmministrazione
                    {
                        Id = (int) lettore[0],
                        Nome = "" + lettore[1],
                        Tel = "" + lettore[2],
                        Email = "" + lettore[3],
                        PartitaIva = "" + lettore[4],
                        Sdi = "" + lettore[5]
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
                var command = new MySqlCommand("SELECT * FROM `CLIENTI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var l = new ClienteAmministrazione
                    {
                        Id = (int) lettore[0],
                        Nome = "" + lettore[1],
                        Tel = "" + lettore[2],
                        Email = "" + lettore[3],
                        PartitaIva = "" + lettore[4],
                        Sdi = "" + lettore[5]
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

        public List<ClienteAmministrazione> FiltroCliente(string s, string g)
        {
            var lavorazione = new List<ClienteAmministrazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CLIENTI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var l = new ClienteAmministrazione
                    {
                        Id = (int) lettore[0],
                        Nome = "" + lettore[1],
                        Tel = "" + lettore[2],
                        Email = "" + lettore[3],
                        PartitaIva = "" + lettore[4],
                        Sdi = "" + lettore[5]
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

        public void AggiornaCliente(int id, string nome, string tel, string email, string partitaIva, string sdi)
        {
            try
            {
                con.Open();
                var command =
                    new MySqlCommand(
                        "UPDATE `CLIENTE` SET `NOME`='" + nome + "',`TEL`='" + tel + "',`EMAIL`='" + email +
                        "',`PARTITAIVA`='" + partitaIva + "',`SDI`='" + sdi + "' WHERE `ID` = '" + id + "'", con);
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
                var command = new MySqlCommand("DELETE FROM `CLIENTE` WHERE `ID` = '" + id + "'", con);
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
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public string PartitaIva { get; set; }

        public string Sdi { get; set; }
    }

    public class CommessaAmministrazione
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public int Anno { get; set; }

        public string Settore { get; set; }

        public string Commessa { get; set; }

        public int Cliente { get; set; }

        public string SettoreIntero { get; set; }

    }
    public class PreventivoAmministrazione
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public int Anno { get; set; }

        public string Settore { get; set; }

        public string Commessa { get; set; }

        public int Cliente { get; set; }

        public string SettoreIntero { get; set; }

    }
}