using NUnit.Framework;
using ProjetPourTU.Model;
using ProjetPourTU.Services;
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
        public void CreerMessagePourUnVehicule()
        {
            // création de données
            Vehicule v = new Vehicule();
            v.ID =1;
            v.Nom = "Peugeot 308";
            v.Immatriculation = "AAA";
            
            _testV.AddVehicule(v);


            v = new Vehicule();
            v.ID = 2;
            v.Nom = "Toyota Aygo";
            v.Immatriculation = "BBB";

            _testV.AddVehicule(v);
            v = new Vehicule();
            v.ID = 3;
            v.Nom = "CCC";
            v.Immatriculation = "Renault Clio";

            _testV.AddVehicule(v);

            string message = _testV.CreerMessagePourUnVehicule();
            string expected = "ID : 2, Nom :Toyota Aygo ,Immatriculation : BBB";
            Assert.AreEqual(expected, message);

        }
        [Test]
        public void AddVehiculeTest()
        {
            // création de données

            _testV.AddVehicule(null);
            // créer message va lever une erreur (c'est normal)
            // il faut vous assurer que CreerMessage lève bien l'erreur
            try
            {
                string message = _testV.CreerMessage();
                Assert.Fail("Creer message aurait du planter");
            }
            catch (Exception e)
            {
                e = null;
                Assert.Pass();
            }
        }

    }
}
