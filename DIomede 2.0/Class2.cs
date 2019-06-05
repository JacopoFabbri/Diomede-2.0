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
            List<Cliente> lista = null;
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
            List<Cliente> lista = null;
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
                cDB.rimuoviUtente(id);
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
            List<Cliente> lista = null;
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
            List<Cliente> lista = null;
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
        public void rimuoviUtente(int id)
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
}
