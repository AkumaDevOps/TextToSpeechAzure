using Microsoft.CognitiveServices.Speech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeechAzure
{
    internal class ReaderSpeaker
    {
        private readonly IReader _reader;
        private readonly ISpeaker _speaker;

        public ReaderSpeaker(IReader reader, ISpeaker speaker)
        {
            _reader = reader;
            _speaker = speaker;
        }

        public async Task Read()
        {
            var text = await _reader.Read();
            await _speaker.Speak(text);
        }
        public async void Read(string text)
        {
            await _speaker.Speak(text);
        }

    }
}
