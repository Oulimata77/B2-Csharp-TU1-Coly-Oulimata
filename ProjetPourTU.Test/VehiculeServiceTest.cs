using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using ProjetPourTU.Model;
using ProjetPourTU.Services;
using ProjetPourTU.Services.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetPourTU.Test
{
    public class VehiculeServiceTest
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
                _testV.getByID(-6);
                Assert.Fail("le message aurait du planter");
            }
            catch (InvalidIDException e)
            {

                Assert.IsTrue(true);

            }
            catch (VehiculeNotFoundException e)
            {
                Assert.IsNull(true);
            }
        }
        [Test]
        public void AddVehiculeTest()
        {
            // création de données


            try
            {
                _testV.AddVehicule(null);
                Assert.Fail("le message aurait du planter");
            }
            catch (NullNotAllowedException e)
            {

                Assert.IsTrue(true);

            }
            catch (SameIDExistsException e)
            {
                Assert.IsNotNull(true);
            }
        }
        [Test]
        public void CreerMessagePourUnVehiculeTest()
        {
            // création de données

            try
            {
                _testV.CreerMessagePourUnVehicule();
                Assert.Fail("le message aurait du planter");

            }
            catch (NotImplementedException e)
            {
                Assert.IsTrue(true);
            }

        }
        
    }
}
