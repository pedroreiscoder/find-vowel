using System.IO;

namespace FindVowel
{
    /// <summary>
    /// StreamReader customizado para oferecer os métodos GetNext() e HasNext()
    /// </summary>
    public class FindVowelReader : StreamReader
    {
        public FindVowelReader(Stream stream) : base(stream)
        {
        }

        public char GetNext() => (char)Read();

        public bool HasNext() => !EndOfStream;
    }
}
