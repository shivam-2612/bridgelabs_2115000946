using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using NLog;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL:IRegisterHelloBL
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IRegisterHelloRL registerHelloRL;
        private readonly RegisterResponse registerResponse;

        public RegisterHelloBL(IRegisterHelloRL registerHelloRL)
        {
            this.registerHelloRL = registerHelloRL;
        }
        

        public string registration(string name)
        {
            _logger.Info("Registration function called with name: {0}", name);
            return "This is business layer data "+ registerHelloRL.GetHello(name);
        }

        public UserEntity LoginUser(LoginDTO loginDTO)
        {
            //string frontendUsername = loginDTO.username;
            //string frontendPassword = loginDTO.password;
            //LoginDTO result = registerHelloRL.GetUsernamePassword(loginDTO);
            //bool check=IsValidUser(frontendUsername, frontendPassword, result );

            //return check;

            _logger.Info("LoginUser function called for email: {0}", loginDTO.email);
            var user = registerHelloRL.GetUsernamePassword(loginDTO);
            bool isValid = user != null && IsValidUser(loginDTO.email, loginDTO.password, user);

            //if (user == null) return null; 
            if (!isValid)
            {
                _logger.Warn("Invalid login credentials for email: {0}", loginDTO.email);
                return null;
            }

            //bool isValid = IsValidUser(loginDTO.email, loginDTO.password, user);
            //return isValid ? user : null;
            _logger.Info("User {0} logged in successfully.", loginDTO.email);
            return user;
        }

        public bool IsValidUser(string email, string password, UserEntity user)
        {

            return user != null && email == user.Email && password == user.Password;
        }

        public UserEntity RegisterBL(RegisterDTO registerDTO)
        {
            //registerResponse = new RegisterResponse();
            _logger.Info("RegisterBL function called for email: {0}", registerDTO.Email);
            var result=registerHelloRL.registration(registerDTO);

            return result;
        }
    }
}
