using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using TextToSpeechAzure.Services;

const string speechKey = "d8bbf512f59847f79e72e006f8741510";
const string speechRegion = "westeurope";
const string voiceName = "es-MX-CarlotaNeural";
const string readFilePath = @"C:\Users\d.mozota\Desktop\PruebaLectura.txt";
SpeechConfig speechConfig = SpeechConfig.FromSubscription(speechKey, speechRegion);
AudioConfig audioConfig = AudioConfig.FromDefaultSpeakerOutput();
speechConfig.SpeechSynthesisVoiceName = voiceName;
Speaker speaker = new(speechConfig, audioConfig);
Reader reader = new(readFilePath);
ReaderSpeaker readerSpeaker = new(reader, speaker);
await readerSpeaker.Read();