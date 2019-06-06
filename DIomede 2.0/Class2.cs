﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diomede2
{
    class OperazionePraticheEdili
    {
        public MySqlConnection conn = new MySqlConnection();
        public OperazionePraticheEdili(String nomeDB)
        {
            conn.ConnectionString = "User Id=Lorenzo; Host=192.168.1.135;Port = 3307;Database=" + nomeDB + ";Persist Security Info=True;Password=KpEDv4Pk0bGYLQtB;";
        }
        public void inserimentoCliente(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono)
        {
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                cDB.inserimento(nome, indirizzo, cap, citta, pec, email, partitaIva, telefono);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Cliente> cercaClienti()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                lista = cDB.listaClienti();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Cliente> cercaClientiNome(String n)
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                lista = cDB.listaClienti(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public Cliente cercaClientiId(int id)
        {
            Cliente cliente = null;
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                cliente = cDB.cercaCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return cliente;
        }
        public List<Cliente> filtraClienti(String s, String g)
        {
            List<Cliente> cliente = null;
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                cliente = cDB.filtroCliente(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return cliente;
        }
        public void updateCliente(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono)
        {
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                cDB.aggiornaCliente(id, nome, indirizzo, cap, citta, pec, email, partitaIva, telefono);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void cancellaCliente(int id)
        {
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                cDB.rimuoviCliente(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void inserimentoContatto(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String ditta, String cellulare, String telefono, String ruolo)
        {
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                cDB.inserimento(nome, indirizzo, cap, citta, pec, email, partitaIva, ditta, cellulare, telefono, ruolo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Contatto> cercaContratti()
        {
            List<Contatto> lista = new List<Contatto>();
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                lista = cDB.listaContatti();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Contatto> cercaContattoNome(String n)
        {
            List<Contatto> lista = new List<Contatto>();
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                lista = cDB.listaClienti(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public Contatto cercaContattoId(int id)
        {
            Contatto contatto = null;
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                contatto = cDB.cercaContatto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Contatto> filtraContratto(String s, String g)
        {
            List<Contatto> contattos = null;
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                contattos = cDB.filtroContatto(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contattos;
        }
        public void updateContatto(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, int ditta, String cellulare, string telefono, string ruolo)
        {
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                cDB.aggiornaContatto(id, nome, indirizzo, cap, citta, pec, email, partitaIva, ditta, cellulare, telefono, ruolo);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void cacellaContatto(int id)
        {
            try
            {
                ContattoDB cDB = new ContattoDB(conn);
                cDB.rimuoviContatto(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void inserimentoRuolo(String nome, String desc)
        {
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
                cDB.inserimento(nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Ruolo> cercaRuolo()
        {
            List<Ruolo> lista = new List<Ruolo>();
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
                lista = cDB.listaRuoli();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Ruolo> cercaRuoloNome(String n)
        {
            List<Ruolo> lista = new List<Ruolo>();
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
                lista = cDB.listaRuoli(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public Ruolo cercaRuoloId(int id)
        {
            Ruolo contatto = null;
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
                contatto = cDB.cercaRuoli(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Ruolo> filtraRuolo(String s, String g)
        {
            List<Ruolo> ruolo = new List<Ruolo>();
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
                ruolo = cDB.filtroRuoli(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return ruolo;
        }
        public void updateRuolo(int id, String nome, String desc)
        {
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
                cDB.aggiornaRuoli(id, nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void cancellaRuolo(int id)
        {
            try
            {
                RuoloDB cDB = new RuoloDB(conn);
                cDB.rimuoviRuolo(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void inserimentoBozza(String data, String pacchetto, String importo, String numerocommessa)
        {
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                bDB.inserimento(data, pacchetto, importo, numerocommessa);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Bozza> cercaBozza()
        {
            List<Bozza> lista = new List<Bozza>();
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                lista = bDB.listaBozza();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Bozza> cercaBozza(String n)
        {
            List<Bozza> lista = new List<Bozza>();
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                lista = bDB.listaBozza(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public Bozza cercaBozzaId(int id)
        {
            Bozza contatto = null;
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                contatto = bDB.cercaBozza(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public Bozza filtraBozza(String s, String g)
        {
            Bozza contatto = null;
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                contatto = bDB.filtroBozza(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void updateBozza(int id, String data, String pacchetto, String importo, String numerocommessa)
        {
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                bDB.aggiornaBozza(id, data, pacchetto, importo, numerocommessa);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void cancellaBozza(int id)
        {
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                bDB.rimuoviBozza(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
    }

    public class ClienteDB
    {
        MySqlConnection con = null;
        public ClienteDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void inserimento(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `ANAGRAFICACLIENTI`(`NOME`, `INDIRIZZO`, `CAP`, `CITTA`, `PEC`, `EMAIL`, `PARTITAIVA`, `TELEFONOFISSO`) VALUES('" + nome + "','" + indirizzo + "','" + cap + "','" + citta + "','" + pec + "','" + email + "','" + partitaIva + "','" + telefono + "')", con);
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
        public List<Cliente> listaClienti()
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
                    Cliente cliente = new Cliente();
                    cliente.Id = (Int32)lettore[0];
                    cliente.Nome = (String)lettore[1];
                    cliente.Indirizzo = (String)lettore[2];
                    cliente.Cap = (String)lettore[3];
                    cliente.Citta = (String)lettore[4];
                    cliente.Pec = (String)lettore[5];
                    cliente.Email = (String)lettore[6];
                    cliente.Iva = (String)lettore[7];
                    cliente.Tel = (String)lettore[8];
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
        public List<Cliente> listaClienti(String n)
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
                    Cliente cliente = new Cliente();
                    cliente.Id = (Int32)lettore[0];
                    cliente.Nome = (String)lettore[1];
                    cliente.Indirizzo = (String)lettore[2];
                    cliente.Cap = (String)lettore[3];
                    cliente.Citta = (String)lettore[4];
                    cliente.Pec = (String)lettore[5];
                    cliente.Email = (String)lettore[6];
                    cliente.Iva = (String)lettore[7];
                    cliente.Tel = (String)lettore[8];
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
        public Cliente cercaCliente(int id)
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
                    cliente = new Cliente();
                    cliente.Id = (Int32)lettore[0];
                    cliente.Nome = (String)lettore[1];
                    cliente.Indirizzo = (String)lettore[2];
                    cliente.Cap = (String)lettore[3];
                    cliente.Citta = (String)lettore[4];
                    cliente.Pec = (String)lettore[5];
                    cliente.Email = (String)lettore[6];
                    cliente.Iva = (String)lettore[7];
                    cliente.Tel = (String)lettore[8];
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
        public List<Cliente> filtroCliente(String s, String g)
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
                    Cliente c = new Cliente();
                    c.Id = (Int32)lettore[0];
                    c.Nome = (String)lettore[1];
                    c.Indirizzo = (String)lettore[2];
                    c.Cap = (String)lettore[3];
                    c.Citta = (String)lettore[4];
                    c.Pec = (String)lettore[5];
                    c.Email = (String)lettore[6];
                    c.Iva = (String)lettore[7];
                    c.Tel = (String)lettore[8];
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
        public void aggiornaCliente(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `ANAGRAFICACLIENTI` SET `NOME`='" + nome + "',`INDIRIZZO`='" + indirizzo + "',`CAP`='" + cap + "',`CITTA`='" + citta + "',`PEC`='" + pec + "',`EMAIL`='" + email + "',`PARTITAIVA`='" + partitaIva + "',`TELEFONOFISSO`='" + telefono + "' WHERE `ID` = '" + id + "'", con);
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
        public void rimuoviCliente(int id)
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
        MySqlConnection con = null;

        public ContattoDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void inserimento(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String ditta, String cellulare, String telefono, String ruolo)
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
        public List<Contatto> listaContatti()
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
                    Contatto contatto = new Contatto();
                    contatto.Id = (Int32)lettore[0];
                    contatto.Nome = (String)lettore[1];
                    contatto.Indirizzo = (String)lettore[2];
                    contatto.Cap = (String)lettore[3];
                    contatto.Citta = (String)lettore[4];
                    contatto.Pec = (String)lettore[5];
                    contatto.Email = (String)lettore[6];
                    contatto.Iva = (String)lettore[7];
                    contatto.Ditta = (Int32)lettore[8];
                    contatto.Cellulare = (String)lettore[9];
                    contatto.Tel = (String)lettore[10];
                    contatto.Ruolo = (Int32)lettore[11];
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
        public List<Contatto> listaClienti(String n)
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
                    Contatto contatto = new Contatto();
                    contatto.Id = (Int32)lettore[0];
                    contatto.Nome = (String)lettore[1];
                    contatto.Indirizzo = (String)lettore[2];
                    contatto.Cap = (String)lettore[3];
                    contatto.Citta = (String)lettore[4];
                    contatto.Pec = (String)lettore[5];
                    contatto.Email = (String)lettore[6];
                    contatto.Iva = (String)lettore[7];
                    contatto.Ditta = (Int32)lettore[8];
                    contatto.Cellulare = (String)lettore[9];
                    contatto.Tel = (String)lettore[10];
                    contatto.Ruolo = (Int32)lettore[11];
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
        public Contatto cercaContatto(int id)
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
                    Contatto contatto = new Contatto();
                    contatto.Id = (Int32)lettore[0];
                    contatto.Nome = (String)lettore[1];
                    contatto.Indirizzo = (String)lettore[2];
                    contatto.Cap = (String)lettore[3];
                    contatto.Citta = (String)lettore[4];
                    contatto.Pec = (String)lettore[5];
                    contatto.Email = (String)lettore[6];
                    contatto.Iva = (String)lettore[7];
                    contatto.Ditta = (Int32)lettore[8];
                    contatto.Cellulare = (String)lettore[9];
                    contatto.Tel = (String)lettore[10];
                    contatto.Ruolo = (Int32)lettore[11];
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
        public List<Contatto> filtroContatto(String s, String g)
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
                    Contatto contatto = new Contatto();
                    contatto.Id = (Int32)lettore[0];
                    contatto.Nome = (String)lettore[1];
                    contatto.Indirizzo = (String)lettore[2];
                    contatto.Cap = (String)lettore[3];
                    contatto.Citta = (String)lettore[4];
                    contatto.Pec = (String)lettore[5];
                    contatto.Email = (String)lettore[6];
                    contatto.Iva = (String)lettore[7];
                    contatto.Ditta = (Int32)lettore[8];
                    contatto.Cellulare = (String)lettore[9];
                    contatto.Tel = (String)lettore[10];
                    contatto.Ruolo = (Int32)lettore[11];
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
        public void aggiornaContatto(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, int ditta, String cellulare, string telefono, string ruolo)
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
        public void rimuoviContatto(int id)
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
        MySqlConnection con = null;

        public RuoloDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void inserimento(String nome, String desc)
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
        public List<Ruolo> listaRuoli()
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
                    Ruolo ruolo = new Ruolo();
                    ruolo.Id = (Int32)lettore[0];
                    ruolo.Nome = (String)lettore[1];
                    ruolo.Desc = (String)lettore[2];
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
        public List<Ruolo> listaRuoli(String n)
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
                    Ruolo ruolo = new Ruolo();
                    ruolo.Id = (Int32)lettore[0];
                    ruolo.Nome = (String)lettore[1];
                    ruolo.Desc = (String)lettore[2];
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
        public Ruolo cercaRuoli(int id)
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
                    Ruolo r = new Ruolo();
                    r.Id = (Int32)lettore[0];
                    r.Nome = (String)lettore[1];
                    r.Desc = (String)lettore[2];
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
        public List<Ruolo> filtroRuoli(String s, String g)
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
                    Ruolo r = new Ruolo();
                    r.Id = (Int32)lettore[0];
                    r.Nome = (String)lettore[1];
                    r.Desc = (String)lettore[2];
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
        public void aggiornaRuoli(int id, String nome, String desc)
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
        public void rimuoviRuolo(int id)
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
        MySqlConnection con = null;

        public BozzaDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void inserimento(String data, String pacchetto, String importo, String numerocommessa)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `BOZZA`(`DATA`, `PACCHETTO`,`IMPORTO`,`NUMEROCOMMESSA`) VALUES('" + data + "','" + pacchetto + "','" + importo + "','" + numerocommessa + "'", con);
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
        public List<Bozza> listaBozza()
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
                    Bozza bozza = new Bozza();
                    bozza.Id = (Int32)lettore[0];
                    bozza.Data = (DateTime)lettore[1];
                    bozza.Pacchetto = (Int32)lettore[2];
                    bozza.Importo = (Double)lettore[3];
                    bozza.NumeroCommessa = (String)lettore[4];
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
        public List<Bozza> listaBozza(String n)
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
                    Bozza bozza = new Bozza();
                    bozza.Id = (Int32)lettore[0];
                    bozza.Data = (DateTime)lettore[1];
                    bozza.Pacchetto = (Int32)lettore[2];
                    bozza.Importo = (Double)lettore[3];
                    bozza.NumeroCommessa = (String)lettore[4];
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
        public Bozza cercaBozza(int id)
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
                    Bozza b = new Bozza();
                    bozza.Id = (Int32)lettore[0];
                    bozza.Data = (DateTime)lettore[1];
                    bozza.Pacchetto = (Int32)lettore[2];
                    bozza.Importo = (Double)lettore[3];
                    bozza.NumeroCommessa = (String)lettore[4];
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
        public List<Bozza> filtroBozza(String s, String g)
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
                    Bozza b = new Bozza();
                    b.Id = (Int32)lettore[0];
                    b.Data = (DateTime)lettore[1];
                    b.Pacchetto = (Int32)lettore[2];
                    b.Importo = (Double)lettore[3];
                    b.NumeroCommessa = (String)lettore[4];
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
        public void aggiornaBozza(int id, String data, String pacchetto, String importo, String numerocommessa)
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
        public void rimuoviBozza(int id)
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
        MySqlConnection con = null;

        public CommessaDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void inserimento(String ditta, String tipologia, String numerocommessa, String data, String referente)
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
        public List<Commessa> listaCommesse()
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
                    Commessa commessa = new Commessa();
                    commessa.Id = (Int32)lettore[0];
                    commessa.Ditta = (Int32)lettore[1];
                    commessa.Tipologia = (Int32)lettore[2];
                    commessa.NumeroCommessa = (String)lettore[3];
                    commessa.Data = (DateTime)lettore[4];
                    commessa.Referente = (String)lettore[5];
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
        public List<Commessa> listaCommesse(String n)
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
                    Commessa commessa = new Commessa();
                    commessa.Id = (Int32)lettore[0];
                    commessa.Ditta = (Int32)lettore[1];
                    commessa.Tipologia = (Int32)lettore[2];
                    commessa.NumeroCommessa = (String)lettore[3];
                    commessa.Data = (DateTime)lettore[4];
                    commessa.Referente = (String)lettore[5];
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
        public Commessa cercaCommesse(int id)
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
        public List<Commessa> filtroCommesse(String s, String g)
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
                    Commessa c = new Commessa();
                    c.Id = (Int32)lettore[0];
                    c.Ditta = (Int32)lettore[1];
                    c.Tipologia = (Int32)lettore[2];
                    c.NumeroCommessa = (String)lettore[3];
                    c.Data = (DateTime)lettore[4];
                    c.Referente = (String)lettore[5];
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
        public void aggiornaCommesse(int id, String ditta, String tipologia, String numerocommessa, String data, String referente)
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
        public void rimuoviCommessa(int id)
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
        MySqlConnection con = null;

        public LavorazioniDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void inserimento(String operazione, String pacchetto, String importo)
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
        public List<Lavorazione> listaLavorazioni()
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
                    Lavorazione lavorazione = new Lavorazione();
                    lavorazione.Id = (Int32)lettore[0];
                    lavorazione.Operazione = (String)lettore[1];
                    lavorazione.Pacchetto = (Int32)lettore[2];
                    lavorazione.Importo = (Double)lettore[3]; ;
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
        public List<Lavorazione> listaLavorazioni(String n)
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
                    Lavorazione lavorazione = new Lavorazione();
                    lavorazione.Id = (Int32)lettore[0];
                    lavorazione.Operazione = (String)lettore[1];
                    lavorazione.Pacchetto = (Int32)lettore[2];
                    lavorazione.Importo = (Double)lettore[3]; ;
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
        public Lavorazione cercaLavorazione(int id)
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
        public List<Lavorazione> filtroLavorazioni(String s, String g)
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
                    Lavorazione l = new Lavorazione();
                    l.Id = (Int32)lettore[0];
                    l.Operazione = (String)lettore[1];
                    l.Pacchetto = (Int32)lettore[2];
                    l.Importo = (Double)lettore[3]; ;
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
        public void aggiornaLavorazioni(int id, String operazione, String pacchetto, String importo)
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
        public void rimuoviLavorazioni(int id)
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

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public string Cap { get => cap; set => cap = value; }
        public string Citta { get => citta; set => citta = value; }
        public string Email { get => email; set => email = value; }
        public string Iva { get => iva; set => iva = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Pec { get => pec; set => pec = value; }
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
}


