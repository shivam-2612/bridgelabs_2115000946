using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
using System;
using System.Collections.Generic;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL
    {
        private readonly ILogger<UserRegistrationRL> _logger;
        private readonly List<RegistrationDTO> _users; // Simulated database

        public UserRegistrationRL(ILogger<UserRegistrationRL> logger)
        {
            _logger = logger;
            _users = new List<RegistrationDTO>();
        }

        public bool RegisterUserRL(RegistrationDTO newUser)
        {
            try
            {
                _users.Add(newUser);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in RegisterUserRL method");
                return false;
            }
        }

        public List<RegistrationDTO> GetAllUsers()
        {
            try
            {
                return _users;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetAllUsers method");
                throw;
            }
        }
    }
}
