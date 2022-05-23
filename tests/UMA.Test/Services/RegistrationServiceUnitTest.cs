using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAM.API.Services.Registration;
using UAM.API.Services.Registration.Models;

namespace UMA.Test.Services
{
    public class RegistrationServiceUnitTest
    {

        private IRegistrationService RegistrationService;

        #region Helpers

        private IRegistrationService CreateRestrationService()
        {
            // Mock ILogger<RegistrationService>
            var mockLoggerRegistrationService = new Mock<ILogger<RegistrationService>>();



            return new RegistrationService(mockLoggerRegistrationService.Object);
        }

        private EmailPasswordRegistration GetFakeEmailAndPasswordRegistration()
        {
            return new EmailPasswordRegistration()
            {
                Email = "luke.skywalker@jediorder.com",
                Password = "MayThe4ceBWithU",
                PasswordConfirmation = "MayThe4ceBWithU"
            };
        }


        #endregion

        [SetUp]
        public void SetUp()
        {
            RegistrationService = CreateRestrationService();
        }

        [TearDown]
        public void TearDown() { }


        [Test]
        public void ReistrationServiceInitializationTest()
        {
            IRegistrationService registrationService = null;

            registrationService = CreateRestrationService();

            registrationService.Should().NotBeNull();
            registrationService.Should().BeOfType<RegistrationService>();
        }

        [Test]
        public void RegisterByEmailPasswordTest()
        {
            var epRegistration = GetFakeEmailAndPasswordRegistration();

            var isReqistered = RegistrationService.RegisterByEmailPassword(epRegistration);
        }


    }
}
