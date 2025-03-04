using ModelLayer.DTO;
using NLog;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL: IRegisterHelloRL
    {
        //private string databaseusername = "root";
        //private string databasepassword = "root";


        //public string _username { get; set; } = "root";
        //public string _password { get; set; } = "root";

        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly HelloAppContext _context;
        public RegisterHelloRL(HelloAppContext context)
        {
            _context = context;
        }


        public string GetHello(string name)
        {
            _logger.Info("GetHello method called with name: {0}", name);
            return name + "This is repository layer.";
        }

        public UserEntity GetUsernamePassword(LoginDTO loginDTO)
        {
            //loginDTO.username = _username;
            //loginDTO.password = _password;
            //return loginDTO;
            _logger.Info("Fetching user from database for email: {0}", loginDTO.email);
            return _context.Users.FirstOrDefault(u => u.Email == loginDTO.email);
        }

        public UserEntity registration(RegisterDTO registerDTO)
        {
            _logger.Info("Attempting to register new user: {0}", registerDTO.Email);
            var existingUser = _context.Users.FirstOrDefault(e => e.Email == registerDTO.Email);
            if (existingUser != null)
            {
                _logger.Warn("User already exists with email: {0}", registerDTO.Email);
                return null; // User already exists
            }

            var newUser = new UserEntity
            {
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                Email = registerDTO.Email,
                Password = registerDTO.Password 
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();
            _logger.Info("User registered successfully: {0}", registerDTO.Email);

            return newUser;
        }
    }
}
