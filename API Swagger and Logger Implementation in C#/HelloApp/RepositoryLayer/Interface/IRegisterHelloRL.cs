﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Interface
{
    public interface IRegisterHelloRL
    {
        public string GetHello(string name);
                
        public UserEntity GetUsernamePassword(LoginDTO loginDTO);

        UserEntity registration(RegisterDTO registerDTO);

    }
}
