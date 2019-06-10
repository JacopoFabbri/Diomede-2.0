using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Diomede2
{
    class OperazionePraticheEdili
    {
        public MySqlConnection conn = new MySqlConnection();
        public OperazionePraticheEdili(String nomeDB)
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.1.135;Port = 3307;Database=" + nomeDB + ";Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
        }
        public void InserimentoCliente(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono, String sdi)
        {
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
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
                ClienteDB cDB = new ClienteDB(conn);
                lista = cDB.ListaClienti();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Cliente> CercaClientiNome(String n)
        {
            List<Cliente> lista;
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
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
                ClienteDB cDB = new ClienteDB(conn);
                cliente = cDB.CercaCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return cliente;
        }
        public List<Cliente> FiltraClienti(String s, String g)
        {
            List<Cliente> cliente;
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                cliente = cDB.FiltroCliente(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return cliente;
        }
        public void UpdateCliente(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono, String sdi)
        {
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
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
                ClienteDB cDB = new ClienteDB(conn);
                cDB.RimuoviCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoContatto(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String ditta, String cellulare, String telefono, String ruolo)
        {
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                cDB.Inserimento(nome, indirizzo, cap, citta, pec, email, partitaIva, ditta, cellulare, telefono, ruolo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Contatto> CercaContratti()
        {
            List<Contatto> lista;
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                lista = cDB.ListaContatti();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Contatto> CercaContattoNome(String n)
        {
            List<Contatto> lista;
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
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
                ContattoDB cDB = new ContattoDB(conn);
                contatto = cDB.CercaContatto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Contatto> FiltraContratto(String s, String g)
        {
            List<Contatto> contattos;
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                contattos = cDB.FiltroContatto(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contattos;
        }
        public void UpdateContatto(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, int ditta, String cellulare, string telefono, string ruolo)
        {
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                cDB.AggiornaContatto(id, nome, indirizzo, cap, citta, pec, email, partitaIva, ditta, cellulare, telefono, ruolo);
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
                ContattoDB cDB = new ContattoDB(conn);
                cDB.RimuoviContatto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoRuolo(String nome, String desc)
        {
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
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
                RuoloDB cDB = new RuoloDB(conn);
                lista = cDB.ListaRuoli();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Ruolo> CercaRuoloNome(String n)
        {
            List<Ruolo> lista;
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
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
                RuoloDB cDB = new RuoloDB(conn);
                contatto = cDB.CercaRuoli(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Ruolo> FiltraRuolo(String s, String g)
        {
            List<Ruolo> ruolo;
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
                ruolo = cDB.FiltroRuoli(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return ruolo;
        }
        public void UpdateRuolo(int id, String nome, String desc)
        {
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
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
                RuoloDB cDB = new RuoloDB(conn);
                cDB.RimuoviRuolo(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoBozza(DateTime data, String pacchetto, String importo, String numerocommessa)
        {
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                bDB.Inserimento(data, pacchetto, importo, numerocommessa);
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
                BozzaDB bDB = new BozzaDB(conn);
                lista = bDB.ListaBozza();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Bozza> CercaBozza(String n)
        {
            List<Bozza> lista;
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
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
                BozzaDB bDB = new BozzaDB(conn);
                contatto = bDB.CercaBozza(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Bozza> FiltraBozza(String s, String g)
        {
            List<Bozza> contatto;
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                contatto = bDB.FiltroBozza(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdateBozza(int id, DateTime data, String pacchetto, Double importo, String numerocommessa)
        {
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                bDB.AggiornaBozza(id, data, pacchetto, importo, numerocommessa);
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
                BozzaDB bDB = new BozzaDB(conn);
                bDB.RimuoviBozza(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoMacrolavorazione(String nome, String desc)
        {
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                bDB.Inserimento(nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<MacroLavorazione> CercaMacroLavorazione()
        {
            List<MacroLavorazione> lista;
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                lista = bDB.ListaMacroLavorazioni();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<MacroLavorazione> CercaMacroLavorazione(String n)
        {
            List<MacroLavorazione> lista;
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                lista = bDB.ListaMacroLavorazioni(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public MacroLavorazione CercaMacroLavorazione(int id)
        {
            MacroLavorazione contatto;
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                contatto = bDB.CercaLavorazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<MacroLavorazione> FiltraMacroLavorazione(String s, String g)
        {
            List<MacroLavorazione> contatto;
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                contatto = bDB.FiltroLavorazioni(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdateMacroLavorazione(int id, String nome, String desc)
        {
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                bDB.AggiornaLavorazioni(id, nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaMacroLavorazione(int id)
        {
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                bDB.RimuoviLavorazioni(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoPacchetto(String nome, String desc)
        {
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                bDB.Inserimento(nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Pacchetto> CercaPacchetto()
        {
            List<Pacchetto> lista;
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                lista = bDB.ListaPacchetti();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Pacchetto> CercaPacchetto(String n)
        {
            List<Pacchetto> lista;
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                lista = bDB.ListaPacchetti(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public Pacchetto CercaPacchetto(int id)
        {
            Pacchetto contatto;
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                contatto = bDB.CercaPacchetto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Pacchetto> FiltraPacchetto(String s, String g)
        {
            List<Pacchetto> contatto;
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                contatto = bDB.FiltroPacchetto(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdatePacchetto(int id, String nome, String desc)
        {
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                bDB.AggiornaPacchetto(id, nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaPacchetto(int id)
        {
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                bDB.RimuoviPacchetto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

    }

    public class ClienteDB
    {
        readonly MySqlConnection con;
        public ClienteDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono, String sdi)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `ANAGRAFICACLIENTI`(`NOME`, `INDIRIZZO`, `CAP`, `CITTA`, `PEC`, `EMAIL`, `PARTITAIVA`, `TELEFONOFISSO`, `SDI`) VALUES('" + nome + "','" + indirizzo + "','" + cap + "','" + citta + "','" + pec + "','" + email + "','" + partitaIva + "','" + telefono + "','" + sdi + "')", con);
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
            List<Cliente> lista = new List<Cliente>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ANAGRAFICACLIENTI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        Id = (Int32)lettore[0],
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
        public List<Cliente> ListaClienti(String n)
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ANAGRAFICACLIENTI` WHERE `NOME` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        Id = (Int32)lettore[0],
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ANAGRAFICACLIENTI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    cliente = new Cliente
                    {
                        Id = (Int32)lettore[0],
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
        public List<Cliente> FiltroCliente(String s, String g)
        {
            List<Cliente> cliente = new List<Cliente>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ANAGRAFICACLIENTI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Cliente c = new Cliente
                    {
                        Id = (Int32)lettore[0],
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
        public void AggiornaCliente(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono, String sdi)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `ANAGRAFICACLIENTI` SET `NOME`='" + nome + "',`INDIRIZZO`='" + indirizzo + "',`CAP`='" + cap + "',`CITTA`='" + citta + "',`PEC`='" + pec + "',`EMAIL`='" + email + "',`PARTITAIVA`='" + partitaIva + "',`TELEFONOFISSO`='" + telefono + "',`SDI`='" + sdi + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `ANAGRAFICACLIENTI` WHERE `ID` = '" + id + "'", con);
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
        readonly MySqlConnection con;

        public ContattoDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String ditta, String cellulare, String telefono, String ruolo)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `ANAGRAFICACONTATTI`(`NOME`, `INDIRIZZO`, `CAP`, `CITTA`, `PEC`, `EMAIL`, `PARTITAIVA`, `DITTA`,`TELEFONOCELLULARE`,`TELEFONOFISSO`, `RUOLO`) VALUES('" + nome + "','" + indirizzo + "','" + cap + "','" + citta + "','" + pec + "','" + email + "','" + partitaIva + "','" + ditta + "','" + cellulare + "','" + telefono + "','" + ruolo + "')", con);
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ANAGRAFICACONTATTI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Contatto contatto = new Contatto
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Ditta = (Int32)lettore[8],
                        Cellulare = "" + lettore[9],
                        Tel = "" + lettore[10],
                        Ruolo = (Int32)lettore[11]
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
        public List<Contatto> ListaClienti(String n)
        {
            List<Contatto> lista = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ANAGRAFICACONTATTI` WHERE `NOME` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Contatto contatto = new Contatto
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Ditta = (Int32)lettore[8],
                        Cellulare = "" + lettore[9],
                        Tel = "" + lettore[10],
                        Ruolo = (Int32)lettore[11]
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ANAGRAFICACONTATTI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Contatto contatto = new Contatto
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Ditta = (Int32)lettore[8],
                        Cellulare = "" + lettore[9],
                        Tel = "" + lettore[10],
                        Ruolo = (Int32)lettore[11]
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
        public List<Contatto> FiltroContatto(String s, String g)
        {
            List<Contatto> contattos = new List<Contatto>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ANAGRAFICACONTATTI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Contatto contatto = new Contatto
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Indirizzo = "" + lettore[2],
                        Cap = "" + lettore[3],
                        Citta = "" + lettore[4],
                        Pec = "" + lettore[5],
                        Email = "" + lettore[6],
                        Iva = "" + lettore[7],
                        Ditta = (Int32)lettore[8],
                        Cellulare = "" + lettore[9],
                        Tel = "" + lettore[10],
                        Ruolo = (Int32)lettore[11]
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
        public void AggiornaContatto(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, int ditta, String cellulare, string telefono, string ruolo)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `ANAGRAFICACONTATTI` SET `NOME`='" + nome + "',`INDIRIZZO`='" + indirizzo + "',`CAP`='" + cap + "',`CITTA`='" + citta + "',`PEC`='" + pec + "',`EMAIL`='" + email + "',`PARTITAIVA`='" + partitaIva + "',`DITTA`='" + ditta + "',`TELEFONOCELLULARE`='" + cellulare + "',`TELEFONOFISSO`='" + telefono + "',`RUOLO`='" + ruolo + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `ANAGRAFICACONTATTI` WHERE `ID` = '" + id + "'", con);
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
        readonly MySqlConnection con;

        public RuoloDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, String desc)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `RUOLI`(`NOME`, `DESC`) VALUES('" + nome + "','" + desc + "')", con);
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
            List<Ruolo> lista = new List<Ruolo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `RUOLI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Ruolo ruolo = new Ruolo
                    {
                        Id = (Int32)lettore[0],
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
        public List<Ruolo> ListaRuoli(String n)
        {
            List<Ruolo> lista = new List<Ruolo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `RUOLI` WHERE `NOME` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Ruolo ruolo = new Ruolo
                    {

                        Id = (Int32)lettore[0],
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `RUOLI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Ruolo r = new Ruolo
                    {

                        Id = (Int32)lettore[0],
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
        public List<Ruolo> FiltroRuoli(String s, String g)
        {
            List<Ruolo> ruolo = new List<Ruolo>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `RUOLI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Ruolo r = new Ruolo
                    {

                        Id = (Int32)lettore[0],
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
        public void AggiornaRuoli(int id, String nome, String desc)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `RUOLI` SET `NOME`='" + nome + "',`DESC`='" + desc + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `RUOLI` WHERE `ID` = '" + id + "'", con);
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
        readonly MySqlConnection con = null;

        public BozzaDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(DateTime data, String pacchetto, String importo, String numerocommessa)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `BOZZA`(`DATA`, `PACCHETTO`,`IMPORTO`,`NUMEROCOMMESSA`) VALUES('" + data.ToString("yyyy/MM/dd") + "','" + pacchetto + "','" + importo + "','" + numerocommessa + "')", con);
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
            List<Bozza> lista = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `BOZZA`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Bozza bozza = new Bozza
                    {
                        Id = (Int32)lettore[0],
                        Data = (DateTime)lettore[1],
                        Pacchetto = (Int32)lettore[2],
                        Importo = (Double)lettore[3],
                        NumeroCommessa = "" + lettore[4]
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
        public List<Bozza> ListaBozza(String n)
        {
            List<Bozza> lista = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `BOZZA` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Bozza bozza = new Bozza
                    {

                        Id = (Int32)lettore[0],
                        Data = (DateTime)lettore[1],
                        Pacchetto = (Int32)lettore[2],
                        Importo = (Double)lettore[3],
                        NumeroCommessa = "" + lettore[4]
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `BOZZA` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Bozza b = new Bozza
                    {
                        Id = (Int32)lettore[0],
                        Data = (DateTime)lettore[1],
                        Pacchetto = (Int32)lettore[2],
                        Importo = (Double)lettore[3],
                        NumeroCommessa = (String)lettore[4]
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
        public List<Bozza> FiltroBozza(String s, String g)
        {
            List<Bozza> bozza = new List<Bozza>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `BOZZA` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Bozza b = new Bozza
                    {
                        Id = (Int32)lettore[0],
                        Data = (DateTime)lettore[1],
                        Pacchetto = (Int32)lettore[2],
                        Importo = (Double)lettore[3],
                        NumeroCommessa = (String)lettore[4]
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
        public void AggiornaBozza(int id, DateTime data, String pacchetto, Double importo, String numerocommessa)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `BOZZA` SET `DATA`='" + data + "',`PACCHETTO`='" + pacchetto + "',`IMPORTO`='" + importo + "',`NUMEROCOMMESSA`='" + numerocommessa + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `BOZZA` WHERE `ID` = '" + id + "'", con);
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
        readonly MySqlConnection con = null;

        public CommessaDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String ditta, String tipologia, String numerocommessa, String data, String referente)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `COMMESSA`(`ID`, `DITTA`, `TIPOLOGIA`, `NUMEROCOMMESSA`, `DATA`, `REFERENTE`) VALUES('" + ditta + "','" + tipologia + "','" + numerocommessa + "','" + data + "','" + referente + "')", con);
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
            List<Commessa> lista = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Commessa commessa = new Commessa
                    {
                        Id = (Int32)lettore[0],
                        Ditta = (Int32)lettore[1],
                        Tipologia = (Int32)lettore[2],
                        NumeroCommessa = (String)lettore[3],
                        Data = (DateTime)lettore[4],
                        Referente = (String)lettore[5]
                    };
                    lista.Add(commessa);
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
        public List<Commessa> ListaCommesse(String n)
        {
            List<Commessa> lista = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Commessa commessa = new Commessa
                    {
                        Id = (Int32)lettore[0],
                        Ditta = (Int32)lettore[1],
                        Tipologia = (Int32)lettore[2],
                        NumeroCommessa = (String)lettore[3],
                        Data = (DateTime)lettore[4],
                        Referente = (String)lettore[5]
                    };
                    lista.Add(commessa);
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
            Commessa commessa = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Commessa c = new Commessa();
                    commessa.Id = (Int32)lettore[0];
                    commessa.Ditta = (Int32)lettore[1];
                    commessa.Tipologia = (Int32)lettore[2];
                    commessa.NumeroCommessa = (String)lettore[3];
                    commessa.Data = (DateTime)lettore[4];
                    commessa.Referente = (String)lettore[5];
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
        public List<Commessa> FiltroCommesse(String s, String g)
        {
            List<Commessa> commessa = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Commessa c = new Commessa
                    {
                        Id = (Int32)lettore[0],
                        Ditta = (Int32)lettore[1],
                        Tipologia = (Int32)lettore[2],
                        NumeroCommessa = (String)lettore[3],
                        Data = (DateTime)lettore[4],
                        Referente = (String)lettore[5]
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
        public void AggiornaCommesse(int id, String ditta, String tipologia, String numerocommessa, String data, String referente)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `COMMESSA` SET `DITTA`='" + ditta + "',`TIPOLOGIA`='" + tipologia + "',`NUMEROCOMMESSA`='" + numerocommessa + "',`DATA`='" + data + "',`REFERENTE`='" + referente + "' WHERE `ID` = '" + id + "'", con);
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
    public class LavorazioniDB
    {
        readonly MySqlConnection con = null;

        public LavorazioniDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String operazione, String pacchetto, String importo)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `LAVORAZIONE`(`ID`, `OPERAZIONE`, `PACCHETTO`, `IMPORTO`) VALUES('" + operazione + "','" + pacchetto + "','" + importo + "')", con);
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
        public List<Lavorazione> ListaLavorazioni()
        {
            List<Lavorazione> lista = new List<Lavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `LAVORAZIONE`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Lavorazione lavorazione = new Lavorazione
                    {
                        Id = (Int32)lettore[0],
                        Operazione = (String)lettore[1],
                        Pacchetto = (Int32)lettore[2],
                        Importo = (Double)lettore[3]
                    };
                    ;
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
        public List<Lavorazione> ListaLavorazioni(String n)
        {
            List<Lavorazione> lista = new List<Lavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `LAVORAZIONE` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Lavorazione lavorazione = new Lavorazione
                    {
                        Id = (Int32)lettore[0],
                        Operazione = (String)lettore[1],
                        Pacchetto = (Int32)lettore[2],
                        Importo = (Double)lettore[3]
                    };
                    ;
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
        public Lavorazione CercaLavorazione(int id)
        {
            Lavorazione lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `LAVORAZIONE` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Lavorazione l = new Lavorazione();
                    lavorazione.Id = (Int32)lettore[0];
                    lavorazione.Operazione = (String)lettore[1];
                    lavorazione.Pacchetto = (Int32)lettore[2];
                    lavorazione.Importo = (Double)lettore[3]; ;
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
        public List<Lavorazione> FiltroLavorazioni(String s, String g)
        {
            List<Lavorazione> lavorazione = new List<Lavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `LAVORAZIONE` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Lavorazione l = new Lavorazione
                    {
                        Id = (Int32)lettore[0],
                        Operazione = (String)lettore[1],
                        Pacchetto = (Int32)lettore[2],
                        Importo = (Double)lettore[3]
                    };
                    ;
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
        public void AggiornaLavorazioni(int id, String operazione, String pacchetto, String importo)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `LAVORAZIONE` SET `OPERAZIONE`='" + operazione + "',`PACCHETTO`='" + pacchetto + "',`IMPORTO`='" + importo + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `LAVORAZIONE` WHERE `ID` = '" + id + "'", con);
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
    public class MacroLavorazioniDB
    {
        readonly MySqlConnection con = null;

        public MacroLavorazioniDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, String desc)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `TIPOLOGIAMACROLAVORAZIONI`(`NOME`, `DESCRIZIONE`) VALUES('" + nome + "','" + desc + "')", con);
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
        public List<MacroLavorazione> ListaMacroLavorazioni()
        {
            List<MacroLavorazione> lista = new List<MacroLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIAMACROLAVORAZIONI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    MacroLavorazione lavorazione = new MacroLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Desc = (String)lettore[2],
                    };
                    ;
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
        public List<MacroLavorazione> ListaMacroLavorazioni(String n)
        {
            List<MacroLavorazione> lista = new List<MacroLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIAMACROLAVORAZIONI` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    MacroLavorazione lavorazione = new MacroLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Desc = (String)lettore[2],
                    };
                    ;
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
        public MacroLavorazione CercaLavorazione(int id)
        {
            MacroLavorazione lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIAMACROLAVORAZIONI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    MacroLavorazione l = new MacroLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Desc = (String)lettore[2]
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
        public List<MacroLavorazione> FiltroLavorazioni(String s, String g)
        {
            List<MacroLavorazione> lavorazione = new List<MacroLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIAMACROLAVORAZIONI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    MacroLavorazione l = new MacroLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Desc = (String)lettore[2],
                    };
                    ;
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
        public void AggiornaLavorazioni(int id, String nome, String desc)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `TIPOLOGIAMACROLAVORAZIONI` SET `NOME`='" + nome + "',`DESCRIZIONE`='" + desc + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `TIPOLOGIAMACROLAVORAZIONI` WHERE `ID` = '" + id + "'", con);
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
    public class PacchettoDB
    {
        readonly MySqlConnection con = null;

        public PacchettoDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, String note)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `PACCHETTO`(`NOME`, `NOTE`) VALUES ('" + nome + "','" + note + "')", con);
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
        public List<Pacchetto> ListaPacchetti()
        {
            List<Pacchetto> lista = new List<Pacchetto>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `PACCHETTO`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Pacchetto lavorazione = new Pacchetto
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Note = "" + lettore[2],
                    };
                    ;
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
        public List<Pacchetto> ListaPacchetti(String n)
        {
            List<Pacchetto> lista = new List<Pacchetto>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `PACCHETTO` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Pacchetto lavorazione = new Pacchetto
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Note = "" + lettore[2],
                    };
                    ;
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
        public Pacchetto CercaPacchetto(int id)
        {
            Pacchetto lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `PACCHETTO` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Pacchetto l = new Pacchetto
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Note = "" + lettore[2]
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
        public List<Pacchetto> FiltroPacchetto(String s, String g)
        {
            List<Pacchetto> lavorazione = new List<Pacchetto>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `PACCHETTO` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Pacchetto l = new Pacchetto
                    {
                        Id = (Int32)lettore[0],
                        Nome = "" + lettore[1],
                        Note = "" + lettore[2],
                    };
                    ;
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
        public void AggiornaPacchetto(int id, String nome, String desc)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `PACCHETTO` SET `NOME`='" + nome + "',`NOTE`='" + desc + "' WHERE `ID` = '" + id + "'", con);
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
        public void RimuoviPacchetto(int id)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM `PACCHETTO` WHERE `ID` = '" + id + "'", con);
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
        private int id;
        private String nome;
        private String indirizzo;
        private String cap;
        private String citta;
        private String pec;
        private String email;
        private String iva;
        private String tel;
        private String sdi;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public string Cap { get => cap; set => cap = value; }
        public string Citta { get => citta; set => citta = value; }
        public string Email { get => email; set => email = value; }
        public string Iva { get => iva; set => iva = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Pec { get => pec; set => pec = value; }
        public string Sdi { get => sdi; set => sdi = value; }
    }
    public class Contatto
    {
        private int id;
        private String nome;
        private String indirizzo;
        private String cap;
        private String citta;
        private String pec;
        private String email;
        private String iva;
        private int ditta;
        private String cellulare;
        private String telefono;
        private int ruolo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public string Cap { get => cap; set => cap = value; }
        public string Citta { get => citta; set => citta = value; }
        public string Pec { get => pec; set => pec = value; }
        public string Email { get => email; set => email = value; }
        public string Iva { get => iva; set => iva = value; }
        public int Ditta { get => ditta; set => ditta = value; }
        public string Cellulare { get => cellulare; set => cellulare = value; }
        public string Tel { get => telefono; set => telefono = value; }
        public int Ruolo { get => ruolo; set => ruolo = value; }
    }
    public class Ruolo
    {
        private int id;
        private String nome;
        private String desc;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Desc { get => desc; set => desc = value; }
    }
    public class Bozza
    {
        private int id;
        private DateTime data;
        private int pacchetto;
        private Double importo;
        private String numerocommessa;

        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Pacchetto { get => pacchetto; set => pacchetto = value; }
        public Double Importo { get => importo; set => importo = value; }
        public String NumeroCommessa { get => numerocommessa; set => numerocommessa = value; }
    }
    public class Commessa
    {
        private int id;
        private int ditta;
        private int tipologia;
        private String numerocommessa;
        private DateTime data;
        private String referente;


        public int Id { get => id; set => id = value; }
        public int Ditta { get => ditta; set => ditta = value; }
        public int Tipologia { get => tipologia; set => tipologia = value; }
        public String NumeroCommessa { get => numerocommessa; set => numerocommessa = value; }
        public DateTime Data { get => data; set => data = value; }
        public String Referente { get => referente; set => referente = value; }

    }
    public class Lavorazione
    {
        private int id;
        private String operazione;
        private int pacchetto;
        private Double importo;


        public int Id { get => id; set => id = value; }
        public String Operazione { get => operazione; set => operazione = value; }
        public int Pacchetto { get => pacchetto; set => pacchetto = value; }
        public Double Importo { get => importo; set => importo = value; }

    }
    public class MacroLavorazione
    {
        private int id;
        private String nome;
        private String desc;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Desc { get => desc; set => desc = value; }
    }
    public class Pacchetto
    {
        private int id;
        private String nome;
        private String note;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Note { get => note; set => note = value; }
    }
}