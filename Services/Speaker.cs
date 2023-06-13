using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeechAzure
{
    internal class Speaker : ISpeaker
    {
        private SpeechConfig _SpeechConfig;
        private AudioConfig _AudioConfig;
        public SpeechConfig SpeechConfig
        {
            get { return _SpeechConfig; }
        }
        public AudioConfig AudioConfig
        {
            get { return _AudioConfig; }
        }

        public Speaker(SpeechConfig config, AudioConfig audioConfig)
        {
            _SpeechConfig = config;
            _AudioConfig = audioConfig;
        }
        public async Task Speak(string text)
        {
            using var synthesizer = new SpeechSynthesizer(_SpeechConfig, AudioConfig.FromDefaultSpeakerOutput());
            using var result = await synthesizer.SpeakTextAsync(text);
            Console.WriteLine(result.Reason);
        }
    }
}
