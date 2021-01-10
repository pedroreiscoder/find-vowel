using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace FindVowel.Tests
{
    [TestClass]
    public class FindVowelTest
    {
        [TestMethod]
        public void DeveriaRetornarFirstChar1()
        {
            string data = "aAbBABacfe";
            FindVowelReader findVowelReader = new FindVowelReader(new MemoryStream(Encoding.UTF8.GetBytes(data)));

            char? firstChar = FindVowel.FirstChar(findVowelReader);

            Assert.AreEqual('e', firstChar);
        }

        [TestMethod]
        public void DeveriaRetornarFirstChar2()
        {
            string data = "eBduFGtabGUe";
            FindVowelReader findVowelReader = new FindVowelReader(new MemoryStream(Encoding.UTF8.GetBytes(data)));

            char? firstChar = FindVowel.FirstChar(findVowelReader);

            Assert.AreEqual('a', firstChar);
        }

        [TestMethod]
        public void DeveriaRetornarNulo()
        {
            string data = "bCaEjKiaLmi";
            FindVowelReader findVowelReader = new FindVowelReader(new MemoryStream(Encoding.UTF8.GetBytes(data)));

            char? firstChar = FindVowel.FirstChar(findVowelReader);

            Assert.IsNull(firstChar);
        }
    }
}
