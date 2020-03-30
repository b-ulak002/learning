using DependencyInjection.DependencyInversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTests.DependencyInversion
{
    public class MockPlayerDataMapper : IPlayerDataMapper
    {
        public bool ResultToReturn { get; set; }
        void IPlayerDataMapper.InsertNewPlayerIntoDatabase(string name)
        {
            
        }

        bool IPlayerDataMapper.PlayerNameExistsInDatabase(string name)
        {
            return ResultToReturn;
        }
    }
}
