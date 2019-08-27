using System;
using System.Collections.Generic;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Amministrazione
{
    public class OperazioniAmministrazione
    {
        public MySqlConnection conn = new MySqlConnection();
        public OperazioniAmministrazione(string nomeDB)
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.1.135;Port = 3307;Database=" + nomeDB + ";Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
        }
        public void InserimentoCliente(string nome, string indirizzo, string cap, string citta, string pec,
            string email, string partitaIva, string telefono, string sdi)
        {
            try
            {
                var cDB = new ClienteDB(conn);
                cDB.Inserimento(nome, indirizzo, cap, citta, pec, email, partitaIva, telefono, sdi);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Cliente> CercaClienti()
        {
            List<Cliente> lista;
            try
            {
                var cDB = new ClienteDB(conn);
                lista = cDB.ListaClienti();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Cliente> CercaClientiNome(string n)
        {
            List<Cliente> lista;
            try
            {
                var cDB = new ClienteDB(conn);
                lista = cDB.ListaClienti(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Cliente CercaClientiId(int id)
        {
            Cliente cliente;
            try
            {
                var cDB = new ClienteDB(conn);
                cliente = cDB.CercaCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return cliente;
        }
        public List<Cliente> FiltraClienti(string s, string g)
        {
            List<Cliente> cliente;
            try
            {
                var cDB = new ClienteDB(conn);
                cliente = cDB.FiltroCliente(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return cliente;
        }
        public void UpdateCliente(int id, string nome, string indirizzo, string cap, string citta, string pec,
            string email, string partitaIva, string telefono, string sdi)
        {
            try
            {
                var cDB = new ClienteDB(conn);
                cDB.AggiornaCliente(id, nome, indirizzo, cap, citta, pec, email, partitaIva, telefono, sdi);
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
                var cDB = new ClienteDB(conn);
                cDB.RimuoviCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoContatto(string nome, string indirizzo, string cap, string citta, string pec,
            string email, string partitaIva, string CLIENTI, string cellulare, string telefono, string ruolo)
        {
            try
            {
                var cDB = new ContattoDB(conn);
                cDB.Inserimento(nome, indirizzo, cap, citta, pec, email, partitaIva, CLIENTI, cellulare, telefono, ruolo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Contatto> CercaContatti()
        {
            List<Contatto> lista;
            try
            {
                var cDB = new ContattoDB(conn);
                lista = cDB.ListaContatti();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Contatto> CercaContattoNome(string n)
        {
            List<Contatto> lista;
            try
            {
                var cDB = new ContattoDB(conn);
                lista = cDB.ListaClienti(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Contatto CercaContattoId(int id)
        {
            Contatto contatto;
            try
            {
                var cDB = new ContattoDB(conn);
                contatto = cDB.CercaContatto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public List<Contatto> FiltraContratto(string s, string g)
        {
            List<Contatto> contattos;
            try
            {
                var cDB = new ContattoDB(conn);
                contattos = cDB.FiltroContatto(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contattos;
        }
        public void UpdateContatto(int id, string nome, string indirizzo, string cap, string citta, string pec,
            string email, string partitaIva, int CLIENTI, string cellulare, string telefono, string ruolo)
        {
            try
            {
                var cDB = new ContattoDB(conn);
                cDB.AggiornaContatto(id, nome, indirizzo, cap, citta, pec, email, partitaIva, CLIENTI, cellulare,
                    telefono, ruolo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaContatto(int id)
        {
            try
            {
                var cDB = new ContattoDB(conn);
                cDB.RimuoviContatto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoCommessa(int numero, int anno, string settore, string commessa, int preventivo, int cliente, string settoreintero, string cantiere, string note, bool chiusa, DateTime datachiusura, bool fatturata, DateTime datafattura, int acconti, int pagamenti, DateTime datainserimento, double importo)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.Inserimento(numero, anno, settore, commessa, preventivo, cliente, settoreintero, note, cantiere, chiusa, datachiusura, fatturata, datafattura, acconti, pagamenti, datainserimento, importo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Commessa> CercaCommessa()
        {
            List<Commessa> lista;
            try
            {
                var bDB = new CommessaDB(conn);
                lista = bDB.ListaCommesse();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Commessa> CercaCommessa(string n)
        {
            List<Commessa> lista;
            try
            {
                var bDB = new CommessaDB(conn);
                lista = bDB.ListaCommesse(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Commessa CercaCommessa(int id)
        {
            Commessa contatto;
            try
            {
                var bDB = new CommessaDB(conn);
                contatto = bDB.CercaCommesse(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public List<Commessa> FiltraCommessa(string s, string g)
        {
            List<Commessa> contatto;
            try
            {
                var bDB = new CommessaDB(conn);
                contatto = bDB.FiltroCommesse(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public void UpdateCommessa(int id, int numero, int anno, string settore, string commessa, int preventivo, int cliente, string settoreintero, string cantiere, string note, bool chiusa, DateTime datachiusura, bool fatturata, DateTime datafattura, int acconti, int pagamenti, DateTime datainserimento, double importo)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.AggiornaCommesse(id, numero, anno, settore, commessa, preventivo, cliente, settoreintero, cantiere, note, chiusa, datachiusura, fatturata, datafattura, acconti, pagamenti, datainserimento, importo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void UpdateCommessa(int id, string note, int numero)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.AggiornaCommesse(id, note, numero);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaCommessa(int id)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.RimuoviCommessa(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoPreventivo(int numero, int anno, string settore, int commessa, int cliente, String settoreIntero, DateTime dataInserimento, String cantiere, String note, double importo, Boolean inviato, DateTime dataInvio, Boolean accettazione, DateTime dataAccettazione, String commessaCompleta)
        {
            try
            {
                var bDB = new PreventiviDB(conn);
                bDB.Inserimento(numero, anno, settore, commessa, cliente, settoreIntero, dataInserimento, cantiere, note, importo, inviato, dataInvio, accettazione, dataAccettazione, commessaCompleta);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Preventivo> CercaPreventivo()
        {
            List<Preventivo> lista;
            try
            {
                var bDB = new PreventiviDB(conn);
                lista = bDB.ListaPreventivi();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Preventivo> CercaPreventivo(string n)
        {
            List<Preventivo> lista;
            try
            {
                var bDB = new PreventiviDB(conn);
                lista = bDB.ListaCommesse(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Preventivo CercaPreventivo(int id)
        {
            Preventivo contatto;
            try
            {
                var bDB = new PreventiviDB(conn);
                contatto = bDB.CercaPreventivo(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public List<Preventivo> FiltraPreventivo(string s, string g)
        {
            List<Preventivo> contatto;
            try
            {
                var bDB = new PreventiviDB(conn);
                contatto = bDB.FiltroCommesse(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public void InserimentoAcconti(double importo, string note, string desc, DateTime datainserimento, DateTime dataFattura, string noteFattura, int commessa)
        {
            try
            {
                var bDB = new AccontiDB(conn);
                bDB.Inserimento(importo, note, desc, datainserimento, dataFattura, noteFattura, commessa);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Acconto> CercaAcconti()
        {
            List<Acconto> lista;
            try
            {
                var bDB = new AccontiDB(conn);
                lista = bDB.ListaAcconti();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Acconto> CercaAcconti(string n)
        {
            List<Acconto> lista;
            try
            {
                var bDB = new AccontiDB(conn);
                lista = bDB.ListaAcconti(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Acconto CercaAcconti(int id)
        {
            Acconto contatto;
            try
            {
                var bDB = new AccontiDB(conn);
                contatto = bDB.CercaAcconto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public List<Acconto> FiltraAcconti(string s, string g)
        {
            List<Acconto> contatto;
            try
            {
                var bDB = new AccontiDB(conn);
                contatto = bDB.FiltroCommesse(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public void UpdateAcconti(int id, int numero, int anno, string settore, string commessa, int preventivo, int cliente, string settoreintero, string cantiere, string note, bool chiusa, DateTime datachiusura, bool fatturata, DateTime datafattura, int acconti, int pagamenti, DateTime datainserimento, string importo)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.AggiornaCommesse(id, numero, anno, settore, commessa, preventivo, cliente, settoreintero, cantiere, note, chiusa, datachiusura, fatturata, datafattura, acconti, pagamenti, datainserimento, importo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaAcconti(int id)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.RimuoviCommessa(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

    }
    public class ClienteDB
    {
        private readonly MySqlConnection con;

        public ClienteDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(string nome, string indirizzo, string cap, string citta, string pec, string email,
            string partitaIva, string telefono, string sdi)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("INSERT INTO `CLIENTI`(`NOME`, `INDIRIZZO`, `CAP`, `CITTA`, `PEC`, `EMAIL`, `PARTITAIVA`, `TEL`, `SDI`) VALUES('" +
                    nome + "','" + indirizzo + "','" + cap + "','" + citta + "','" + pec + "','" + email + "','" +
                    partitaIva + "','" + telefono + "','" + sdi + "')", con);
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
        public List<Cliente> ListaClienti()
        {
            var lista = new List<Cliente>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CLIENTI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var cliente = new Cliente
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Tel = "" + lettore[8],
                        Sdi = "" + lettore[9]
                    };
                    lista.Add(cliente);
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
        public List<Cliente> ListaClienti(string n)
        {
            var lista = new List<Cliente>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CLIENTI` WHERE `NOME` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var cliente = new Cliente
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Tel = "" + lettore[8],
                        Sdi = "" + lettore[9]
                    };
                    lista.Add(cliente);
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
        public Cliente CercaCliente(int id)
        {
            Cliente cliente = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CLIENTI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                    cliente = new Cliente
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Tel = "" + lettore[8],
                        Sdi = "" + lettore[9]
                    };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return cliente;
        }
        public List<Cliente> FiltroCliente(string s, string g)
        {
            var cliente = new List<Cliente>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CLIENTI` WHERE `" + s + "` = '" + g + "'",
                    con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var c = new Cliente
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Tel = "" + lettore[8],
                        Sdi = "" + lettore[9]
                    };
                    cliente.Add(c);
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

            return cliente;
        }
        public void AggiornaCliente(int id, string nome, string indirizzo, string cap, string citta, string pec,
            string email, string partitaIva, string telefono, string sdi)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "UPDATE `CLIENTI` SET `NOME`='" + nome + "',`INDIRIZZO`='" + indirizzo + "',`CAP`='" +
                    cap + "',`CITTA`='" + citta + "',`PEC`='" + pec + "',`EMAIL`='" + email + "',`PARTITAIVA`='" +
                    partitaIva + "',`TELEFONOFISSO`='" + telefono + "',`SDI`='" + sdi + "' WHERE `ID` = '" + id + "'",
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
        public void RimuoviCliente(int id)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("DELETE FROM `CLIENTI` WHERE `ID` = '" + id + "'", con);
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
    public class ContattoDB
    {
        private readonly MySqlConnection con;

        public ContattoDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(string nome, string indirizzo, string cap, string citta, string pec, string email,
            string partitaIva, string CLIENTI, string cellulare, string telefono, string ruolo)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "INSERT INTO `CONTATTI`(`NOME`, `INDIRIZZO`, `CAP`, `CITTA`, `PEC`, `EMAIL`, `PARTITAIVA`, `CLIENTI`,`TELEFONOCELLULARE`,`TELEFONOFISSO`, `RUOLO`) VALUES('" +
                    nome + "','" + indirizzo + "','" + cap + "','" + citta + "','" + pec + "','" + email + "','" +
                    partitaIva + "','" + CLIENTI + "','" + cellulare + "','" + telefono + "','" + ruolo + "')", con);
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
        public List<Contatto> ListaContatti()
        {
            List<Contatto> lista = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CONTATTI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var contatto = new Contatto
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Ditta = (int)lettore[8],
                        Cellulare = "" + lettore[9],
                        Tel = "" + lettore[10],
                        Ruolo = "" + lettore[11]
                    };
                    lista.Add(contatto);
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
        public List<Contatto> ListaClienti(string n)
        {
            List<Contatto> lista = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CONTATTI` WHERE `NOME` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var contatto = new Contatto
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Ditta = (int)lettore[8],
                        Cellulare = "" + lettore[9],
                        Tel = "" + lettore[10],
                        Ruolo = "" + lettore[11]
                    };
                    lista.Add(contatto);
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
        public Contatto CercaContatto(int id)
        {
            Contatto Contatto = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CONTATTI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var contatto = new Contatto
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Ditta = (int)lettore[8],
                        Cellulare = "" + lettore[9],
                        Tel = "" + lettore[10],
                        Ruolo = "" + lettore[11]
                    };
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

            return Contatto;
        }
        public List<Contatto> FiltroContatto(string s, string g)
        {
            var contattos = new List<Contatto>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `CONTATTI` WHERE `" + s + "` = '" + g + "'",
                    con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var contatto = new Contatto
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Ditta = (int)lettore[8],
                        Cellulare = "" + lettore[9],
                        Tel = "" + lettore[10],
                        Ruolo = "" + lettore[11]
                    };
                    contattos.Add(contatto);
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

            return contattos;
        }
        public void AggiornaContatto(int id, string nome, string indirizzo, string cap, string citta, string pec,
            string email, string partitaIva, int CLIENTI, string cellulare, string telefono, string ruolo)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "UPDATE `CONTATTI` SET `NOME`='" + nome + "',`INDIRIZZO`='" + indirizzo + "',`CAP`='" +
                    cap + "',`CITTA`='" + citta + "',`PEC`='" + pec + "',`EMAIL`='" + email + "',`PARTITAIVA`='" +
                    partitaIva + "',`CLIENTI`='" + CLIENTI + "',`TELEFONOCELLULARE`='" + cellulare + "',`TELEFONOFISSO`='" +
                    telefono + "',`RUOLO`='" + ruolo + "' WHERE `ID` = '" + id + "'", con);
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
        public void RimuoviContatto(int id)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("DELETE FROM `CONTATTI` WHERE `ID` = '" + id + "'", con);
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
    public class CommessaDB
    {
        private readonly MySqlConnection con;

        public CommessaDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(int numero, int anno, string settore, string commessa, int preventivo, int cliente, string settoreintero, string cantiere, string note, bool chiusa, DateTime datachiusura, bool fatturata, DateTime datafattura, int acconti, int pagamenti, DateTime datainserimento, double importo)
        {
            try
            {
                con.Open();
                if (chiusa)
                {
                    if (fatturata)
                    {
                        var command = new MySqlCommand(
                            "INSERT INTO `COMMESSA`(`NUMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `PREVENTIVO`, `CLIENTE`, `SETTOREINTERO`, `CANTIERE`, `NOTE`, `CHIUSA`, `DATACHIUSURA`, `FATTURATA`, `DATAFATTURA`, `ACCONTI`, `PAGAMENTI`, `DATAINSERIMENTO`, `IMPORTO`) VALUES ('" +
                            numero + "','" + anno + "','" + settore + "','" + commessa + "','" + preventivo + "','" + cliente + "','" + settoreintero + "','" +
                            cantiere + "','" + note + "','" + 1 + "','" + datachiusura.ToString("yyyy/MM/dd") + "','" + 1 + "','" + datafattura.ToString("yyyy/MM/dd") + "','" + acconti + "','" + pagamenti + "','" + datainserimento.ToString("yyyy/MM/dd") + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "')", con);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        var command = new MySqlCommand(
                             "INSERT INTO `COMMESSA`(`NUMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `PREVENTIVO`, `CLIENTE`, `SETTOREINTERO`, `CANTIERE`, `NOTE`, `CHIUSA`, `DATACHIUSURA`, `FATTURATA`, `DATAFATTURA`, `ACCONTI`, `PAGAMENTI`, `DATAINSERIMENTO`, `IMPORTO`) VALUES ('" +
                             numero + "','" + anno + "','" + settore + "','" + commessa + "','" + preventivo + "','" + cliente + "','" + settoreintero + "','" +
                             cantiere + "','" + note + "','" + 1 + "','" + datachiusura.ToString("yyyy/MM/dd") + "','" + 0 + "','" + datafattura.ToString("yyyy/MM/dd") + "','" + acconti + "','" + pagamenti + "','" + datainserimento.ToString("yyyy/MM/dd") + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "')", con);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    if (fatturata)
                    {
                        var command = new MySqlCommand(
                            "INSERT INTO `COMMESSA`(`NUMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `PREVENTIVO`, `CLIENTE`, `SETTOREINTERO`, `CANTIERE`, `NOTE`, `CHIUSA`, `DATACHIUSURA`, `FATTURATA`, `DATAFATTURA`, `ACCONTI`, `PAGAMENTI`, `DATAINSERIMENTO`, `IMPORTO`) VALUES ('" +
                            numero + "','" + anno + "','" + settore + "','" + commessa + "','" + preventivo + "','" + cliente + "','" + settoreintero + "','" +
                            cantiere + "','" + note + "','" + 0 + "','" + datachiusura.ToString("yyyy/MM/dd") + "','" + 1 + "','" + datafattura.ToString("yyyy/MM/dd") + "','" + acconti + "','" + pagamenti + "','" + datainserimento.ToString("yyyy/MM/dd") + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "')", con);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        var command = new MySqlCommand(
                             "INSERT INTO `COMMESSA`(`NUMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `PREVENTIVO`, `CLIENTE`, `SETTOREINTERO`, `CANTIERE`, `NOTE`, `CHIUSA`, `DATACHIUSURA`, `FATTURATA`, `DATAFATTURA`, `ACCONTI`, `PAGAMENTI`, `DATAINSERIMENTO`, `IMPORTO`) VALUES ('" +
                             numero + "','" + anno + "','" + settore + "','" + commessa + "','" + preventivo + "','" + cliente + "','" + settoreintero + "','" +
                             cantiere + "','" + note + "','" + 0 + "','" + datachiusura.ToString("yyyy/MM/dd") + "','" + 0 + "','" + datafattura.ToString("yyyy/MM/dd") + "','" + acconti + "','" + pagamenti + "','" + datainserimento.ToString("yyyy/MM/dd") + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "')", con);
                        command.ExecuteNonQuery();
                    }
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
        }
        public List<Commessa> ListaCommesse()
        {
            DateTime dateValue;
            DateTime dataValue2;
            DateTime dataValue3;
            var lista = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `COMMESSA`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                    if (!(lettore[3] + "").Equals(""))
                    {
                        DateTime.TryParse(lettore[11] + "", out dateValue);
                        DateTime.TryParse(lettore[13] + "", out dataValue2);
                        DateTime.TryParse(lettore[16] + "", out dataValue3);
                        var c = new Commessa();

                        c.Id = (int)lettore[0];
                        c.numero = (int)lettore[1];
                        c.anno = (int)lettore[2];
                        c.settore = "" + lettore[3];
                        c.commessa = "" + lettore[4];
                        if (lettore[5].ToString().Equals("NULL"))
                        {
                            c.preventivo = (int)lettore[5];
                        }
                        c.cliente = (int)lettore[6];
                        c.settoreintero = "" + lettore[7];
                        c.cantiere = "" + lettore[8];
                        c.note = "" + lettore[9];
                        if (("" + lettore[10]).Equals("1"))
                        {
                            c.chiusa = true;
                        }
                        else
                        {
                            c.chiusa = false;
                        }

                        c.datachiusura = dateValue;
                        if (("" + lettore[12]).Equals("1"))
                        {
                            c.fatturata = true;
                        }
                        else
                        {
                            c.fatturata = false;
                        }
                        c.datafattura = dataValue2;
                        if (!lettore[14].ToString().Equals(""))
                            c.acconti = (int)lettore[14];
                        if (!lettore[15].ToString().Equals(""))
                            c.pagamenti = (int)lettore[15];
                        c.datainserimento = dataValue3;
                        if (!lettore[17].ToString().Equals(""))
                            c.importo = (double)lettore[17];
                        lista.Add(c);
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
        public List<Commessa> ListaCommesse(string n)
        {

            DateTime dateValue;
            DateTime dataValue2;
            DateTime dataValue3;
            DateTime dataValue4;
            var lista = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                    if (!(lettore[3] + "").Equals(""))
                    {

                        DateTime.TryParse(lettore[3] + "", out dateValue);
                        DateTime.TryParse(lettore[9] + "", out dataValue2);
                        DateTime.TryParse(lettore[10] + "", out dataValue3);
                        DateTime.TryParse(lettore[12] + "", out dataValue4);
                        var c = new Commessa();

                        c.Id = (int)lettore[0];
                        c.numero = (int)lettore[1];
                        c.anno = (int)lettore[2];
                        c.settore = "" + lettore[3];
                        c.commessa = "" + lettore[4];
                        if (lettore[5].ToString().Equals("NULL"))
                        {
                            c.preventivo = (int)lettore[5];
                        }
                        c.cliente = (int)lettore[6];
                        c.settoreintero = "" + lettore[7];
                        c.cantiere = "" + lettore[8];
                        c.note = "" + lettore[9];
                        if ((int)lettore[10] == 1)
                        {
                            c.chiusa = true;
                        }
                        else
                        {
                            c.chiusa = false;
                        }
                        c.datachiusura = dateValue;
                        if ((int)lettore[12] == 1)
                        {
                            c.fatturata = true;
                        }
                        else
                        {
                            c.fatturata = false;
                        }
                        c.datafattura = dataValue2;
                        c.acconti = (int)lettore[14];
                        c.pagamenti = (int)lettore[15];
                        c.datainserimento = dataValue3;
                        c.importo = (double)lettore[17];
                        lista.Add(c);
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
        public Commessa CercaCommesse(int id)
        {

            DateTime dateValue = DateTime.Today;
            DateTime dataValue2;
            DateTime dataValue3;
            DateTime dataValue4;
            Commessa commessa = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                    DateTime.TryParse(lettore[3] + "", out dateValue);
                DateTime.TryParse(lettore[9] + "", out dataValue2);
                DateTime.TryParse(lettore[10] + "", out dataValue3);
                DateTime.TryParse(lettore[12] + "", out dataValue4);
                var c = new Commessa();

                c.Id = (int)lettore[0];
                c.numero = (int)lettore[1];
                c.anno = (int)lettore[2];
                c.settore = "" + lettore[3];
                c.commessa = "" + lettore[4];
                if (lettore[5].ToString().Equals("NULL"))
                {
                    c.preventivo = (int)lettore[5];
                }
                c.cliente = (int)lettore[6];
                c.settoreintero = "" + lettore[7];
                c.cantiere = "" + lettore[8];
                c.note = "" + lettore[9];
                if ((int)lettore[10] == 1)
                {
                    c.chiusa = true;
                }
                else
                {
                    c.chiusa = false;
                }
                c.datachiusura = dateValue;
                if ((int)lettore[12] == 1)
                {
                    c.fatturata = true;
                }
                else
                {
                    c.fatturata = false;
                }
                c.datafattura = dataValue2;
                c.acconti = (int)lettore[14];
                c.pagamenti = (int)lettore[15];
                c.datainserimento = dataValue3;
                c.importo = (double)lettore[17];
                commessa = c;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return commessa;
        }
        public List<Commessa> FiltroCommesse(string s, string g)
        {

            DateTime dateValue = DateTime.Today;
            DateTime dataValue2;
            DateTime dataValue3;
            DateTime dataValue4;
            var commessa = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                    DateTime.TryParse(lettore[3] + "", out dateValue);
                DateTime.TryParse(lettore[9] + "", out dataValue2);
                DateTime.TryParse(lettore[10] + "", out dataValue3);
                DateTime.TryParse(lettore[12] + "", out dataValue4);
                var c = new Commessa();

                c.Id = (int)lettore[0];
                c.numero = (int)lettore[1];
                c.anno = (int)lettore[2];
                c.settore = "" + lettore[3];
                c.commessa = "" + lettore[4];
                if (lettore[5].ToString().Equals("NULL"))
                {
                    c.preventivo = (int)lettore[5];
                }
                c.cliente = (int)lettore[6];
                c.settoreintero = "" + lettore[7];
                c.cantiere = "" + lettore[8];
                c.note = "" + lettore[9];
                if ((int)lettore[10] == 1)
                {
                    c.chiusa = true;
                }
                else
                {
                    c.chiusa = false;
                }
                c.datachiusura = dateValue;
                if ((int)lettore[12] == 1)
                {
                    c.fatturata = true;
                }
                else
                {
                    c.fatturata = false;
                }
                c.datafattura = dataValue2;
                c.acconti = (int)lettore[14];
                c.pagamenti = (int)lettore[15];
                c.datainserimento = dataValue3;
                c.importo = (double)lettore[17];
                commessa.Add(c);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return commessa;
        }
        public void AggiornaCommesse(int id, int numero, int anno, string settore, string commessa, int preventivo, int cliente, string settoreintero, string cantiere, string note, bool chiusa, DateTime datachiusura, bool fatturata, DateTime datafattura, int acconti, int pagamenti, DateTime datainserimento, double importo)
        {
            try
            {
                con.Open();
                if (chiusa)
                {
                    if (fatturata)
                    {
                        if (chiusa)
                        {
                            var command = new MySqlCommand(
                                "UPDATE `COMMESSA` SET `NUMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`PREVENTIVO`='" + preventivo + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreintero + "',`CANTIERE`='" + cantiere + "',`NOTE`='" + note + "',`CHIUSA`='" + 1 + "',`DATACHIUSURA`='" + datachiusura.ToString("yyyy/MM/dd") + "',`FATTURATA`='" + 1 + "',`DATAFATTURA`='" + datafattura.ToString("yyyy/MM/dd") + "',`ACCONTI`='" + acconti + "',`PAGAMENTI`='" + pagamenti + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE  `ID` = '" + id + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            var command = new MySqlCommand(
                                 "UPDATE `COMMESSA` SET `NUMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`PREVENTIVO`='" + preventivo + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreintero + "',`CANTIERE`='" + cantiere + "',`NOTE`='" + note + "',`CHIUSA`='" + 0 + "',`DATACHIUSURA`='" + datachiusura.ToString("yyyy/MM/dd") + "',`FATTURATA`='" + 1 + "',`DATAFATTURA`='" + datafattura.ToString("yyyy/MM/dd") + "',`ACCONTI`='" + acconti + "',`PAGAMENTI`='" + pagamenti + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE  `ID` = '" + id + "'", con);
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if (chiusa)
                        {
                            var command = new MySqlCommand(
                                "UPDATE `COMMESSA` SET `NUMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`PREVENTIVO`='" + preventivo + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreintero + "',`CANTIERE`='" + cantiere + "',`NOTE`='" + note + "',`CHIUSA`='" + 1 + "',`DATACHIUSURA`='" + datachiusura.ToString("yyyy/MM/dd") + "',`FATTURATA`='" + 0 + "',`DATAFATTURA`='" + datafattura.ToString("yyyy/MM/dd") + "',`ACCONTI`='" + acconti + "',`PAGAMENTI`='" + pagamenti + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE  `ID` = '" + id + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            var command = new MySqlCommand(
                                 "UPDATE `COMMESSA` SET `NUMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`PREVENTIVO`='" + preventivo + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreintero + "',`CANTIERE`='" + cantiere + "',`NOTE`='" + note + "',`CHIUSA`='" + 0 + "',`DATACHIUSURA`='" + datachiusura.ToString("yyyy/MM/dd") + "',`FATTURATA`='" + 0 + "',`DATAFATTURA`='" + datafattura.ToString("yyyy/MM/dd") + "',`ACCONTI`='" + acconti + "',`PAGAMENTI`='" + pagamenti + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE  `ID` = '" + id + "'", con);
                            command.ExecuteNonQuery();
                        }
                    }
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
        }
        public void AggiornaCommesse(int id, string note, int ditta)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("UPDATE `COMMESSA` SET `NOTE`='" + note + "',`DITTA`= '" + ditta + "' WHERE `ID` = '" + id + "'",
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
    public class PreventiviDB
    {
        private readonly MySqlConnection con;

        public PreventiviDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(int numero, int anno, string settore, int commessa, int cliente, String settoreIntero, DateTime dataInserimento, String cantiere, String note, double importo, Boolean inviato, DateTime dataInvio, Boolean accettazione, DateTime dataAccettazione, String commessaCompleta)
        {
            try
            {
                con.Open();
                if (inviato)
                {
                    if (accettazione)
                    {
                        var command = new MySqlCommand(
                            "INSERT INTO `PREVENTIVO`(`NUMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `CLIENTE`, `SETTOREINTERO`, `DATAINS`, `CANTIERE`, `NOTE`, `IMPORTO`, `INVIATO`, `DATAINVIO`, `ACCETTAZIONE`, `DATAACC`, `COMMESSACOMPLETA`) VALUES ('" +
                            numero + "','" + anno + "','" + settore + "','" + commessa + "','" + cliente + "','" + settoreIntero + "','" + dataInserimento.ToString("yyyy/MM/dd") + "','" +
                            cantiere + "','" + note + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + 1 + "','" + dataInvio.ToString("yyyy/MM/dd") + "','" + 1 + "','" + dataAccettazione.ToString("yyyy/MM/dd") + "','" + commessaCompleta + "')", con);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        var command = new MySqlCommand(
                             "INSERT INTO `PREVENTIVO`(`NUMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `CLIENTE`, `SETTOREINTERO`, `DATAINS`, `CANTIERE`, `NOTE`, `IMPORTO`, `INVIATO`, `DATAINVIO`, `ACCETTAZIONE`, `DATAACC`, `COMMESSACOMPLETA`) VALUES ('" +
                            numero + "','" + anno + "','" + settore + "','" + commessa + "','" + cliente + "','" + settoreIntero + "','" + dataInserimento.ToString("yyyy/MM/dd") + "','" +
                            cantiere + "','" + note + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + 1 + "','" + dataInvio.ToString("yyyy/MM/dd") + "','" + 0 + "','" + dataAccettazione.ToString("yyyy/MM/dd") + "','" + commessaCompleta + "')", con);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    if (accettazione)
                    {
                        var command = new MySqlCommand(
                             "INSERT INTO `PREVENTIVO`(`NUMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `CLIENTE`, `SETTOREINTERO`, `DATAINS`, `CANTIERE`, `NOTE`, `IMPORTO`, `INVIATO`, `DATAINVIO`, `ACCETTAZIONE`, `DATAACC`, `COMMESSACOMPLETA`) VALUES ('" +
                            numero + "','" + anno + "','" + settore + "','" + commessa + "','" + cliente + "','" + settoreIntero + "','" + dataInserimento.ToString("yyyy/MM/dd") + "','" +
                            cantiere + "','" + note + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + 0 + "','" + dataInvio.ToString("yyyy/MM/dd") + "','" + 1 + "','" + dataAccettazione.ToString("yyyy/MM/dd") + "','" + commessaCompleta + "')", con);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        var command = new MySqlCommand(
                             "INSERT INTO `PREVENTIVO`(`NUMERO`, `ANNO`, `SETTORE`, `COMMESSA`, `CLIENTE`, `SETTOREINTERO`, `DATAINS`, `CANTIERE`, `NOTE`, `IMPORTO`, `INVIATO`, `DATAINVIO`, `ACCETTAZIONE`, `DATAACC`, `COMMESSACOMPLETA`) VALUES ('" +
                            numero + "','" + anno + "','" + settore + "','" + commessa + "','" + cliente + "','" + settoreIntero + "','" + dataInserimento.ToString("yyyy/MM/dd") + "','" +
                            cantiere + "','" + note + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + 0 + "','" + dataInvio.ToString("yyyy/MM/dd") + "','" + 0 + "','" + dataAccettazione.ToString("yyyy/MM/dd") + "','" + commessaCompleta + "')", con);
                        command.ExecuteNonQuery();
                    }
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
        }
        public List<Preventivo> ListaPreventivi()
        {
            DateTime dateValue;
            DateTime dataValue2;
            DateTime dataValue3;
            var lista = new List<Preventivo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PREVENTIVO`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[7] + "", out dateValue);
                    DateTime.TryParse(lettore[12] + "", out dataValue2);
                    DateTime.TryParse(lettore[14] + "", out dataValue3);
                    var c = new Preventivo();

                    c.Id = (int)lettore[0];
                    c.numero = (int)lettore[1];
                    c.anno = (int)lettore[2];
                    c.settore = "" + lettore[3];
                    if (!lettore[4].ToString().Equals("NULL"))
                    {
                        c.commessa = (int)lettore[4];
                    }
                    c.cliente = (int)lettore[5];
                    c.settoreintero = "" + lettore[6];
                    c.dataInserimento = dateValue;
                    c.cantiere = "" + lettore[8];
                    c.note = "" + lettore[9];
                    if (!lettore[10].ToString().Equals("NULL"))
                    {
                        c.importo = (double)lettore[10];
                    }
                    if (("" + lettore[11]).Equals("1"))
                    {
                        c.inviato = true;
                    }
                    else
                    {
                        c.inviato = false;
                    }
                    c.dataInvio = dataValue2;
                    if (("" + lettore[13]).Equals("1"))
                    {
                        c.accettazione = true;
                    }
                    else
                    {
                        c.accettazione = false;
                    }
                    c.dataAccettazione = dataValue3;
                    c.commessaCompleta = "" + lettore[15];
                    lista.Add(c);
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
        public List<Preventivo> ListaCommesse(string n)
        {

            DateTime dateValue;
            DateTime dataValue2;
            DateTime dataValue3;
            var lista = new List<Preventivo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PREVENTIVO` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[7] + "", out dateValue);
                    DateTime.TryParse(lettore[12] + "", out dataValue2);
                    DateTime.TryParse(lettore[14] + "", out dataValue3);
                    var c = new Preventivo();

                    c.Id = (int)lettore[0];
                    c.numero = (int)lettore[1];
                    c.anno = (int)lettore[2];
                    c.settore = "" + lettore[3];
                    if (!lettore[4].ToString().Equals("NULL"))
                    {
                        c.commessa = (int)lettore[4];
                    }
                    c.cliente = (int)lettore[5];
                    c.settoreintero = "" + lettore[6];
                    c.dataInserimento = dateValue;
                    c.cantiere = "" + lettore[8];
                    c.note = "" + lettore[9];
                    if (!lettore[10].ToString().Equals("NULL"))
                    {
                        c.importo = (double)lettore[10];
                    }
                    if (("" + lettore[11]).Equals("1"))
                    {
                        c.inviato = true;
                    }
                    else
                    {
                        c.inviato = false;
                    }
                    c.dataInvio = dataValue2;
                    if (("" + lettore[13]).Equals("1"))
                    {
                        c.accettazione = true;
                    }
                    else
                    {
                        c.accettazione = false;
                    }
                    c.dataAccettazione = dataValue3;
                    c.commessaCompleta = "" + lettore[15];
                    lista.Add(c);
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
        public Preventivo CercaPreventivo(int id)
        {

            DateTime dateValue = DateTime.Today;
            DateTime dataValue2;
            DateTime dataValue3;
            Preventivo commessa = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PREVENTIVO` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[7] + "", out dateValue);
                    DateTime.TryParse(lettore[12] + "", out dataValue2);
                    DateTime.TryParse(lettore[14] + "", out dataValue3);
                    var c = new Preventivo();

                    c.Id = (int)lettore[0];
                    c.numero = (int)lettore[1];
                    c.anno = (int)lettore[2];
                    c.settore = "" + lettore[3];
                    if (!lettore[4].ToString().Equals("NULL"))
                    {
                        c.commessa = (int)lettore[4];
                    }
                    c.cliente = (int)lettore[5];
                    c.settoreintero = "" + lettore[6];
                    c.dataInserimento = dateValue;
                    c.cantiere = "" + lettore[8];
                    c.note = "" + lettore[9];
                    if (!lettore[10].ToString().Equals("NULL"))
                    {
                        c.importo = (double)lettore[10];
                    }
                    if (("" + lettore[11]).Equals("1"))
                    {
                        c.inviato = true;
                    }
                    else
                    {
                        c.inviato = false;
                    }
                    c.dataInvio = dataValue2;
                    if (("" + lettore[13]).Equals("1"))
                    {
                        c.accettazione = true;
                    }
                    else
                    {
                        c.accettazione = false;
                    }
                    c.dataAccettazione = dataValue3;
                    c.commessaCompleta = "" + lettore[15];
                    commessa = c;
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

            return commessa;
        }
        public List<Preventivo> FiltroCommesse(string s, string g)
        {

            DateTime dateValue = DateTime.Today;
            DateTime dataValue2;
            DateTime dataValue3;
            var commessa = new List<Preventivo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PREVENTIVO` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();


                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[7] + "", out dateValue);
                    DateTime.TryParse(lettore[12] + "", out dataValue2);
                    DateTime.TryParse(lettore[14] + "", out dataValue3);
                    var c = new Preventivo();

                    c.Id = (int)lettore[0];
                    c.numero = (int)lettore[1];
                    c.anno = (int)lettore[2];
                    c.settore = "" + lettore[3];
                    if (!lettore[4].ToString().Equals("NULL"))
                    {
                        c.commessa = (int)lettore[4];
                    }
                    c.cliente = (int)lettore[5];
                    c.settoreintero = "" + lettore[6];
                    c.dataInserimento = dateValue;
                    c.cantiere = "" + lettore[8];
                    c.note = "" + lettore[9];
                    if (!lettore[10].ToString().Equals("NULL"))
                    {
                        c.importo = (double)lettore[10];
                    }
                    if (("" + lettore[11]).Equals("1"))
                    {
                        c.inviato = true;
                    }
                    else
                    {
                        c.inviato = false;
                    }
                    c.dataInvio = dataValue2;
                    if (("" + lettore[13]).Equals("1"))
                    {
                        c.accettazione = true;
                    }
                    else
                    {
                        c.accettazione = false;
                    }
                    c.dataAccettazione = dataValue3;
                    c.commessaCompleta = "" + lettore[15];
                    commessa.Add(c);
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

            return commessa;
        }
        /*public void AggiornaCommesse(int id, int numero, int anno, string settore, string commessa, int preventivo, int cliente, string settoreintero, string cantiere, string note, bool chiusa, DateTime datachiusura, bool fatturata, DateTime datafattura, int acconti, int pagamenti, DateTime datainserimento, string importo)
        {
            try
            {
                con.Open();
                if (chiusa)
                {
                    if (fatturata)
                    {
                        if (chiusa)
                        {
                            var command = new MySqlCommand(
                                "UPDATE `COMMESSA` SET `NUMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`PREVENTIVO`='" + preventivo + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreintero + "',`CANTIERE`='" + cantiere + "',`NOTE`='" + note + "',`CHIUSA`='" + 1 + "',`DATACHIUSURA`='" + datachiusura.ToString("yyyy/MM/dd") + "',`FATTURATA`='" + 1 + "',`DATAFATTURA`='" + datafattura.ToString("yyyy/MM/dd") + "',`ACCONTI`='" + acconti + "',`PAGAMENTI`='" + pagamenti + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE  `ID` = '" + id + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            var command = new MySqlCommand(
                                 "UPDATE `COMMESSA` SET `NUMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`PREVENTIVO`='" + preventivo + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreintero + "',`CANTIERE`='" + cantiere + "',`NOTE`='" + note + "',`CHIUSA`='" + 0 + "',`DATACHIUSURA`='" + datachiusura.ToString("yyyy/MM/dd") + "',`FATTURATA`='" + 1 + "',`DATAFATTURA`='" + datafattura.ToString("yyyy/MM/dd") + "',`ACCONTI`='" + acconti + "',`PAGAMENTI`='" + pagamenti + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE  `ID` = '" + id + "'", con);
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if (chiusa)
                        {
                            var command = new MySqlCommand(
                                "UPDATE `COMMESSA` SET `NUMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`PREVENTIVO`='" + preventivo + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreintero + "',`CANTIERE`='" + cantiere + "',`NOTE`='" + note + "',`CHIUSA`='" + 1 + "',`DATACHIUSURA`='" + datachiusura.ToString("yyyy/MM/dd") + "',`FATTURATA`='" + 0 + "',`DATAFATTURA`='" + datafattura.ToString("yyyy/MM/dd") + "',`ACCONTI`='" + acconti + "',`PAGAMENTI`='" + pagamenti + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE  `ID` = '" + id + "'", con);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            var command = new MySqlCommand(
                                 "UPDATE `COMMESSA` SET `NUMERO`='" + numero + "',`ANNO`='" + anno + "',`SETTORE`='" + settore + "',`COMMESSA`='" + commessa + "',`PREVENTIVO`='" + preventivo + "',`CLIENTE`='" + cliente + "',`SETTOREINTERO`='" + settoreintero + "',`CANTIERE`='" + cantiere + "',`NOTE`='" + note + "',`CHIUSA`='" + 0 + "',`DATACHIUSURA`='" + datachiusura.ToString("yyyy/MM/dd") + "',`FATTURATA`='" + 0 + "',`DATAFATTURA`='" + datafattura.ToString("yyyy/MM/dd") + "',`ACCONTI`='" + acconti + "',`PAGAMENTI`='" + pagamenti + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE  `ID` = '" + id + "'", con);
                            command.ExecuteNonQuery();
                        }
                    }
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
        }
        public void AggiornaCommesse(int id, string note, int ditta)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("UPDATE `COMMESSA` SET `NOTE`='" + note + "',`DITTA`= '" + ditta + "' WHERE `ID` = '" + id + "'",
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
        }*/
    }
    public class AccontiDB
    {
        private readonly MySqlConnection con;

        public AccontiDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(double importo, string note, string desc, DateTime datainserimento, DateTime dataFattura, string noteFattura, int commessa)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "INSERT INTO `ACCONTI`(`IMPORTO`, `NOTE`, `DESC`, `DATAINSERIMENTO`, `DATAFATTURA`, `NOTEFATTURA`, `COMMESSA`) VALUES ('" +
                    importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + note + "','" + desc + "','" + datainserimento.ToString("yyyy/MM/dd") + "','" + dataFattura.ToString("yyyy/MM/dd") + "','" + noteFattura + "','" + commessa + "')", con);
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
        public List<Acconto> ListaAcconti()
        {
            DateTime dataValue;
            DateTime dataValue2;
            var lista = new List<Acconto>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `ACCONTI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    if (lettore[4].Equals(""))
                    {
                        DateTime.TryParse("01-01-0001", out dataValue);
                    }
                    else
                    {
                        DateTime.TryParse(lettore[4] + "", out dataValue);

                    }

                    if (lettore[5].Equals(""))
                    {
                        DateTime.TryParse("01-01-0001", out dataValue2);
                    }
                    else
                    {
                        DateTime.TryParse(lettore[5] + "", out dataValue2);

                    }
                    Acconto a = new Acconto();
                    a.Id = (int)lettore[0];
                    a.Importo = (double)lettore[1];
                    a.Note = "" + lettore[2];
                    a.Desc = "" + lettore[3];
                    a.DataInserimento = dataValue;
                    a.DataFattura = dataValue2;
                    a.NoteFattura = "" + lettore[6];
                    a.Commessa = (int)lettore[7];

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
        public List<Acconto> ListaAcconti(string n)
        {

            DateTime dataValue;
            DateTime dataValue2;
            var lista = new List<Acconto>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `ACCONTI` WHERE `ID` = " + n, con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    if (lettore[4].Equals(""))
                    {
                        DateTime.TryParse("01-01-0001", out dataValue);
                    }
                    else
                    {
                        DateTime.TryParse(lettore[4] + "", out dataValue);

                    }

                    if (lettore[5].Equals(""))
                    {
                        DateTime.TryParse("01-01-0001", out dataValue2);
                    }
                    else
                    {
                        DateTime.TryParse(lettore[5] + "", out dataValue2);

                    }
                    Acconto a = new Acconto();
                    a.Id = (int)lettore[0];
                    a.Importo = (double)lettore[1];
                    a.Note = "" + lettore[2];
                    a.Desc = "" + lettore[3];
                    a.DataInserimento = dataValue;
                    a.DataFattura = dataValue2;
                    a.NoteFattura = "" + lettore[6];
                    a.Commessa = (int)lettore[7];

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
        public Acconto CercaAcconto(int id)
        {

            DateTime dataValue;
            DateTime dataValue2;
            Acconto a = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `ACCONTI` WHERE `ID` = " + id, con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    if (lettore[4].Equals(""))
                    {
                        DateTime.TryParse("01-01-0001", out dataValue);
                    }
                    else
                    {
                        DateTime.TryParse(lettore[4] + "", out dataValue);

                    }

                    if (lettore[5].Equals(""))
                    {
                        DateTime.TryParse("01-01-0001", out dataValue2);
                    }
                    else
                    {
                        DateTime.TryParse(lettore[5] + "", out dataValue2);

                    }
                    a = new Acconto();
                    a.Id = (int)lettore[0];
                    a.Importo = (double)lettore[1];
                    a.Note = "" + lettore[2];
                    a.Desc = "" + lettore[3];
                    a.DataInserimento = dataValue;
                    a.DataFattura = dataValue2;
                    a.NoteFattura = "" + lettore[6];
                    a.Commessa = (int)lettore[7];

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

            return a;
        }
        public List<Acconto> FiltroCommesse(string s, string g)
        {

            DateTime dataValue;
            DateTime dataValue2;
            var lista = new List<Acconto>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    if (lettore[4].Equals(""))
                    {
                        DateTime.TryParse("01-01-0001", out dataValue);
                    }
                    else
                    {
                        DateTime.TryParse(lettore[4] + "", out dataValue);

                    }

                    if (lettore[5].Equals(""))
                    {
                        DateTime.TryParse("01-01-0001", out dataValue2);
                    }
                    else
                    {
                        DateTime.TryParse(lettore[5] + "", out dataValue2);

                    }
                    Acconto a = new Acconto();
                    a.Id = (int)lettore[0];
                    a.Importo = (double)lettore[1];
                    a.Note = "" + lettore[2];
                    a.Desc = "" + lettore[3];
                    a.DataInserimento = dataValue;
                    a.DataFattura = dataValue2;
                    a.NoteFattura = "" + lettore[6];
                    a.Commessa = (int)lettore[7];
                    lista.Add(a);

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
        public void AggiornaAcconto(int id, double importo, string note, string desc, DateTime datainserimento, DateTime dataFattura, string noteFattura, int commessa)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                "UPDATE `ACCONTI` SET `IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "',`NOTE`='" + note + "',`DESC`='" + desc + "',`DATAINSERIMENTO`='" + datainserimento.ToString("yyyy/MM/dd") + "',`DATAFATTURA`='" + dataFattura + "',`NOTEFATTURA`='" + noteFattura + "',`COMMESSA`='" + commessa + "' WHERE `ID`=", con);
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
                var command = new MySqlCommand("DELETE FROM `ACCONTI` WHERE `ID` = '" + id + "'", con);
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
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public string Email { get; set; }
        public string Iva { get; set; }
        public string Tel { get; set; }
        public string Pec { get; set; }
        public string Sdi { get; set; }
    }
    public class Contatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public string Pec { get; set; }
        public string Email { get; set; }
        public string Iva { get; set; }
        public int Ditta { get; set; }
        public string Cellulare { get; set; }
        public string Tel { get; set; }
        public string Ruolo { get; set; }
    }
    public class Commessa
    {
        public int Id { get; set; }
        public int numero { get; set; }
        public int anno { get; set; }
        public string settore { get; set; }
        public string commessa { get; set; }
        public int preventivo { get; set; }
        public int cliente { get; set; }
        public string settoreintero { get; set; }
        public string cantiere { get; set; }
        public string note { get; set; }
        public bool chiusa { get; set; }
        public DateTime datachiusura { get; set; }
        public bool fatturata { get; set; }
        public DateTime datafattura { get; set; }
        public int acconti { get; set; }
        public int pagamenti { get; set; }
        public DateTime datainserimento { get; set; }
        public double importo { get; set; }
    }
    public class Preventivo
    {
        public int Id { get; set; }
        public int numero { get; set; }
        public int anno { get; set; }
        public string settore { get; set; }
        public int commessa { get; set; }
        public int preventivo { get; set; }
        public int cliente { get; set; }
        public string settoreintero { get; set; }
        public DateTime dataInserimento { get; set; }
        public string cantiere { get; set; }
        public string note { get; set; }
        public double importo { get; set; }
        public bool inviato { get; set; }
        public DateTime dataInvio { get; set; }
        public bool accettazione { get; set; }
        public DateTime dataAccettazione { get; set; }
        public string commessaCompleta { get; set; }
    }
    public class Acconto
    {
        public int Id { get; set; }
        public double Importo { get; set; }
        public String Note { get; set; }
        public String Desc { get; set; }
        public DateTime DataInserimento { get; set; }
        public DateTime DataFattura { get; set; }
        public String NoteFattura { get; set; }
        public int Commessa { get; set; }
    }
}