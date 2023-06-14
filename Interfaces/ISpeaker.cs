using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeechAzure.Interfaces
{
    internal interface ISpeaker
    {
        SpeechConfig SpeechConfig { get; }
        AudioConfig AudioConfig { get; }
        public Task Speak(string Text);
    }
}
