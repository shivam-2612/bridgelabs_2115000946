using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessLayer.Service;
using ModelLayer.DTO;
using System;
using System.Collections.Generic;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _userRegistrationBL;
        private readonly ILogger<UserRegistrationController> _logger;

        public UserRegistrationController(UserRegistrationBL userRegistrationBL, ILogger<UserRegistrationController> logger)
        {
            _userRegistrationBL = userRegistrationBL;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok("Welcome to User Registration Portal!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Get method");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] RegistrationDTO newUser)
        {
            try
            {
                var response = new ResponseModel<RegistrationDTO>();
                bool isRegistered = _userRegistrationBL.RegisterUserBL(newUser);

                if (isRegistered)
                {
                    response.Success = true;
                    response.Message = $"User registered successfully! with email: {newUser.email}";
                    response.Data = newUser;
                    return Ok(response);
                }

                response.Success = false;
                response.Message = "User registration failed!";
                return BadRequest(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in RegisterUser method");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            try
            {
                var response = new ResponseModel<List<RegistrationDTO>>();
                List<RegistrationDTO> users = _userRegistrationBL.GetAllUsers();

                response.Success = true;
                response.Message = "User list fetched successfully!";
                response.Data = users;

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetUsers method");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
