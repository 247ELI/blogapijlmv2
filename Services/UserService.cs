using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogapijlmv2.Models.DTO;
using blogapijlmv2.Services.Context;
using Microsoft.EntityFrameworkCore;

namespace blogapijlmv2.Services;

public class UserService 
{
private readonly DataContext _context;

public UserService(DataContext context)
{
    _context = context;
}
    internal bool AddUser(CreateAccountDTO userToAdd)
    {
        throw new NotImplementedException();
    }
}
