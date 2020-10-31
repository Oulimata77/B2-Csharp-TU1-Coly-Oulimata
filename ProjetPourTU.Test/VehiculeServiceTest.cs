using NUnit.Framework;
using ProjetPourTU.Model;
using ProjetPourTU.Services;
using ProjetPourTU.Services.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPourTU.Test
{
    class VehiculeServiceTest
    {
        VehiculeService _testV;
        [SetUp]
        public void Setup()
        {
            _testV = new VehiculeService();
        }
        [Test]
        public void CreerMessageAvecDonneesTest()
        {
            // création de données
           
            string message = _testV.CreerMessage();
            string expected = "Véhicule : Peugeot 308, immatriculation : AAA\nVéhicule : Toyota Aygo, immatriculation : BBB\nVéhicule : Renault Clio, immatriculation : CCC";
       
            Assert.AreEqual(expected, message);

        }
        [Test]
        public void GetByIDFailTest()
        {
            // création de données

           
            try
            {
                _testV.getByID(-1);
                Assert.Fail("le message aurait du planter");
            }
            catch (InvalidIDException e)
            {
               
            }catch(NullReferenceException e)
            {

            }
        }

    }
}
