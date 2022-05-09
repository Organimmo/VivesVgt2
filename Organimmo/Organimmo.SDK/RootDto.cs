using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organimmo.SDK
{
    public class RootDto
    {
        [DisplayName("Id")]
        public string id { get; set; }

        [DisplayName("Applicatienaam")]
        public string ApplicationName { get; set; }

        [DisplayName("Applicatieversie")]
        public string ApplicationVersion { get; set; }

        [DisplayName("Klant")]
        public string Customer { get; set; }

        [DisplayName("Gebruikersnaam")]
        public string Username { get; set; }

        [DisplayName("Taal")]
        public string Language { get; set; }
        public List<WindowDto> Window { get; set; }
    }
}
