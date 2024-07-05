using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InStock.Models;

namespace InStock.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}