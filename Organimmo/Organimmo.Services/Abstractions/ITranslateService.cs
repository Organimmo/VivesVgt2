using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organimmo.Services.Abstractions
{
    public interface ITranslateService
    {
        string TranslateGoogle(string text, string fromCulture, string toCulture);

        string Serialize(string file);

        object Deserialize(string file);
    }
}
