using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organimmo.SDK
{
    public class WindowDto 
    {
        [DisplayName("Naam")]
        public string Name { get; set; }

        [DisplayName("Titel")]
        public string Title { get; set; }
        public List<ItemDto> Items { get; set; }
    }
}
