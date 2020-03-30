using System;
using DependencyInjection.DependencyInversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DependencyInjectionTests.DependencyInversion
{
    [TestClass]
    public class PlayerTestsUsingMoq
    {
        // Should receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            Mock<IPlayerDataMapper> mock = new Mock<IPlayerDataMapper>();
            Player player = Player.CreateNewPlayer("", mock.Object);
        }

        // Should still receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            Mock<IPlayerDataMapper> mock = new Mock<IPlayerDataMapper>();
            mock.Setup(x => x.PlayerNameExistsInDatabase(It.IsAny<string>())).Returns(true);
            Player player = Player.CreateNewPlayer("Test", mock.Object);
        }

        [TestMethod]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase()
        {
            Mock<IPlayerDataMapper> mock = new Mock<IPlayerDataMapper>();
            mock.Setup(x => x.PlayerNameExistsInDatabase(It.IsAny<string>())).Returns(false);
            Player player = Player.CreateNewPlayer("Test", mock.Object);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(10, player.Gold);
        }
    }
}
