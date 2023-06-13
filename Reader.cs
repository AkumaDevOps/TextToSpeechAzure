


namespace TextToSpeechAzure
{
    internal class Reader : IReader
    {
        private readonly string filePath;
        public Reader(string filePath)
        {
            this.filePath = filePath;
        }

        public async Task<string> Read()
        {
            if(!File.Exists(filePath))
            {
                return "";
            }
            var text = await File.ReadAllTextAsync(filePath,encoding:System.Text.Encoding.UTF8);
            return text;
        }
    }
}
