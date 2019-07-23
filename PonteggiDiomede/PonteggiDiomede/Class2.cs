using System;
using System.Collections.Generic;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Diomede2
{
    internal class OperazionePraticheEdili
    {
        public MySqlConnection conn = new MySqlConnection();

        public OperazionePraticheEdili(string nomeDB)
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
            string email, string partitaIva, string ditta, string cellulare, string telefono, string ruolo)
        {
            try
            {
                var cDB = new ContattoDB(conn);
                cDB.Inserimento(nome, indirizzo, cap, citta, pec, email, partitaIva, ditta, cellulare, telefono, ruolo);
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
            string email, string partitaIva, int ditta, string cellulare, string telefono, string ruolo)
        {
            try
            {
                var cDB = new ContattoDB(conn);
                cDB.AggiornaContatto(id, nome, indirizzo, cap, citta, pec, email, partitaIva, ditta, cellulare,
                    telefono, ruolo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CacellaContatto(int id)
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
        public void InserimentoRuolo(string nome, string desc)
        {
            try
            {
                var cDB = new RuoloDB(conn);
                cDB.Inserimento(nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Ruolo> CercaRuolo()
        {
            List<Ruolo> lista;
            try
            {
                var cDB = new RuoloDB(conn);
                lista = cDB.ListaRuoli();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Ruolo> CercaRuoloNome(string n)
        {
            List<Ruolo> lista;
            try
            {
                var cDB = new RuoloDB(conn);
                lista = cDB.ListaRuoli(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Ruolo CercaRuoloId(int id)
        {
            Ruolo contatto;
            try
            {
                var cDB = new RuoloDB(conn);
                contatto = cDB.CercaRuoli(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public List<Ruolo> FiltraRuolo(string s, string g)
        {
            List<Ruolo> ruolo;
            try
            {
                var cDB = new RuoloDB(conn);
                ruolo = cDB.FiltroRuoli(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return ruolo;
        }
        public void UpdateRuolo(int id, string nome, string desc)
        {
            try
            {
                var cDB = new RuoloDB(conn);
                cDB.AggiornaRuoli(id, nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaRuolo(int id)
        {
            try
            {
                var cDB = new RuoloDB(conn);
                cDB.RimuoviRuolo(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoBozza(DateTime data, double importo, String fase, string numerocommessa, int cliente, bool accettazione)
        {
            try
            {
                var bDB = new BozzaDB(conn);
                bDB.Inserimento(data, importo, fase, numerocommessa, cliente, accettazione);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Bozza> CercaBozza()
        {
            List<Bozza> lista;
            try
            {
                var bDB = new BozzaDB(conn);
                lista = bDB.ListaBozza();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Bozza> CercaBozza(string n)
        {
            List<Bozza> lista;
            try
            {
                var bDB = new BozzaDB(conn);
                lista = bDB.ListaBozza(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Bozza CercaBozzaId(int id)
        {
            Bozza contatto;
            try
            {
                var bDB = new BozzaDB(conn);
                contatto = bDB.CercaBozza(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public List<Bozza> FiltraBozza(string s, string g)
        {
            List<Bozza> contatto;
            try
            {
                var bDB = new BozzaDB(conn);
                contatto = bDB.FiltroBozza(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public void UpdateBozza(int id, DateTime data, double importo, String fase, string numerocommessa, int cliente, bool accettazione)
        {
            try
            {
                var bDB = new BozzaDB(conn);
                bDB.AggiornaBozza(id, data, importo, fase, numerocommessa, cliente, accettazione);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void UpdateBozza(int id, double importo)
        {
            try
            {
                var bDB = new BozzaDB(conn);
                bDB.AggiornaBozza(id, importo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaBozza(int id)
        {
            try
            {
                var bDB = new BozzaDB(conn);
                bDB.RimuoviBozza(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoCommessa(int ditta, string numerocommessa, DateTime data, string referente, string indirizzoCantiere, string tecnico, string note, int bozza, DateTime dataEsecuzione, DateTime dataRichiestaConsegna, String nome, DateTime dataInvio)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.Inserimento(ditta, numerocommessa, data, referente, indirizzoCantiere, tecnico, note, bozza, dataEsecuzione, dataRichiestaConsegna, nome, dataInvio);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoCommessa(int ditta, string numerocommessa, DateTime data, string referente, string indirizzoCantiere, string tecnico, string note, int bozza, String dataEsecuzione, String dataRichiestaConsegna, String nome, String dataInvio)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.Inserimento(ditta, numerocommessa, data, referente, indirizzoCantiere, tecnico, note, bozza, dataEsecuzione, dataRichiestaConsegna, nome, dataInvio);
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
        public void UpdateCommessa(int id, int ditta, string numerocommessa, DateTime data, string referente, string indirizzoCantiere, string tecnico, string note, int bozza, DateTime dataEsecuzione, DateTime dataRichiestaConsegna, String nome, DateTime dataInvio)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.AggiornaCommesse(id, ditta, numerocommessa, data, referente, indirizzoCantiere, tecnico, note, bozza, dataEsecuzione, dataRichiestaConsegna, nome, dataInvio);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void UpdateCommessa(int id, string note)
        {
            try
            {
                var bDB = new CommessaDB(conn);
                bDB.AggiornaCommesse(id, note);
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
        public void InserimentoPagamento(string numeroCommessa, double importo, string note, string fattura,
            DateTime dataFattura, DateTime data, int cliente, int commessa)
        {
            try
            {
                var bDB = new PagamentoDB(conn);
                bDB.Inserimento(numeroCommessa, importo, note, fattura, dataFattura, data, cliente, commessa);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Pagamento> CercaPagamento()
        {
            List<Pagamento> lista;
            try
            {
                var bDB = new PagamentoDB(conn);
                lista = bDB.ListaOperazione();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Pagamento> CercaPagamento(string n)
        {
            List<Pagamento> lista;
            try
            {
                var bDB = new PagamentoDB(conn);
                lista = bDB.ListaOperazione(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Pagamento CercaPagamento(int id)
        {
            Pagamento contatto;
            try
            {
                var bDB = new PagamentoDB(conn);
                contatto = bDB.CercaOperazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public List<Pagamento> FiltraPagamento(string s, string g)
        {
            List<Pagamento> contatto;
            try
            {
                var bDB = new PagamentoDB(conn);
                contatto = bDB.FiltroOperazione(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public void UpdatePagamento(int id, string numeroCommessa, double importo, string note, string fattura,
            DateTime dataFattura, DateTime data, int cliente, int commessa)
        {
            try
            {
                var bDB = new PagamentoDB(conn);
                bDB.AggiornaOperazione(id, numeroCommessa, importo, note, fattura, dataFattura, data, cliente,
                    commessa);
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
                var bDB = new PagamentoDB(conn);
                bDB.RimuoviOperazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoLavorazioni(string nome, string desc, double prezzo, int commessa, DateTime data, String assegnamento)
        {
            try
            {
                var bDB = new LavorazioneDB(conn);
                bDB.Inserimento(nome, desc, prezzo, commessa, data, assegnamento);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Lavorazioni> CercaLavorazioni()
        {
            List<Lavorazioni> lista;
            try
            {
                var bDB = new LavorazioneDB(conn);
                lista = bDB.ListaLavorazioni();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public List<Lavorazioni> CercaLavorazioni(string n)
        {
            List<Lavorazioni> lista;
            try
            {
                var bDB = new LavorazioneDB(conn);
                lista = bDB.ListaLavorazioni(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return lista;
        }
        public Lavorazioni CercaLavorazioni(int id)
        {
            Lavorazioni contatto;
            try
            {
                var bDB = new LavorazioneDB(conn);
                contatto = bDB.CercaLavorazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public List<Lavorazioni> FiltraLavorazioni(string s, string g)
        {
            List<Lavorazioni> contatto;
            try
            {
                var bDB = new LavorazioneDB(conn);
                contatto = bDB.FiltroLavorazioni(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }

            return contatto;
        }
        public void UpdateLavorazioni(int id, string nome, string desc, double prezzo, int commessa, DateTime data, String assegnamento)
        {
            try
            {
                var bDB = new LavorazioneDB(conn);
                bDB.AggiornaLavorazioni(id, nome, desc, prezzo, commessa, data, assegnamento);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaLavorazioni(int id)
        {
            try
            {
                var bDB = new LavorazioneDB(conn);
                bDB.RimuoviLavorazioni(id);
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
                var command = new MySqlCommand("INSERT INTO `ANAGRAFICACLIENTI`(`NOME`, `INDIRIZZO`, `CAP`, `CITTA`, `PEC`, `EMAIL`, `PARTITAIVA`, `TELEFONOFISSO`, `SDI`) VALUES('" +
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
                var command = new MySqlCommand("SELECT * FROM `ANAGRAFICACLIENTI`", con);
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
                var command = new MySqlCommand("SELECT * FROM `ANAGRAFICACLIENTI` WHERE `NOME` = '" + n + "'", con);
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
                var command = new MySqlCommand("SELECT * FROM `ANAGRAFICACLIENTI` WHERE `ID` = '" + id + "'", con);
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
                var command = new MySqlCommand("SELECT * FROM `ANAGRAFICACLIENTI` WHERE `" + s + "` = '" + g + "'",
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
                    "UPDATE `ANAGRAFICACLIENTI` SET `NOME`='" + nome + "',`INDIRIZZO`='" + indirizzo + "',`CAP`='" +
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
                var command = new MySqlCommand("DELETE FROM `ANAGRAFICACLIENTI` WHERE `ID` = '" + id + "'", con);
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
            string partitaIva, string ditta, string cellulare, string telefono, string ruolo)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "INSERT INTO `ANAGRAFICACONTATTI`(`NOME`, `INDIRIZZO`, `CAP`, `CITTA`, `PEC`, `EMAIL`, `PARTITAIVA`, `DITTA`,`TELEFONOCELLULARE`,`TELEFONOFISSO`, `RUOLO`) VALUES('" +
                    nome + "','" + indirizzo + "','" + cap + "','" + citta + "','" + pec + "','" + email + "','" +
                    partitaIva + "','" + ditta + "','" + cellulare + "','" + telefono + "','" + ruolo + "')", con);
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
                var command = new MySqlCommand("SELECT * FROM `ANAGRAFICACONTATTI`", con);
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
                        Ruolo = (int)lettore[11]
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
                var command = new MySqlCommand("SELECT * FROM `ANAGRAFICACONTATTI` WHERE `NOME` = '" + n + "'", con);
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
                        Ruolo = (int)lettore[11]
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
                var command = new MySqlCommand("SELECT * FROM `ANAGRAFICACONTATTI` WHERE `ID` = '" + id + "'", con);
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
                        Ruolo = (int)lettore[11]
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
                var command = new MySqlCommand("SELECT * FROM `ANAGRAFICACONTATTI` WHERE `" + s + "` = '" + g + "'",
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
                        Ruolo = (int)lettore[11]
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
            string email, string partitaIva, int ditta, string cellulare, string telefono, string ruolo)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "UPDATE `ANAGRAFICACONTATTI` SET `NOME`='" + nome + "',`INDIRIZZO`='" + indirizzo + "',`CAP`='" +
                    cap + "',`CITTA`='" + citta + "',`PEC`='" + pec + "',`EMAIL`='" + email + "',`PARTITAIVA`='" +
                    partitaIva + "',`DITTA`='" + ditta + "',`TELEFONOCELLULARE`='" + cellulare + "',`TELEFONOFISSO`='" +
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
                var command = new MySqlCommand("DELETE FROM `ANAGRAFICACONTATTI` WHERE `ID` = '" + id + "'", con);
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
        public void Inserimento(string nome, string desc)
        {
            try
            {
                con.Open();
                var command =
                    new MySqlCommand("INSERT INTO `RUOLI`(`NOME`, `DESCRIZIONE`) VALUES('" + nome + "','" + desc + "')", con);
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
        public List<Ruolo> ListaRuoli()
        {
            var lista = new List<Ruolo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `RUOLI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var ruolo = new Ruolo
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Desc = "" + lettore[2]
                    };
                    lista.Add(ruolo);
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
        public List<Ruolo> ListaRuoli(string n)
        {
            var lista = new List<Ruolo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `RUOLI` WHERE `NOME` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var ruolo = new Ruolo
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Desc = "" + lettore[2]
                    };
                    lista.Add(ruolo);
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
        public Ruolo CercaRuoli(int id)
        {
            Ruolo ruolo = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `RUOLI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var r = new Ruolo
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Desc = "" + lettore[2]
                    };
                    ruolo = r;
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

            return ruolo;
        }
        public List<Ruolo> FiltroRuoli(string s, string g)
        {
            var ruolo = new List<Ruolo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `RUOLI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var r = new Ruolo
                    {
                        Id = (int)lettore[0],
                        Nome = "" + lettore[1],
                        Desc = "" + lettore[2]
                    };
                    ruolo.Add(r);
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

            return ruolo;
        }
        public void AggiornaRuoli(int id, string nome, string desc)
        {
            try
            {
                con.Open();
                var command =
                    new MySqlCommand(
                        "UPDATE `RUOLI` SET `NOME`='" + nome + "',`DESC`='" + desc + "' WHERE `ID` = '" + id + "'",
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
        public void RimuoviRuolo(int id)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("DELETE FROM `RUOLI` WHERE `ID` = '" + id + "'", con);
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

    public class BozzaDB
    {
        private readonly MySqlConnection con;

        public BozzaDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(DateTime data, double importo, String fase, string numerocommessa, int cliente, bool accettazione)
        {
            try
            {
                con.Open();
                MySqlCommand command;
                if (accettazione)
                    command = new MySqlCommand(
                        "INSERT INTO `BOZZA`(`DATA`,`IMPORTO`,`FASEPROGETTO`,`NUMEROCOMMESSA`,`CLIENTE`,`ACCETTAZIONE`) VALUES('" +
                        data.ToString("yyyy/MM/dd") + "','" +
                        importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + fase + "','" + numerocommessa + "','" +
                        cliente + "','1')", con);
                else
                    command = new MySqlCommand(
                        "INSERT INTO `BOZZA`(`DATA`,`IMPORTO`,`FASEPROGETTO`,`NUMEROCOMMESSA`,`CLIENTE`,`ACCETTAZIONE`) VALUES('" +
                        data.ToString("yyyy/MM/dd") + "','" +
                        importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + fase + "','" + numerocommessa + "','" +
                        cliente + "','0')", con);
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
        public List<Bozza> ListaBozza()
        {
            var lista = new List<Bozza>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `BOZZA`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var bozza = new Bozza
                    {
                        Id = (int)lettore[0],
                        Data = (DateTime)lettore[1],
                        Importo = (double)lettore[2],
                        FaseProgetto = "" + lettore[3],
                        IdentificativoPreventivo = "" + lettore[4],
                        Cliente = (int)lettore[5],
                        Accettazione = (bool)lettore[6]
                    };
                    lista.Add(bozza);
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
        public List<Bozza> ListaBozza(string n)
        {
            var lista = new List<Bozza>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `BOZZA` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var bozza = new Bozza
                    {
                        Id = (int)lettore[0],
                        Data = (DateTime)lettore[1],
                        Importo = (double)lettore[2],
                        FaseProgetto = "" + lettore[3],
                        IdentificativoPreventivo = "" + lettore[4],
                        Cliente = (int)lettore[5],
                        Accettazione = (bool)lettore[6]
                    };
                    lista.Add(bozza);
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
        public Bozza CercaBozza(int id)
        {
            Bozza bozza = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `BOZZA` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var b = new Bozza
                    {

                        Id = (int)lettore[0],
                        Data = (DateTime)lettore[1],
                        Importo = (double)lettore[2],
                        FaseProgetto = "" + lettore[3],
                        IdentificativoPreventivo = "" + lettore[4],
                        Cliente = (int)lettore[5],
                        Accettazione = (bool)lettore[6]
                    };
                    bozza = b;
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

            return bozza;
        }
        public List<Bozza> FiltroBozza(string s, string g)
        {
            var bozza = new List<Bozza>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `BOZZA` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var b = new Bozza
                    {
                        Id = (int)lettore[0],
                        Data = (DateTime)lettore[1],
                        Importo = (double)lettore[2],
                        FaseProgetto = "" + lettore[3],
                        IdentificativoPreventivo = "" + lettore[4],
                        Cliente = (int)lettore[5],
                        Accettazione = (bool)lettore[6]
                    };
                    bozza.Add(b);
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

            return bozza;
        }
        public void AggiornaBozza(int id, DateTime data, double importo, String fase, string numerocommessa, int cliente, bool accettazione)
        {
            try
            {
                con.Open();
                MySqlCommand command;
                if (accettazione)
                    command = new MySqlCommand(
                        "UPDATE `BOZZA` SET `DATA`='" + data.ToString("yyyy/MM/dd") + "',`FASEPROGETTO`='" + fase +
                        "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +
                        "',`NUMEROCOMMESSA`='" + numerocommessa + "',`CLIENTE`='" + cliente +
                        "',`ACCETTAZIONE`='1' WHERE `ID` = '" + id + "'", con);
                else
                    command = new MySqlCommand(
                        "UPDATE `BOZZA` SET `DATA`='" + data.ToString("yyyy/MM/dd") + "',`FASEPROGETTO`='" + fase +
                        "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +
                        "',`NUMEROCOMMESSA`='" + numerocommessa + "',`CLIENTE`='" + cliente +
                        "',`ACCETTAZIONE`='0' WHERE `ID` = '" + id + "'", con);
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
        public void AggiornaBozza(int id, double importo)
        {
            try
            {
                con.Open();
                MySqlCommand command;

                command = new MySqlCommand(
                    "UPDATE `BOZZA` SET `IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +
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
        public void RimuoviBozza(int id)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("DELETE FROM `BOZZA` WHERE `ID` = '" + id + "'", con);
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

        public void Inserimento(int ditta, string numerocommessa, DateTime data, string referente, string indirizzoCantiere, string tecnico, string note, int bozza, DateTime dataEsecuzione, DateTime dataRichiestaConsegna, String nome, DateTime dataInvio)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "INSERT INTO `COMMESSA`(`DITTA`, `NUMEROCOMMESSA`, `DATA`, `REFERENTE`, `INDIRIZZOCANTIERE`, `TECNICOINTERNO`, `NOTE`, `BOZZA`, `DATAESECUZIONE`, `DATARICHIESTACONSEGNA`, `INVIO`, `DATAINVIO`) VALUES('" +
                    ditta + "','" + numerocommessa + "','" + data.ToString("yyyy/MM/dd") + "','" + referente + "','" + indirizzoCantiere + "','" + tecnico + "','" + note + "','" +
                    bozza + "','" + dataEsecuzione.ToString("yyyy/MM/dd") + "','" + dataRichiestaConsegna.ToString("yyyy/MM/dd") + "','" + nome + "','" + dataInvio.ToString("yyyy/MM/dd hh:mm") + "')", con);
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
        public void Inserimento(int ditta, string numerocommessa, DateTime data, string referente, string indirizzoCantiere, string tecnico, string note, int bozza, String dataEsecuzione, String dataRichiestaConsegna, String nome, String dataInvio)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "INSERT INTO `COMMESSA`(`DITTA`, `NUMEROCOMMESSA`, `DATA`, `REFERENTE`, `INDIRIZZOCANTIERE`, `TECNICOINTERNO`, `NOTE`, `BOZZA`, `DATAESECUZIONE`, `DATARICHIESTACONSEGNA`, `INVIO`, `DATAINVIO`) VALUES('" +
                    ditta + "','" + numerocommessa + "','" + data.ToString("yyyy/MM/dd") + "','" + referente + "','" + indirizzoCantiere + "','" + tecnico + "','" + note + "','" +
                    bozza + "'," + dataEsecuzione + "," + dataRichiestaConsegna + ",'" + nome + "'," + dataInvio + ")", con);
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
        public List<Commessa> ListaCommesse()
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
                var command = new MySqlCommand("SELECT * FROM `COMMESSA`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                    if (!(lettore[3] + "").Equals(""))
                    {
                        DateTime.TryParse(lettore[3] + "", out dateValue);
                        DateTime.TryParse(lettore[9] + "", out dataValue2);
                        DateTime.TryParse(lettore[10] + "", out dataValue3);
                        DateTime.TryParse(lettore[12] + "", out dataValue4);
                        var c = new Commessa
                        {
                            Id = (int)lettore[0],
                            Ditta = (int)lettore[1],
                            NumeroCommessa = "" + lettore[2],
                            Data = dateValue,
                            Referente = "" + lettore[4],
                            IndirizzoCantiere = "" + lettore[5],
                            TecnicoInterno = "" + lettore[6],
                            Note = "" + lettore[7],
                            Bozza = (int)lettore[8],
                            DataEsecuzione = dataValue2,
                            DataRichestaConsegna = dataValue3,
                            Invio = "" + lettore [11],
                            DataOraInvio = dataValue4
                        };
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
                        var c = new Commessa
                        {
                            Id = (int)lettore[0],
                            Ditta = (int)lettore[1],
                            NumeroCommessa = "" + lettore[2],
                            Data = dateValue,
                            Referente = "" + lettore[4],
                            IndirizzoCantiere = "" + lettore[5],
                            TecnicoInterno = "" + lettore[6],
                            Note = "" + lettore[7],
                            Bozza = (int)lettore[8],
                            DataEsecuzione = dataValue2,
                            DataRichestaConsegna = dataValue3,
                            Invio = "" + lettore[11],
                            DataOraInvio = dataValue4
                        };
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

            DateTime dateValue;
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
                    if (!(lettore[3] + "").Equals(""))
                    {
                        DateTime.TryParse(lettore[3] + "", out dateValue);
                        DateTime.TryParse(lettore[9] + "", out dataValue2);
                        DateTime.TryParse(lettore[10] + "", out dataValue3);
                        DateTime.TryParse(lettore[12] + "", out dataValue4);
                        var c = new Commessa
                        {
                            Id = (int)lettore[0],
                            Ditta = (int)lettore[1],
                            NumeroCommessa = "" + lettore[2],
                            Data = dateValue,
                            Referente = "" + lettore[4],
                            IndirizzoCantiere = "" + lettore[5],
                            TecnicoInterno = "" + lettore[6],
                            Note = "" + lettore[7],
                            Bozza = (int)lettore[8],
                            DataEsecuzione = dataValue2,
                            DataRichestaConsegna = dataValue3,
                            Invio = "" + lettore[11],
                            DataOraInvio = dataValue4
                        };
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
        public List<Commessa> FiltroCommesse(string s, string g)
        {

            DateTime dateValue;
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
                    if (!(lettore[3] + "").Equals(""))
                    {
                        DateTime.TryParse(lettore[3] + "", out dateValue);
                        DateTime.TryParse(lettore[9] + "", out dataValue2);
                        DateTime.TryParse(lettore[10] + "", out dataValue3);
                        DateTime.TryParse(lettore[12] + "", out dataValue4);
                        var c = new Commessa
                        {

                            Id = (int)lettore[0],
                            Ditta = (int)lettore[1],
                            NumeroCommessa = "" + lettore[2],
                            Data = dateValue,
                            Referente = "" + lettore[4],
                            IndirizzoCantiere = "" + lettore[5],
                            TecnicoInterno = "" + lettore[6],
                            Note = "" + lettore[7],
                            Bozza = (int)lettore[8],
                            DataEsecuzione = dataValue2,
                            DataRichestaConsegna = dataValue3,
                            Invio = "" + lettore[11],
                            DataOraInvio = dataValue4
                        };
                        commessa.Add(c);
                    }
                    else
                    {
                        var c = new Commessa
                        {
                            Id = (int)lettore[0],
                            Ditta = (int)lettore[1],
                            NumeroCommessa = (string)lettore[2],
                            Data = new DateTime(),
                            Referente = "" + lettore[4],
                            Bozza = (int)lettore[5],
                            IndirizzoCantiere = "" + lettore[6],
                            TecnicoInterno = "" + lettore[7],
                            Note = "" + lettore[8]
                        };
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
        public void AggiornaCommesse(int id, int ditta, string numerocommessa, DateTime data, string referente, string indirizzoCantiere, string tecnico, string note, int bozza, DateTime dataEsecuzione, DateTime dataRichiestaConsegna, String nome, DateTime dataInvio)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "UPDATE `COMMESSA` SET `DITTA`='" + ditta + "',`NUMEROCOMMESSA`='" + numerocommessa + "',`DATA`='" +
                    data.ToString("yyyy/MM/dd") + "',`REFERENTE`='" + referente + "',`INDIRIZZOCANTIERE`='" +
                    indirizzoCantiere + "',`TECNICOINTERNO`='" + tecnico + "',`NOTE`='" + note + "',`BOZZA`='" + bozza + "',`DATAESECUZIONE`='" + dataEsecuzione.ToString("yyyy/MM/dd") + "',`DATARICHIESTACONSEGNA`='" + dataRichiestaConsegna.ToString("yyyy/MM/dd") + "',`INVIO`='" + nome + "',`DATAINVIO`='" + dataInvio.ToString("yyyy/MM/dd hh:mm") + "' WHERE `ID` = '" +
                    id + "'", con);
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
        public void AggiornaCommesse(int id, string note)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("UPDATE `COMMESSA` SET `NOTE`='" + note + "' WHERE `ID` = '" + id + "'",
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

    public class LavorazioneDB
    {
        private readonly MySqlConnection con;

        public LavorazioneDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(string nome, string desc, double prezzo, int commessa, DateTime data, String assegnamento)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "INSERT INTO `LAVORAZIONI`( `NOME`, `DESC`, `PREZZO`, `COMMESSA`, `DATA`, `ASSEGNAMENTO`) VALUES('" +
                    nome + "','" + desc + "','" + prezzo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + commessa + "','" + data.ToString("yyyy/MM/dd") + "','" + assegnamento + "','"
                     + "')", con);
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

        public List<Lavorazioni> ListaLavorazioni()
        {
            var lista = new List<Lavorazioni>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `LAVORAZIONI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var lavorazione = new Lavorazioni
                    {
                        Id = (int)lettore[0],
                        Nome = (string)lettore[1],
                        Desc = (string)lettore[2],
                        Prezzo = (double)lettore[3],
                        Commessa = (int)lettore[4],
                        data = (DateTime)lettore[5],
                        assegnato = (String)lettore[5]
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

        public List<Lavorazioni> ListaLavorazioni(string n)
        {
            var lista = new List<Lavorazioni>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `LAVORAZIONI` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var lavorazione = new Lavorazioni
                    {

                        Id = (int)lettore[0],
                        Nome = (string)lettore[1],
                        Desc = (string)lettore[2],
                        Prezzo = (double)lettore[3],
                        Commessa = (int)lettore[4],
                        data = (DateTime)lettore[5],
                        assegnato = (String)lettore[5]
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

        public Lavorazioni CercaLavorazione(int id)
        {
            Lavorazioni lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `LAVORAZIONI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var l = new Lavorazioni
                    {

                        Id = (int)lettore[0],
                        Nome = (string)lettore[1],
                        Desc = (string)lettore[2],
                        Prezzo = (double)lettore[3],
                        Commessa = (int)lettore[4],
                        data = (DateTime)lettore[5],
                        assegnato = (String)lettore[5]
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

        public List<Lavorazioni> FiltroLavorazioni(string s, string g)
        {
            var lavorazione = new List<Lavorazioni>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `LAVORAZIONI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    var l = new Lavorazioni
                    {

                        Id = (int)lettore[0],
                        Nome = (string)lettore[1],
                        Desc = (string)lettore[2],
                        Prezzo = (double)lettore[3],
                        Commessa = (int)lettore[4],
                        data = (DateTime)lettore[5],
                        assegnato = (String)lettore[5]
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

        public void AggiornaLavorazioni(int id, string nome, string desc, double prezzo, int commessa, DateTime data, String asegnamento)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "UPDATE `LAVORAZIONI` SET `NOME`='" + nome + "',`DESC`='" + desc + "',`PREZZO`='" + prezzo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) +
                    "',`COMMESSA`='" + commessa + "',`DATA`='" +
                    data.ToString("yyyy/MM/dd") + "',`ASSEGNAMENTO`='" + asegnamento + "' WHERE `ID` = '" + id + "'", con);
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

        public void RimuoviLavorazioni(int id)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("DELETE FROM `LAVORAZIONI` WHERE `ID` = '" + id + "'", con);
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

    public class PagamentoDB
    {
        private readonly MySqlConnection con;

        public PagamentoDB(MySqlConnection conn)
        {
            con = conn;
        }

        public void Inserimento(string numeroCommessa, double importo, string note, string fattura,
            DateTime dataFattura, DateTime data, int cliente, int commessa)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "INSERT INTO `PAGAMENTO`(`NUMEROCOMMESSA`, `IMPORTO`, `NOTE`, `FATTURA`, `DATAFATTURA`, `DATA`, `CLIENTE`, `COMMESSA`) VALUES('" +
                    numeroCommessa + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" +
                    note + "','" + fattura + "','" + dataFattura.ToString("yyyy/MM/dd") + "','" +
                    data.ToString("yyyy/MM/dd") + "','" + cliente + "','" + commessa + "')", con);
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

        public List<Pagamento> ListaOperazione()
        {
            DateTime data, dataFattura;
            var lista = new List<Pagamento>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PAGAMENTO`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[5] + "", out data);
                    DateTime.TryParse(lettore[6] + "", out dataFattura);
                    var lavorazione = new Pagamento
                    {
                        Id = (int)lettore[0],
                        NumeroCommessa = "" + lettore[1],
                        Importo = Convert.ToDouble(lettore[2] + ""),
                        Note = "" + lettore[3],
                        Fattura = "" + lettore[4],
                        Data = data,
                        DataFattura = dataFattura,
                        Cliente = (int)lettore[7],
                        Commessa = (int)lettore[8]
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

        public List<Pagamento> ListaOperazione(string n)
        {
            DateTime data, dataFattura;
            var lista = new List<Pagamento>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PAGAMENTO` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[5] + "", out data);
                    DateTime.TryParse(lettore[6] + "", out dataFattura);
                    var lavorazione = new Pagamento
                    {
                        Id = (int)lettore[0],
                        NumeroCommessa = "" + lettore[1],
                        Importo = Convert.ToDouble(lettore[2] + ""),
                        Note = "" + lettore[3],
                        Fattura = "" + lettore[4],
                        Data = data,
                        DataFattura = dataFattura,
                        Cliente = (int)lettore[7],
                        Commessa = (int)lettore[8]
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

        public Pagamento CercaOperazione(int id)
        {
            DateTime data, dataFattura;
            Pagamento lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PAGAMENTO` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[5] + "", out data);
                    DateTime.TryParse(lettore[6] + "", out dataFattura);
                    var l = new Pagamento
                    {
                        Id = (int)lettore[0],
                        NumeroCommessa = "" + lettore[1],
                        Importo = Convert.ToDouble(lettore[2] + ""),
                        Note = "" + lettore[3],
                        Fattura = "" + lettore[4],
                        Data = data,
                        DataFattura = dataFattura,
                        Cliente = (int)lettore[7],
                        Commessa = (int)lettore[8]
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

        public List<Pagamento> FiltroOperazione(string s, string g)
        {
            DateTime data, dataFattura;
            var lavorazione = new List<Pagamento>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                var command = new MySqlCommand("SELECT * FROM `PAGAMENTO` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[5] + "", out data);
                    DateTime.TryParse(lettore[6] + "", out dataFattura);
                    var l = new Pagamento
                    {
                        Id = (int)lettore[0],
                        NumeroCommessa = "" + lettore[1],
                        Importo = Convert.ToDouble(lettore[2] + ""),
                        Note = "" + lettore[3],
                        Fattura = "" + lettore[4],
                        Data = data,
                        DataFattura = dataFattura,
                        Cliente = (int)lettore[7],
                        Commessa = (int)lettore[8]
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

        public void AggiornaOperazione(int id, string numeroCommessa, double importo, string note, string fattura,
            DateTime dataFattura, DateTime data, int cliente, int commessa)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand(
                    "UPDATE `PAGAMENTO` SET `NUMEROCOMMESSA`='" + numeroCommessa + "',`IMPORTO`='" + importo +
                    "',`NOTE`='" + note + "',`FATTURA`='" + fattura + "',`DATAFATTURA`='" + dataFattura + "',`DATA`='" +
                    data + "',`CLIENTE`='" + cliente + "',`COMMESSA`='" + commessa + "' WHERE `ID` = '" + id + "'",
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

        public void RimuoviOperazione(int id)
        {
            try
            {
                con.Open();
                var command = new MySqlCommand("DELETE FROM `PAGAMENTO` WHERE `ID` = '" + id + "'", con);
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

        public int Ruolo { get; set; }
    }

    public class Ruolo
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Desc { get; set; }
    }

    public class Bozza
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public double Importo { get; set; }

        public string FaseProgetto { get; set; }

        public string IdentificativoPreventivo { get; set; }

        public int Cliente { get; set; }

        public bool Accettazione { get; set; }
    }
    public class Commessa
    {
        public int Id { get; set; }

        public int Ditta { get; set; }

        public string NumeroCommessa { get; set; }

        public DateTime Data { get; set; }

        public string Referente { get; set; }
        public string IndirizzoCantiere { get; set; }
        public string TecnicoInterno { get; set; }
        public string Note { get; set; }

        public int Bozza { get; set; }
        public DateTime DataEsecuzione { get; set; }
        public DateTime DataRichestaConsegna { get; set; }
        public string Invio { get; set; }
        public DateTime DataOraInvio { get; set; }



    }
    public class Pagamento
    {
        public int Id { get; set; }

        public string NumeroCommessa { get; set; }

        public string Note { get; set; }

        public string Fattura { get; set; }

        public DateTime DataFattura { get; set; }

        public DateTime Data { get; set; }

        public int Cliente { get; set; }

        public int Commessa { get; set; }

        public double Importo { get; set; }
    }

    public class Lavorazioni
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Desc { get; set; }

        public double Prezzo { get; set; }

        public int Commessa { get; set; }

        public DateTime data { get; set; }

        public string assegnato { get; set; }

    }
}