using MySql.Data.MySqlClient;
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
        public void upgradeUtente(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono)
        {
            try
            {
                ClienteDB cDB = new ClienteDB(conn);
                cDB.aggiornaUtente(id, nome, indirizzo, cap, citta, pec, email, partitaIva, telefono);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void cancellaUtente(int id)
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
        public void aggiornaUtente(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String telefono)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `ANAGRAFICACLIENTI` SET `NOME`='" + nome + "',`INDIRIZZO`='" + indirizzo + "',`CAP`='" + cap + "',`CITTA`='" + citta + "',`PEC`='" + pec + "',`EMAIL`='" + email + "',`PARTITAIVA`='" + partitaIva + "',`TELEFONO`='" + telefono + "' WHERE `ID` = '" + id + "'", con);
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
        private Contatto contatto;

        public ContattoDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void inserimento(String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String ditta, String cellulare, String telefono, String ruolo)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `ANAGRAFICACONTATTI`(`NOME`, `INDIRIZZO`, `CAP`, `CITTA`, `PEC`, `EMAIL`, `PARTITAIVA`, `DITTA`,`TELEFONOCELLULARE`,`TELEFONOFISSO`, `RUOLO`) VALUES('" + nome + "','" + indirizzo + "','" + cap + "','" + citta + "','" + pec + "','" + email + "','" + partitaIva + "','" + ditta + "','" + cellulare + "','" + telefono + "','" + ruolo + "'", con);
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
                    contatto.Telefono = (String)lettore[10];
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
                    contatto.Telefono = (String)lettore[10];
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
                    contatto.Telefono = (String)lettore[10];
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
        public void aggiornaContatto(int id, String nome, String indirizzo, String cap, String citta, String pec, String email, String partitaIva, String ditta, String cellulare, string telefono, string ruolo)
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
        private String ditta;
        private String cellulare;
        private String telefono;
        private String ruolo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public string Cap { get => cap; set => cap = value; }
        public string Citta { get => citta; set => citta = value; }
        public string Pec { get => pec; set => pec = value; }
        public string Email { get => email; set => email = value; }
        public string Iva { get => iva; set => iva = value; }
        public string Ditta { get => ditta; set => ditta = value; }
        public string Cellulare { get => cellulare; set => cellulare = value; }
        public string Tel { get => telefono; set => telefono = value; }
        public string Ruolo { get => ruolo; set => ruolo = value; }
        public string Telefono { get; internal set; }
    }
}


