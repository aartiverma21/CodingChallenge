using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBMiddleTier;
using FBMiddleTier.Repository;

namespace FBCommonCode
{
    public abstract class MTIntegrationBase
    {
        protected UserRepository userRepository;

        public MTIntegrationBase()
        {
            userRepository = new UserRepository();
        }
    }
}
