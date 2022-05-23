using Microsoft.Extensions.Logging;

namespace UAM.API.Services.Base
{
    public class BaseService<T> : IBaseService
    {

        internal readonly ILogger<T> Logger;

        public BaseService(ILogger<T> logger) {

            Logger = logger;
        }
    }
}
