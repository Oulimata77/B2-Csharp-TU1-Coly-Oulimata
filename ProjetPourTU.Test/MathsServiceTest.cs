using NUnit.Framework;
using ProjetPourTU.Services;
using System;

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
        [TestCase(6, 3, 2)]
        [TestCase(0, 3, 0)]

        [Test]
        public void MultiTest(int excepted,int num1,int num2) {


            decimal result = _sv.Multiplier(num1, num2);
            Assert.AreEqual(excepted, result, "le resultat est faux");

        }

    }
}