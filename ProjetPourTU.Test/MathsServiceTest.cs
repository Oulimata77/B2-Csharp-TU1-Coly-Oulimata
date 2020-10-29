using NUnit.Framework;
using ProjetPourTU.Services;

namespace ProjetPourTU.Test
{
    public class MathsServiceTest
    {
        MathsService _sv;
        [SetUp]
        public void Setup()
        {
            _sv= new MathsService();
        }

        [Test]
        public void Test1Mulitiplier()
        {
            var result = _sv.add(2, 1 );
            // vérification
            Assert.AreEqual(3, result,
            "L'addition de 2*1 +1 ne retourne pas 3 comme prévu");
            Assert.Pass();
        }
    }
}