using System.IO;

namespace FindVowel
{
    public class FindVowelReader : StreamReader
    {
        public FindVowelReader(Stream stream) : base(stream)
        {
        }

        public char GetNext() => (char)Read();

        public bool HasNext() => !EndOfStream;
    }
}
