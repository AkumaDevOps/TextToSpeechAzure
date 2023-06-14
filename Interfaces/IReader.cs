using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeechAzure.Interfaces
{
    internal interface IReader
    {
        public Task<string> Read();
    }
}
