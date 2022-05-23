using UAM.API.Services.Base;
using UAM.API.Services.Registration.Models;

namespace UAM.API.Services.Registration
{
    public interface IRegistrationService : IBaseService
    {

        bool RegisterByEmailPassword(EmailPasswordRegistration model);
    }
}
