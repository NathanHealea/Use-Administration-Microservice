using System;
using Microsoft.Extensions.Logging;
using UAM.API.Services.Base;
using UAM.API.Services.Registration.Models;

namespace UAM.API.Services.Registration
{
    public class RegistrationService : BaseService<RegistrationService>, IRegistrationService
    {
        public RegistrationService(ILogger<RegistrationService> logger) : base( logger) { }


        public bool RegisterByEmailPassword(EmailPasswordRegistration model)
        {
            throw new NotImplementedException();
        }
    }
}
