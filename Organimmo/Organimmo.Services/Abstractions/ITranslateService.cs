using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organimmo.Services.Abstractions
{
    public interface ITranslateService
    {
        string TranslateWord(string wordToBeTranslated, string translation);
    }
}
