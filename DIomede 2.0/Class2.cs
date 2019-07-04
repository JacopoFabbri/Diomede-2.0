using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;

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
        public List<Contatto> CercaContatti()
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
        public void InserimentoBozza(DateTime data, String pacchetto, Double importo, String numerocommessa, int cliente, Boolean accettazione)
        {
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                bDB.Inserimento(data, pacchetto, importo, numerocommessa, cliente, accettazione);
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
        public void UpdateBozza(int id, DateTime data, String pacchetto, Double importo, String numerocommessa, int cliente, Boolean accettazione)
        {
            try
            {
                BozzaDB bDB = new BozzaDB(conn);
                bDB.AggiornaBozza(id, data, pacchetto, importo, numerocommessa, cliente, accettazione);
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
        public void InserimentoTipologiaMacrolavorazione(String nome, String desc)
        {
            try
            {
                TipologiaMacroLavorazioniDB bDB = new TipologiaMacroLavorazioniDB(conn);
                bDB.Inserimento(nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<TipologiaMacroLavorazione> CercaTipologiaMacroLavorazione()
        {
            List<TipologiaMacroLavorazione> lista;
            try
            {
                TipologiaMacroLavorazioniDB bDB = new TipologiaMacroLavorazioniDB(conn);
                lista = bDB.ListaMacroLavorazioni();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<TipologiaMacroLavorazione> CercaTipologiaMacroLavorazione(String n)
        {
            List<TipologiaMacroLavorazione> lista;
            try
            {
                TipologiaMacroLavorazioniDB bDB = new TipologiaMacroLavorazioniDB(conn);
                lista = bDB.ListaMacroLavorazioni(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public TipologiaMacroLavorazione CercaTipologiaMacroLavorazione(int id)
        {
            TipologiaMacroLavorazione contatto;
            try
            {
                TipologiaMacroLavorazioniDB bDB = new TipologiaMacroLavorazioniDB(conn);
                contatto = bDB.CercaLavorazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<TipologiaMacroLavorazione> FiltraTipologiaMacroLavorazione(String s, String g)
        {
            List<TipologiaMacroLavorazione> contatto;
            try
            {
                TipologiaMacroLavorazioniDB bDB = new TipologiaMacroLavorazioniDB(conn);
                contatto = bDB.FiltroLavorazioni(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdateTipologiaMacroLavorazione(int id, String nome, String desc)
        {
            try
            {
                TipologiaMacroLavorazioniDB bDB = new TipologiaMacroLavorazioniDB(conn);
                bDB.AggiornaLavorazioni(id, nome, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaTipologiaMacroLavorazione(int id)
        {
            try
            {
                TipologiaMacroLavorazioniDB bDB = new TipologiaMacroLavorazioniDB(conn);
                bDB.RimuoviLavorazioni(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoPacchetto(String nome, String desc, int id)
        {
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                bDB.Inserimento(nome, desc, id);
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
        public void UpdatePacchetto(int id, String nome, String desc,int tipo)
        {
            try
            {
                PacchettoDB bDB = new PacchettoDB(conn);
                bDB.AggiornaPacchetto(id, nome, desc, tipo);
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
        public void InserimentoLavorazione(String operazione, int pacchetto, double importo, String desc)
        {
            try
            {
                LavorazioniDB bDB = new LavorazioniDB(conn);
                bDB.Inserimento(operazione, pacchetto, importo, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<Lavorazione> CercaLavorazione()
        {
            List<Lavorazione> lista;
            try
            {
                LavorazioniDB bDB = new LavorazioniDB(conn);
                lista = bDB.ListaLavorazioni();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Lavorazione> CercaLavorazione(String n)
        {
            List<Lavorazione> lista;
            try
            {
                LavorazioniDB bDB = new LavorazioniDB(conn);
                lista = bDB.ListaLavorazioni(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public Lavorazione CercaLavorazione(int id)
        {
            Lavorazione contatto;
            try
            {
                LavorazioniDB bDB = new LavorazioniDB(conn);
                contatto = bDB.CercaLavorazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Lavorazione> FiltraLavorazione(String s, String g)
        {
            List<Lavorazione> contatto;
            try
            {
                LavorazioniDB bDB = new LavorazioniDB(conn);
                contatto = bDB.FiltroLavorazioni(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdateLavorazione(int id, String operazione, int pacchetto, double importo, String desc)
        {
            try
            {
                LavorazioniDB bDB = new LavorazioniDB(conn);
                bDB.AggiornaLavorazioni(id, operazione, pacchetto, importo, desc);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaLavorazione(int id)
        {
            try
            {
                LavorazioniDB bDB = new LavorazioniDB(conn);
                bDB.RimuoviLavorazioni(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoMacrolavorazione(String nome, DateTime dataInizio, DateTime dataFine, double prezzo, String numerocommessa, int tipologia, String desc, int commessa)
        {
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                bDB.Inserimento(nome, dataInizio, dataFine, prezzo, numerocommessa, tipologia, desc, commessa);
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
        public void UpdateMacroLavorazione(int id, String nome, DateTime dataInizio, DateTime dataFine, double prezzo, String numerocommessa, int tipologia, String desc)
        {
            try
            {
                MacroLavorazioniDB bDB = new MacroLavorazioniDB(conn);
                bDB.AggiornaLavorazioni(id, nome, dataInizio, dataFine, prezzo, numerocommessa, tipologia, desc);
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
        public void InserimentoTipologialavorazione(String nome, String desc, double prezzo, String scadenze, int macrolavorazione)
        {
            try
            {
                TipologiaLavorazioniDB bDB = new TipologiaLavorazioniDB(conn);
                bDB.Inserimento(nome, desc, prezzo, scadenze, macrolavorazione);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public List<TipologiaLavorazione> CercaTipologiaLavorazione()
        {
            List<TipologiaLavorazione> lista;
            try
            {
                TipologiaLavorazioniDB bDB = new TipologiaLavorazioniDB(conn);
                lista = bDB.ListaMacroLavorazioni();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<TipologiaLavorazione> CercaTipologiaLavorazione(String n)
        {
            List<TipologiaLavorazione> lista;
            try
            {
                TipologiaLavorazioniDB bDB = new TipologiaLavorazioniDB(conn);
                lista = bDB.ListaMacroLavorazioni(n);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public TipologiaLavorazione CercaTipologiaLavorazione(int id)
        {
            TipologiaLavorazione contatto;
            try
            {
                TipologiaLavorazioniDB bDB = new TipologiaLavorazioniDB(conn);
                contatto = bDB.CercaLavorazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<TipologiaLavorazione> FiltraTipologiaLavorazione(String s, String g)
        {
            List<TipologiaLavorazione> contatto;
            try
            {
                TipologiaLavorazioniDB bDB = new TipologiaLavorazioniDB(conn);
                contatto = bDB.FiltroLavorazioni(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdateTipologiaLavorazione(int id, String nome, String desc, double prezzo, String scadenze, int macrolavorazione)
        {
            try
            {
                TipologiaLavorazioniDB bDB = new TipologiaLavorazioniDB(conn);
                bDB.AggiornaLavorazioni(id, nome, desc, prezzo, scadenze, macrolavorazione);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void CancellaTipologiaLavorazione(int id)
        {
            try
            {
                TipologiaLavorazioniDB bDB = new TipologiaLavorazioniDB(conn);
                bDB.RimuoviLavorazioni(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoCommessa(int ditta, String numerocommessa, DateTime data, String referente, int bozza, String indirizzoCantiere, String tecnico, String note)
        {
            try
            {
                CommessaDB bDB = new CommessaDB(conn);
                bDB.Inserimento(ditta, numerocommessa, data, referente, bozza, indirizzoCantiere, tecnico,note);
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
                CommessaDB bDB = new CommessaDB(conn);
                lista = bDB.ListaCommesse();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Commessa> CercaCommessa(String n)
        {
            List<Commessa> lista;
            try
            {
                CommessaDB bDB = new CommessaDB(conn);
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
                CommessaDB bDB = new CommessaDB(conn);
                contatto = bDB.CercaCommesse(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Commessa> FiltraCommessa(String s, String g)
        {
            List<Commessa> contatto;
            try
            {
                CommessaDB bDB = new CommessaDB(conn);
                contatto = bDB.FiltroCommesse(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdateCommessa(int id, int ditta, String numeroCommessa, DateTime data, String referente, String indirizzoCantiere, String tecnico, String note)
        {
            try
            {
                CommessaDB bDB = new CommessaDB(conn);
                bDB.AggiornaCommesse(id, ditta, numeroCommessa, data, referente, indirizzoCantiere, tecnico, note);
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
                CommessaDB bDB = new CommessaDB(conn);
                bDB.RimuoviCommessa(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoPagamento(String numeroCommessa, double importo, String note, String fattura, DateTime dataFattura, DateTime data, int cliente, int commessa)
        {
            try
            {
                PagamentoDB bDB = new PagamentoDB(conn);
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
                PagamentoDB bDB = new PagamentoDB(conn);
                lista = bDB.ListaOperazione();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Pagamento> CercaPagamento(String n)
        {
            List<Pagamento> lista;
            try
            {
                PagamentoDB bDB = new PagamentoDB(conn);
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
                PagamentoDB bDB = new PagamentoDB(conn);
                contatto = bDB.CercaOperazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Pagamento> FiltraPagamento(String s, String g)
        {
            List<Pagamento> contatto;
            try
            {
                PagamentoDB bDB = new PagamentoDB(conn);
                contatto = bDB.FiltroOperazione(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdatePagamento(int id, String numeroCommessa, double importo, String note, String fattura, DateTime dataFattura, DateTime data, int cliente, int commessa)
        {
            try
            {
                PagamentoDB bDB = new PagamentoDB(conn);
                bDB.AggiornaOperazione(id, numeroCommessa, importo, note, fattura, dataFattura, data, cliente, commessa);
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
                PagamentoDB bDB = new PagamentoDB(conn);
                bDB.RimuoviOperazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public void InserimentoLavorazioni(String nome, String desc, String scadenze, int macro, double prezzo)
        {
            try
            {
                LavorazioneDB bDB = new LavorazioneDB(conn);
                bDB.Inserimento(nome, desc, scadenze, macro, prezzo);
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
                LavorazioneDB bDB = new LavorazioneDB(conn);
                lista = bDB.ListaLavorazioni();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return lista;
        }
        public List<Lavorazioni> CercaLavorazioni(String n)
        {
            List<Lavorazioni> lista;
            try
            {
                LavorazioneDB bDB = new LavorazioneDB(conn);
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
                LavorazioneDB bDB = new LavorazioneDB(conn);
                contatto = bDB.CercaLavorazione(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public List<Lavorazioni> FiltraLavorazioni(String s, String g)
        {
            List<Lavorazioni> contatto;
            try
            {
                LavorazioneDB bDB = new LavorazioneDB(conn);
                contatto = bDB.FiltroLavorazioni(s, g);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return contatto;
        }
        public void UpdateLavorazioni(int id, String nome, String desc, String scadenze, int macro, double prezzo)
        {
            try
            {
                LavorazioneDB bDB = new LavorazioneDB(conn);
                bDB.AggiornaLavorazioni(id, nome, desc, scadenze, macro, prezzo);
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
                LavorazioneDB bDB = new LavorazioneDB(conn);
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
        public void Inserimento(DateTime data, String pacchetto, Double importo, String numerocommessa, int cliente, Boolean accettazione)
        {
            try
            {
                con.Open();
                MySqlCommand command;
                if (accettazione)
                {
                    command = new MySqlCommand("INSERT INTO `BOZZA`(`DATA`, `PACCHETTO`,`IMPORTO`,`NUMEROCOMMESSA`,`CLIENTE`,`ACCETTAZIONE`) VALUES('" + data.ToString("yyyy/MM/dd") + "','" + pacchetto + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + numerocommessa + "','" + cliente + "','1')", con);
                }
                else
                {
                    command = new MySqlCommand("INSERT INTO `BOZZA`(`DATA`, `PACCHETTO`,`IMPORTO`,`NUMEROCOMMESSA`,`CLIENTE`,`ACCETTAZIONE`) VALUES('" + data.ToString("yyyy/MM/dd") + "','" + pacchetto + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + numerocommessa + "','" + cliente + "','0')", con);
                }
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
            List<Bozza> lista = new List<Bozza>();
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
                        IdentificativoPreventivo = "" + lettore[4],
                        Cliente = (Int32)lettore[5],
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
        public List<Bozza> ListaBozza(String n)
        {
            List<Bozza> lista = new List<Bozza>();
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
                        IdentificativoPreventivo = "" + lettore[4],
                        Cliente = (Int32)lettore[5],
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
                        IdentificativoPreventivo = "" + lettore[4],
                        Cliente = (Int32)lettore[5],
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
                        IdentificativoPreventivo = (String)lettore[4],
                        Cliente = (Int32)lettore[5],
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
        public void AggiornaBozza(int id, DateTime data, String pacchetto, Double importo, String numerocommessa, int cliente, bool accettazione)
        {
            try
            {
                con.Open();
                MySqlCommand command;
                if (accettazione)
                {
                    command = new MySqlCommand("UPDATE `BOZZA` SET `DATA`='" + data.ToString("yyyy/MM/dd") + "',`PACCHETTO`='" + pacchetto + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "',`NUMEROCOMMESSA`='" + numerocommessa + "',`CLIENTE`='" + cliente + "',`ACCETTAZIONE`='1' WHERE `ID` = '" + id + "'", con);
                }
                else
                {
                    command = new MySqlCommand("UPDATE `BOZZA` SET `DATA`='" + data.ToString("yyyy/MM/dd") + "',`PACCHETTO`='" + pacchetto + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "',`NUMEROCOMMESSA`='" + numerocommessa + "',`CLIENTE`='" + cliente + "',`ACCETTAZIONE`='0' WHERE `ID` = '" + id + "'", con);
                }
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
        public void Inserimento(int ditta, String numerocommessa, DateTime data, String referente, int bozza,String indirizzoCantiere, String tecnico, String note)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `COMMESSA`(`DITTA`, `NUMEROCOMMESSA`, `DATA`, `REFERENTE`, `BOZZA`,`INDIRIZZOCANTIERE`,`TECNICOINTERNO`, `NOTE`) VALUES('" + ditta + "','" + numerocommessa + "','" + data.ToString("yyyy/MM/dd") + "','" + referente + "','" + bozza + "','" + indirizzoCantiere + "','" + tecnico + "','" + note + "')", con);
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
            List<Commessa> lista = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {

                    if (!(lettore[3] + "").Equals(""))
                    {
                        DateTime.TryParse(lettore[3] + "", out dateValue);
                        Commessa c = new Commessa
                        {
                            Id = (Int32)lettore[0],
                            Ditta = (Int32)lettore[1],
                            NumeroCommessa = (String)lettore[2],
                            Data = dateValue,
                            Referente = "" + lettore[4],
                            Bozza = (int)lettore[5],
                            IndirizzoCantiere = "" + lettore[6],
                            TecnicoInterno = "" + lettore[7],
                            Note = "" + lettore [8]
                        };
                        lista.Add(c);
                    }
                    else
                    {
                        Commessa c = new Commessa
                        {
                            Id = (Int32)lettore[0],
                            Ditta = (Int32)lettore[1],
                            NumeroCommessa = (String)lettore[2],
                            Data = new DateTime(),
                            Referente = "" + lettore[4],
                            Bozza = (int)lettore[5]
                        };
                        lista.Add(c);
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
            return lista;
        }
        public List<Commessa> ListaCommesse(String n)
        {
            DateTime dateValue;
            List<Commessa> lista = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    if (!(lettore[3] + "").Equals(""))
                    {
                        DateTime.TryParse(lettore[3] + "", out dateValue);
                        Commessa c = new Commessa
                        {
                            Id = (Int32)lettore[0],
                            Ditta = (Int32)lettore[1],
                            NumeroCommessa = (String)lettore[2],
                            Data = dateValue,
                            Referente = "" + lettore[4],
                            Bozza = (int)lettore[5],
                            IndirizzoCantiere = "" + lettore[6],
                            TecnicoInterno = "" + lettore[7],
                            Note = "" + lettore[8]
                        };
                        lista.Add(c);
                    }
                    else
                    {
                        Commessa c = new Commessa
                        {
                            Id = (Int32)lettore[0],
                            Ditta = (Int32)lettore[1],
                            NumeroCommessa = (String)lettore[2],
                            Data = new DateTime(),
                            Referente = "" + lettore[4],
                            Bozza = (int)lettore[5],
                            IndirizzoCantiere = "" + lettore[6],
                            TecnicoInterno = "" + lettore[7],
                            Note = "" + lettore[8]
                        };
                        lista.Add(c);
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
            return lista;
        }
        public Commessa CercaCommesse(int id)
        {
            DateTime dateValue;
            Commessa commessa = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {

                    if (!(lettore[3] + "").Equals(""))
                    {
                        DateTime.TryParse(lettore[3] + "", out dateValue);
                        Commessa c = new Commessa
                        {
                            Id = (Int32)lettore[0],
                            Ditta = (Int32)lettore[1],
                            NumeroCommessa = (String)lettore[2],
                            Data = dateValue,
                            Referente = "" + lettore[4],
                            Bozza = (int)lettore[5],
                            IndirizzoCantiere = "" + lettore[6],
                            TecnicoInterno = "" + lettore[7],
                            Note = "" + lettore[8]
                        };
                        commessa = c;
                    }
                    else
                    {
                        Commessa c = new Commessa
                        {
                            Id = (Int32)lettore[0],
                            Ditta = (Int32)lettore[1],
                            NumeroCommessa = (String)lettore[2],
                            Data = new DateTime(),
                            Referente = "" + lettore[4],
                            Bozza = (int)lettore[5],
                            IndirizzoCantiere = "" + lettore[6],
                            TecnicoInterno = "" + lettore[7],
                            Note = "" + lettore[8]
                        };
                        commessa = c;
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
            return commessa;
        }
        public List<Commessa> FiltroCommesse(String s, String g)
        {
            DateTime dateValue;
            List<Commessa> commessa = new List<Commessa>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `COMMESSA` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    if (!(lettore[3] + "").Equals(""))
                    {
                        DateTime.TryParse(lettore[3] + "", out dateValue);
                        Commessa c = new Commessa
                        {
                            Id = (Int32)lettore[0],
                            Ditta = (Int32)lettore[1],
                            NumeroCommessa = (String)lettore[2],
                            Data = dateValue,
                            Referente = "" + lettore[4],
                            Bozza = (int)lettore[5],
                            IndirizzoCantiere = "" + lettore[6],
                            TecnicoInterno = "" + lettore[7],
                            Note = "" + lettore[8]
                        };
                        commessa.Add(c);
                    }
                    else
                    {
                        Commessa c = new Commessa
                        {
                            Id = (Int32)lettore[0],
                            Ditta = (Int32)lettore[1],
                            NumeroCommessa = (String)lettore[2],
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
        public void AggiornaCommesse(int id, int ditta, String numerocommessa, DateTime data, String referente, String indirizzoCantiere, String tecnico, String note)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `COMMESSA` SET `DITTA`='" + ditta + "',`NUMEROCOMMESSA`='" + numerocommessa + "',`DATA`='" + data.ToString("yyyy/MM/dd") + "',`REFERENTE`='" + referente + "',`INDIRIZZOCANTIERE`='" + indirizzoCantiere + "',`TECNICOINTERNO`='" + tecnico + "',`NOTE`='" + note + "' WHERE `ID` = '" + id + "'", con);
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
        public void Inserimento(String operazione, int pacchetto, double importo, String desc)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `LAVORAZIONE`( `OPERAZIONE`, `PACCHETTO`, `IMPORTO`, `DESC`) VALUES('" + operazione + "','" + pacchetto + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + desc + "')", con);
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
                        Importo = (Double)lettore[3],
                        Desc = (String)lettore[4]
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
                        Importo = (Double)lettore[3],
                        Desc = (String)lettore[4]
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
                    Lavorazione l = new Lavorazione
                    {
                        Id = (Int32)lettore[0],
                        Operazione = (String)lettore[1],
                        Pacchetto = (Int32)lettore[2],
                        Importo = (Double)lettore[3],
                        Desc = (String)lettore[4]
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
                        Importo = (Double)lettore[3],
                        Desc = (String)lettore[4]
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
        public void AggiornaLavorazioni(int id, String operazione, int pacchetto, double importo, String desc)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `LAVORAZIONE` SET `OPERAZIONE`='" + operazione + "',`PACCHETTO`='" + pacchetto + "',`IMPORTO`='" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "',`DESC`='" + desc + "' WHERE `ID` = '" + id + "'", con);
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
    public class LavorazioneDB
    {
        readonly MySqlConnection con = null;

        public LavorazioneDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, String desc, String scadenze, int macro, double prezzo)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `LAVORAZIONI`( `NOME`, `DESC`, `SCADENZE`, `MACROLAVORAZIONE`, `PREZZO`) VALUES('" + nome + "','" + desc + "','" + scadenze + "','" + macro + "','" + prezzo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "')", con);
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
            List<Lavorazioni> lista = new List<Lavorazioni>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `LAVORAZIONI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Lavorazioni lavorazione = new Lavorazioni
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Desc = (String)lettore[2],
                        Scadenze = (String)lettore[3],
                        MacroLavorazione = (Int32)lettore[4],
                        Prezzo = (double)lettore[5]
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
        public List<Lavorazioni> ListaLavorazioni(String n)
        {
            List<Lavorazioni> lista = new List<Lavorazioni>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `LAVORAZIONI` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Lavorazioni lavorazione = new Lavorazioni
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Desc = (String)lettore[2],
                        Scadenze = (String)lettore[3],
                        MacroLavorazione = (Int32)lettore[4],
                        Prezzo = (double)lettore[5]
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `LAVORAZIONI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Lavorazioni l = new Lavorazioni
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Desc = (String)lettore[2],
                        Scadenze = (String)lettore[3],
                        MacroLavorazione = (Int32)lettore[4],
                        Prezzo = (double)lettore[5]
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
        public List<Lavorazioni> FiltroLavorazioni(String s, String g)
        {
            List<Lavorazioni> lavorazione = new List<Lavorazioni>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `LAVORAZIONI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Lavorazioni l = new Lavorazioni
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Desc = (String)lettore[2],
                        Scadenze = (String)lettore[3],
                        MacroLavorazione = (Int32)lettore[4],
                        Prezzo = (double)lettore[5]
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
        public void AggiornaLavorazioni(int id, String nome, String desc, String scadenze, int macro, double prezzo)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `LAVORAZIONI` SET `NOME`='" + nome + "',`DESC`='" + desc + "',`SCADENZE`='" + scadenze + "',`MACROLAVORAZIONE`='" + macro + "',`PREZZO`='" + prezzo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `LAVORAZIONI` WHERE `ID` = '" + id + "'", con);
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
    public class TipologiaMacroLavorazioniDB
    {
        readonly MySqlConnection con = null;

        public TipologiaMacroLavorazioniDB(MySqlConnection conn)
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
        public List<TipologiaMacroLavorazione> ListaMacroLavorazioni()
        {
            List<TipologiaMacroLavorazione> lista = new List<TipologiaMacroLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIAMACROLAVORAZIONI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    TipologiaMacroLavorazione lavorazione = new TipologiaMacroLavorazione
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
        public List<TipologiaMacroLavorazione> ListaMacroLavorazioni(String n)
        {
            List<TipologiaMacroLavorazione> lista = new List<TipologiaMacroLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIAMACROLAVORAZIONI` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    TipologiaMacroLavorazione lavorazione = new TipologiaMacroLavorazione
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
        public TipologiaMacroLavorazione CercaLavorazione(int id)
        {
            TipologiaMacroLavorazione lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIAMACROLAVORAZIONI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    TipologiaMacroLavorazione l = new TipologiaMacroLavorazione
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
        public List<TipologiaMacroLavorazione> FiltroLavorazioni(String s, String g)
        {
            List<TipologiaMacroLavorazione> lavorazione = new List<TipologiaMacroLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIAMACROLAVORAZIONI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    TipologiaMacroLavorazione l = new TipologiaMacroLavorazione
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
        public void Inserimento(String nome, String note, int id)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `PACCHETTO`(`NOME`, `NOTE`, `TIPOLOGIAMACROLAVORAZIONE`) VALUES ('" + nome + "','" + note + "','" + id + "')", con);
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
                        TipologiaMacro = (Int32)lettore[3]
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
                        TipologiaMacro = (Int32)lettore[3]
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
                        Note = "" + lettore[2],
                        TipologiaMacro = (Int32)lettore[3]
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
                        TipologiaMacro = (Int32)lettore[3]
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
        public void AggiornaPacchetto(int id, String nome, String desc, int tipo)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `PACCHETTO` SET `NOME`='" + nome + "',`NOTE`='" + desc + "',`TIPOLOGIAMACROLAVORAZIONE`='" + tipo + "' WHERE `ID` = '" + id + "'", con);
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
    public class MacroLavorazioniDB
    {
        readonly MySqlConnection con = null;

        public MacroLavorazioniDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, DateTime dataInizio, DateTime dataFine, double prezzo, String numerocommessa, int tipologia, String desc, int commessa)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `MACROLAVORAZIONI`(`NOME`, `DATAINIZIO`, `DATAFINE`, `PREZZO`, `NUMEROCOMMESSA`, `TIPOLOGIA`, `DESCRIZIONE`, `COMMESSA`) VALUES('" + nome + "','" + dataInizio.ToString("yyyy/MM/dd") + "','" + dataFine.ToString("yyyy/MM/dd") + "','" + prezzo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + numerocommessa + "','" + tipologia + "','" + desc + "','" + commessa + "')", con);
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `MACROLAVORAZIONI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    MacroLavorazione lavorazione = new MacroLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        DataInizio = (DateTime)lettore[2],
                        DataFine = (DateTime)lettore[3],
                        Prezzo = (Double)lettore[4],
                        NumeroCommessa = (String)lettore[5],
                        Tipologia = (int)lettore[6],
                        Descrizione = (String)lettore[7]
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `MACROLAVORAZIONI` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    MacroLavorazione lavorazione = new MacroLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        DataInizio = (DateTime)lettore[2],
                        DataFine = (DateTime)lettore[3],
                        Prezzo = (Double)lettore[4],
                        NumeroCommessa = (String)lettore[5],
                        Tipologia = (int)lettore[6],
                        Descrizione = (String)lettore[7]
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `MACROLAVORAZIONI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    MacroLavorazione l = new MacroLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        DataInizio = (DateTime)lettore[2],
                        DataFine = (DateTime)lettore[3],
                        Prezzo = (Double)lettore[4],
                        NumeroCommessa = (String)lettore[5],
                        Tipologia = (int)lettore[6],
                        Descrizione = (String)lettore[7]
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `MACROLAVORAZIONI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    MacroLavorazione l = new MacroLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        DataInizio = (DateTime)lettore[2],
                        DataFine = (DateTime)lettore[3],
                        Prezzo = (Double)lettore[4],
                        NumeroCommessa = (String)lettore[5],
                        Tipologia = (int)lettore[6],
                        Descrizione = (String)lettore[7]
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
        public void AggiornaLavorazioni(int id, String nome, DateTime dataInizio, DateTime dataFine, double prezzo, String numerocommessa, int tipologia, String desc)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `TIPOLOGIAMACROLAVORAZIONI` SET `NOME`='" + nome + "',`DATAINIZIO`='" + dataInizio + "',`DATAFINE`='" + dataFine + "',`PREZZO`='" + prezzo + "',`NUMEROCOMMESSA`='" + numerocommessa + "',`TIPOLOGIA`='" + tipologia + "',`DESCRIZION`='" + desc + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `MACROLAVORAZIONI` WHERE `ID` = '" + id + "'", con);
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
    public class TipologiaLavorazioniDB
    {
        readonly MySqlConnection con = null;

        public TipologiaLavorazioniDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String nome, String desc, double prezzo, String scadenze, int macrolavorazione)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `TIPOLOGIALAVORAZIONE`(`NOME`, `DESCRIZIONE`, `PREZZO`, `SCADENZE`, `MACROLAVORAZIONE`) VALUES('" + nome + "','" + desc + "','" + prezzo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + scadenze + "','" + macrolavorazione + "')", con);
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
        public List<TipologiaLavorazione> ListaMacroLavorazioni()
        {
            List<TipologiaLavorazione> lista = new List<TipologiaLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIALAVORAZIONE`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    TipologiaLavorazione lavorazione = new TipologiaLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Descrizione = (String)lettore[2],
                        Prezzo = (Double)lettore[3],
                        Scadenze = (String)lettore[4],
                        Macrolavorazione = (int)lettore[5]
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
        public List<TipologiaLavorazione> ListaMacroLavorazioni(String n)
        {
            List<TipologiaLavorazione> lista = new List<TipologiaLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIALAVORAZIONE` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    TipologiaLavorazione lavorazione = new TipologiaLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Descrizione = (String)lettore[2],
                        Prezzo = (Double)lettore[3],
                        Scadenze = (String)lettore[4],
                        Macrolavorazione = (int)lettore[5]
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
        public TipologiaLavorazione CercaLavorazione(int id)
        {
            TipologiaLavorazione lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIALAVORAZIONE` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    TipologiaLavorazione l = new TipologiaLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Descrizione = (String)lettore[2],
                        Prezzo = (Double)lettore[3],
                        Scadenze = (String)lettore[4],
                        Macrolavorazione = (int)lettore[5]
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
        public List<TipologiaLavorazione> FiltroLavorazioni(String s, String g)
        {
            List<TipologiaLavorazione> lavorazione = new List<TipologiaLavorazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `TIPOLOGIALAVORAZIONE` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    TipologiaLavorazione l = new TipologiaLavorazione
                    {
                        Id = (Int32)lettore[0],
                        Nome = (String)lettore[1],
                        Descrizione = (String)lettore[2],
                        Prezzo = (Double)lettore[3],
                        Scadenze = (String)lettore[4],
                        Macrolavorazione = (int)lettore[5]
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
        public void AggiornaLavorazioni(int id, String nome, String desc, double prezzo, String scadenze, int macrolavorazione)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `TIPOLOGIALAVORAZIONE` SET `NOME`='" + nome + "',`DESCRIZIONE`='" + desc + "',`PREZZO`='" + prezzo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "',`SCADENZE`='" + scadenze + "',`MACROLAVORAZIONE`='" + macrolavorazione + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `TIPOLOGIALAVORAZIONE` WHERE `ID` = '" + id + "'", con);
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
    public class OperazioneDB
    {
        readonly MySqlConnection con = null;

        public OperazioneDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(int commitente, int tipologia, DateTime data, String dataProtocollo, String dataVisuraLuogo, double offerta, String numeroCommessa)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `OPERAZIONI`(`COMMITENTE`, `TIPOLOGIA`, `DATA`, `DATAPROTOCOLLO`, `DATAVISURALUOGO`, `OFFERTA`, `NUMEROCOMMESSA`) VALUES('" + commitente + "','" + tipologia + "','" + data + "','" + dataProtocollo + "','" + dataVisuraLuogo + "','" + offerta + "','" + numeroCommessa + "')", con);
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
        public List<Operazione> ListaOperazione()
        {
            List<Operazione> lista = new List<Operazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `OPERAZIONI`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Operazione lavorazione = new Operazione
                    {
                        Id = (Int32)lettore[0],
                        Commitente = (Int32)lettore[1],
                        Tipologia = (Int32)lettore[2],
                        Data = (DateTime)lettore[3],
                        DataProtocollo = (String)lettore[4],
                        DataVisuraSopraluogo = (String)lettore[5],
                        Offerta = (Double)lettore[6],
                        NumeroCommessa = (String)lettore[7],
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
        public List<Operazione> ListaOperazione(String n)
        {
            List<Operazione> lista = new List<Operazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `OPERAZIONI` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Operazione lavorazione = new Operazione
                    {

                        Id = (Int32)lettore[0],
                        Commitente = (Int32)lettore[1],
                        Tipologia = (Int32)lettore[2],
                        Data = (DateTime)lettore[3],
                        DataProtocollo = (String)lettore[4],
                        DataVisuraSopraluogo = (String)lettore[5],
                        Offerta = (Double)lettore[6],
                        NumeroCommessa = (String)lettore[7],
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
        public Operazione CercaOperazione(int id)
        {
            Operazione lavorazione = null;
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `OPERAZIONI` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Operazione l = new Operazione
                    {
                        Id = (Int32)lettore[0],
                        Commitente = (Int32)lettore[1],
                        Tipologia = (Int32)lettore[2],
                        Data = (DateTime)lettore[3],
                        DataProtocollo = (String)lettore[4],
                        DataVisuraSopraluogo = (String)lettore[5],
                        Offerta = (Double)lettore[6],
                        NumeroCommessa = (String)lettore[7],
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
        public List<Operazione> FiltroOperazione(String s, String g)
        {
            List<Operazione> lavorazione = new List<Operazione>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `OPERAZIONI` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    Operazione l = new Operazione
                    {
                        Id = (Int32)lettore[0],
                        Commitente = (Int32)lettore[1],
                        Tipologia = (Int32)lettore[2],
                        Data = (DateTime)lettore[3],
                        DataProtocollo = (String)lettore[4],
                        DataVisuraSopraluogo = (String)lettore[5],
                        Offerta = (Double)lettore[6],
                        NumeroCommessa = (String)lettore[7],
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
        public void AggiornaOperazione(int id, int commitente, int tipologia, DateTime data, String dataProtocollo, String dataVisuraLuogo, double offerta, String numeroCommessa)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `TIPOLOGIALAVORAZIONI` SET `COMMITENTE`='" + commitente + "',`TIPOLOGIA`='" + tipologia + "',`DATA`='" + data + "',`DATAPROTOCOLLO`='" + dataProtocollo + "',`DATAVISURALUOGO`='" + dataVisuraLuogo + "',`OFFERTA`='" + offerta + "',`NUMEROCOMMESSA`='" + numeroCommessa + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `OPERAZIONI` WHERE `ID` = '" + id + "'", con);
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
        readonly MySqlConnection con = null;

        public PagamentoDB(MySqlConnection conn)
        {
            con = conn;
        }
        public void Inserimento(String numeroCommessa, double importo, String note, String fattura, DateTime dataFattura, DateTime data, int cliente, int commessa)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `PAGAMENTO`(`NUMEROCOMMESSA`, `IMPORTO`, `NOTE`, `FATTURA`, `DATAFATTURA`, `DATA`, `CLIENTE`, `COMMESSA`) VALUES('" + numeroCommessa + "','" + importo.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "','" + note + "','" + fattura + "','" + dataFattura.ToString("yyyy/MM/dd") + "','" + data.ToString("yyyy/MM/dd") + "','" + cliente + "','" + commessa + "')", con);
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
            List<Pagamento> lista = new List<Pagamento>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `PAGAMENTO`", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[5] + "", out data);
                    DateTime.TryParse(lettore[6] + "", out dataFattura);
                    Pagamento lavorazione = new Pagamento
                    {
                        Id = (Int32)lettore[0],
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
        public List<Pagamento> ListaOperazione(String n)
        {
            DateTime data, dataFattura;
            List<Pagamento> lista = new List<Pagamento>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `PAGAMENTO` WHERE `ID` = '" + n + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[5] + "", out data);
                    DateTime.TryParse(lettore[6] + "", out dataFattura);
                    Pagamento lavorazione = new Pagamento
                    {
                        Id = (Int32)lettore[0],
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `PAGAMENTO` WHERE `ID` = '" + id + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[5] + "", out data);
                    DateTime.TryParse(lettore[6] + "", out dataFattura);
                    Pagamento l = new Pagamento
                    {
                        Id = (Int32)lettore[0],
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
        public List<Pagamento> FiltroOperazione(String s, String g)
        {
            DateTime data, dataFattura;
            List<Pagamento> lavorazione = new List<Pagamento>();
            try
            {
                con.Open();
                MySqlDataReader lettore = null;
                MySqlCommand command = new MySqlCommand("SELECT * FROM `PAGAMENTO` WHERE `" + s + "` = '" + g + "'", con);
                lettore = command.ExecuteReader();

                while (lettore.Read())
                {
                    DateTime.TryParse(lettore[5] + "", out data);
                    DateTime.TryParse(lettore[6] + "", out dataFattura);
                    Pagamento l = new Pagamento
                    {
                        Id = (Int32)lettore[0],
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
        public void AggiornaOperazione(int id, String numeroCommessa, double importo, String note, String fattura, DateTime dataFattura, DateTime data, int cliente, int commessa)
        {
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `PAGAMENTO` SET `NUMEROCOMMESSA`='" + numeroCommessa + "',`IMPORTO`='" + importo + "',`NOTE`='" + note + "',`FATTURA`='" + fattura + "',`DATAFATTURA`='" + dataFattura + "',`DATA`='" + data + "',`CLIENTE`='" + cliente + "',`COMMESSA`='" + commessa + "' WHERE `ID` = '" + id + "'", con);
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
                MySqlCommand command = new MySqlCommand("DELETE FROM `PAGAMENTO` WHERE `ID` = '" + id + "'", con);
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
        private String identificativoPreventivo;
        private int cliente;
        private Boolean accettazione;

        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Pacchetto { get => pacchetto; set => pacchetto = value; }
        public Double Importo { get => importo; set => importo = value; }
        public String IdentificativoPreventivo { get => identificativoPreventivo; set => identificativoPreventivo = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public bool Accettazione { get => accettazione; set => accettazione = value; }
    }
    public class Commessa
    {
        private int id;
        private int ditta;
        private String numeroCommessa;
        private DateTime data;
        private String referente;
        private int bozza;
        private String indirizzoCantiere;
        private String tecnicoInterno;
        private String note;


        public int Id { get => id; set => id = value; }
        public int Ditta { get => ditta; set => ditta = value; }
        public String NumeroCommessa { get => numeroCommessa; set => numeroCommessa = value; }
        public DateTime Data { get => data; set => data = value; }
        public String Referente { get => referente; set => referente = value; }
        public int Bozza { get => bozza; set => bozza = value; }
        public string IndirizzoCantiere { get => indirizzoCantiere; set => indirizzoCantiere = value; }
        public string Note { get => note; set => note = value; }
        public string TecnicoInterno { get => tecnicoInterno; set => tecnicoInterno = value; }
    }
    public class Lavorazione
    {
        private int id;
        private String operazione;
        private int pacchetto;
        private Double importo;
        private String desc;


        public int Id { get => id; set => id = value; }
        public String Operazione { get => operazione; set => operazione = value; }
        public int Pacchetto { get => pacchetto; set => pacchetto = value; }
        public Double Importo { get => importo; set => importo = value; }
        public string Desc { get => desc; set => desc = value; }
    }
    public class TipologiaMacroLavorazione
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
        private int tipologiaMacro;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Note { get => note; set => note = value; }
        public int TipologiaMacro { get => tipologiaMacro; set => tipologiaMacro = value; }
    }
    public class MacroLavorazione
    {
        private int id;
        private String nome;
        private DateTime dataInizio;
        private DateTime dataFine;
        private double prezzo;
        private String numeroCommessa;
        private int tipologia;
        private String descrizione;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataInizio { get => dataInizio; set => dataInizio = value; }
        public DateTime DataFine { get => dataFine; set => dataFine = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        public string NumeroCommessa { get => numeroCommessa; set => numeroCommessa = value; }
        public int Tipologia { get => tipologia; set => tipologia = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
    }
    public class TipologiaLavorazione
    {
        private int id;
        private String nome;
        private String descrizione;
        private Double prezzo;
        private String scadenze;
        private int macrolavorazione;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        public string Scadenze { get => scadenze; set => scadenze = value; }
        public int Macrolavorazione { get => macrolavorazione; set => macrolavorazione = value; }
    }
    public class Operazione
    {
        private int id;
        private int commitente;
        private int tipologia;
        private DateTime data;
        private String dataProtocollo;
        private String dataVisuraSopraluogo;
        private double offerta;
        private String numeroCommessa;

        public int Id { get => id; set => id = value; }
        public int Commitente { get => commitente; set => commitente = value; }
        public int Tipologia { get => tipologia; set => tipologia = value; }
        public DateTime Data { get => data; set => data = value; }
        public String DataProtocollo { get => dataProtocollo; set => dataProtocollo = value; }
        public String DataVisuraSopraluogo { get => dataVisuraSopraluogo; set => dataVisuraSopraluogo = value; }
        public double Offerta { get => offerta; set => offerta = value; }
        public string NumeroCommessa { get => numeroCommessa; set => numeroCommessa = value; }
    }
    public class Pagamento
    {
        private int id;
        private String numeroCommessa;
        private Double importo;
        private String note;
        private String fattura;
        private DateTime dataFattura;
        private DateTime data;
        private int cliente;
        private int commessa;

        public int Id { get => id; set => id = value; }
        public string NumeroCommessa { get => numeroCommessa; set => numeroCommessa = value; }
        public string Note { get => note; set => note = value; }
        public string Fattura { get => fattura; set => fattura = value; }
        public DateTime DataFattura { get => dataFattura; set => dataFattura = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public int Commessa { get => commessa; set => commessa = value; }
        public Double Importo { get => importo; set => importo = value; }
    }
    public class Lavorazioni
    {
        private int id;
        private String nome;
        private String desc;
        private String scadenze;
        private int macroLavorazione;
        private double prezzo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Scadenze { get => scadenze; set => scadenze = value; }
        public int MacroLavorazione { get => macroLavorazione; set => macroLavorazione = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
    }
}