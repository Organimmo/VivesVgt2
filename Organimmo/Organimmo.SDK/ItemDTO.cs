using System.ComponentModel;

namespace Organimmo.SDK
{
    public class ItemDto 
    {   
        [DisplayName("Type")]
        public string Type { get; set; }

        [DisplayName("Naam")]
        public string Name { get; set; }

        [DisplayName("BasisTekst")]
        public string BaseText { get; set; }

        [DisplayName("Huidige Tekst")]
        public string CurrentText { get; set; }
    }
}