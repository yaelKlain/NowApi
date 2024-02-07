using Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Interfase
{
    public interface IUser
    {
        Task<List<Users>> GetAllUser();
        Task<bool> DeleteUser(int id);
        Task<bool> UpdateUser(int id, Users todo);
        Task<bool> AddUser(Users task);
    }
}
