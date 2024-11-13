using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Busetti_cassaforte
{
    internal class Cassaforte
    {
        private const string codiceSegreto = "abcdef123456";
        private string codiceSegretoSblocco;
        private const int numTentativi = 5;
        private const string codiceUtente = "abcde";
        private string codiceSblocco;
        private string modello;
        private int tentativiSbagliati;
        private string produttore;
        private bool statoSblocco;


        public string CodiceSegreto
        {
            get { return codiceSegreto; }
        }

        public string CodiceUtente
        {
            get { return codiceUtente; }
        }

        public string Modello
        {
            get { return modello; }
        }

        public int TentativiSbagliati
        {
            get { return tentativiSbagliati; }
            set { tentativiSbagliati = value; }
        }

        public string Produttore
        {
            get { return produttore; }
        }

        public string CodiceSblocco
        {
            get { return codiceSblocco; }
            set {  codiceSblocco = value; }
        }

        public string CodiceSegretoSblocco
        {
            get { return codiceSegretoSblocco; }
            set { codiceSegretoSblocco = value; }
        }

        public int NumTentativi
        {
            get { return numTentativi; }
        }

        public void apriCassa(string codiceUtente)
        {
            for(int i = 0; i < numTentativi; i++)
                if(numTentativi < i)
                {
                    if (codiceSblocco == codiceUtente)
                    {
                        statoSblocco = true;
                    }
                    else if (codiceSblocco != codiceUtente)
                        {
                             statoSblocco = false;
                        }
                }
             else { statoSblocco = false; }    
        }

        public void bloccaCassa(string tentativiSbagliati)
        {
            
        }

        public void chiudiCassa()
        {
            statoSblocco = false;
        }

        public void sbloccaCassa()
        {
            if (codiceSegreto == codiceSegretoSblocco)
            {
                statoSblocco = true;
            }
            else { statoSblocco = false; }
        }

        
        public Cassaforte(string codiceSblocco, string modello, int tentativiSbagliati, string produttore, bool statoSblocco, string codiceSegretoSblocco)
        {
            this.modello = modello;
            this.codiceSblocco = codiceSblocco;
            this.tentativiSbagliati = tentativiSbagliati;
            this.produttore = produttore;
            this.statoSblocco = statoSblocco;
            this.codiceSegretoSblocco = codiceSegretoSblocco;
        }


    }
}
