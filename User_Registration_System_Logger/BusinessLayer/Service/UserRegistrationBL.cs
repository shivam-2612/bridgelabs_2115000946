using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        private readonly ILogger<UserRegistrationBL> _logger;
        private readonly UserRegistrationRL _userRegistrationRL;

        public UserRegistrationBL(ILogger<UserRegistrationBL> logger, UserRegistrationRL userRegistrationRL)
        {
            _logger = logger;
            _userRegistrationRL = userRegistrationRL;
        }

        public bool RegisterUserBL(RegistrationDTO newUser)
        {
            try
            {
                return _userRegistrationRL.RegisterUserRL(newUser);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in RegisterUserBL method");
                throw;
            }
        }

        public List<RegistrationDTO> GetAllUsers()
        {
            try
            {
                return _userRegistrationRL.GetAllUsers();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetAllUsers method");
                throw;
            }
        }
    }
}
