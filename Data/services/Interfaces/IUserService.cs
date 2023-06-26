using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VETAPP.ViewModels.Models;

namespace VETAPP.Data.services.Interfaces
{
    public interface IUserService
    {

        Task<List<User>> GetAllUsersList();
    }
}
