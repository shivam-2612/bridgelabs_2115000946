using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Entity;
using RepositoryLayer.Service;

namespace BusinessLayer.Interface
{
    public interface IRegisterHelloBL
    {
        public string registration(string name);


        UserEntity LoginUser(LoginDTO loginDTO);

        UserEntity RegisterBL(RegisterDTO registerDTO);
        
        
    }
}
