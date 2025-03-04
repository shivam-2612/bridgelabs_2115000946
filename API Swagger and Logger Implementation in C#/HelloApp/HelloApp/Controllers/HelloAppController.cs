using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using NLog;
using RepositoryLayer.Entity;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {

        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IRegisterHelloBL _registerHelloBL;
        ResponseModel<string> response;


        public HelloAppController(IRegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
        }

    

        [HttpGet]
        public string Get()
        {
            _logger.Info("Get() method called.");
            return _registerHelloBL.registration("Value from controller");
        }

        [HttpPost("login")]
        public IActionResult PostData(LoginDTO loginDTO)
        {

            

            try
            {
                //response = new ResponseModel<string>();
                _logger.Info("Login attempt for user: {0}", loginDTO.email);
                var user= _registerHelloBL.LoginUser(loginDTO);
                //    if (user==null)
                //    {
                //        response.Success = false;
                //        response.Message = "Invalid username or password.";
                //        return Unauthorized(response);
                //    }
                //    response.Success = true;
                //    response.Message = "Login Successfull.";
                //    response.Data = " ";
                //    return Ok(response);



                //}
                //catch (Exception ex)
                //{

                //    response.Success = false;
                //    response.Message = "Login failed.";
                //    response.Data = ex.Message;
                //    return BadRequest();
                //}

                if (user == null)
                {
                    _logger.Warn("Invalid login attempt for user: {0}", loginDTO.email);
                    return Unauthorized(new { Success = false, Message = "Invalid username or password." });
                }

                _logger.Info("User {0} logged in successfully.", loginDTO.email);
                return Ok(new { Success = true, Message = "Login Successful." });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Login failed.");
                return BadRequest(new { Success = false, Message = "Login failed.", Error = ex.Message });
            }



        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO registerDTO) {

            //ResponseModel<RegisterResponse> response = new ResponseModel<RegisterResponse>();
            //var newUser = _registerHelloBL.RegisterBL(registerDTO);
            //if (newUser == null)
            //{
            //    response.Success = false;
            //    response.Message = "User with this email already exists.";
            //    return Conflict(response);
            //}


            //var registerResponse = new RegisterResponse
            //{
            //    FirstName = newUser.FirstName,
            //    LastName = newUser.LastName,
            //    Email = newUser.Email
            //};

            //response.Success = true;
            //response.Message = "User registered successfully.";
            //response.Data = registerResponse;

            //return Created("user registered", response);
            _logger.Info("Register attempt for email: {0}", registerDTO.Email);
            var newUser = _registerHelloBL.RegisterBL(registerDTO);

            if (newUser == null)
            {
                _logger.Warn("Registration failed. Email already exists: {0}", registerDTO.Email);
                return Conflict(new { Success = false, Message = "User with this email already exists." });
            }

            _logger.Info("User registered successfully: {0}", registerDTO.Email);
            return Created("user registered", new { Success = true, Message = "User registered successfully." });

        }
    }
}
