using DependencyInjectionTests.DependencyInversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DependencyInjection.DependencyInversion.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            Player player = Player.CreateNewPlayer("");
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();
            mockPlayerDataMapper.ResultToReturn = true;
            Player player = Player.CreateNewPlayer("Test", mockPlayerDataMapper);       
        }

        [TestMethod]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();
            mockPlayerDataMapper.ResultToReturn = false;

            Player player = Player.CreateNewPlayer("Test", mockPlayerDataMapper);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(10, player.Gold);
        }
    }
}