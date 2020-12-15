using System;
using System.Collections.Generic;
using System.Text;

namespace GaspareEbayProgramm
{
    public class ebayModel
    {
        public string Name { get; set; }

        public List<string> ImagePaths { get; set; }

        public string Price { get; set; }

        public string eBayArtikelnummer { get; set; }

        public string Kategorie { get; set; }

        public string Versand { get; set; }

        public string Marke { get; set; }

        public string Produkt { get; set; }

        public string Ablaufdatum { get; set; }

        public string  ArtikelBeschreibung { get; set; }
    }
}
