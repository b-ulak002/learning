using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.DependencyInversion
{
    public class Player
    {
        public string Name { get; private set; }
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }

        public Player(string name, int experiencePoints, int gold)
        {
            Name = name;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }

        public static Player CreateNewPlayer(string name, IPlayerDataMapper playerDataMapper = null)
        {
            if (playerDataMapper == null)
            {
                playerDataMapper = new PlayerDataMapper();
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("PLayer name cannot be empty");
            }

            // Throw an exception if there is already a player with this name in the database.
            if (playerDataMapper.PlayerNameExistsInDatabase(name))
            {
                throw new ArgumentException("Player name already exists.");
            }

            // Add the player to the database.
            playerDataMapper.InsertNewPlayerIntoDatabase(name);

            return new Player(name, 0, 10);
        }
    }
}
