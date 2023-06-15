using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using TextToSpeechAzure.Services;

const string speechKey = "";
const string speechRegion = "";
const string voiceName = "es-MX-CarlotaNeural";
const string readFilePath = @"C:\File.txt";
SpeechConfig speechConfig = SpeechConfig.FromSubscription(speechKey, speechRegion);
AudioConfig audioConfig = AudioConfig.FromDefaultSpeakerOutput();
speechConfig.SpeechSynthesisVoiceName = voiceName;
Speaker speaker = new(speechConfig, audioConfig);
Reader reader = new(readFilePath);
ReaderSpeaker readerSpeaker = new(reader, speaker);
await readerSpeaker.Read();