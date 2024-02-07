using DALL.Interfase;
using Microsoft.EntityFrameworkCore;
using Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Data
{
    public class UserData:IUser
    {
        private readonly ProjectContext _context;
        public UserData(ProjectContext context)
        {
            _context = context;
        }
        public async Task<List<Users>> GetAllUser()
        {
            List<Users> users = await _context.Users.ToListAsync();
            return users;
        }
        public async Task<bool> AddUser(Users task)
        {
            await _context.Users.AddAsync(task);
            try
            {
                var isOk = _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

            }
            return true;
        }
        public async Task<bool> DeleteUser(int id)
        {
            var idUser = _context.Users.FirstOrDefault(x => x.Id == id);
            _context.Users.Remove(idUser);
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }

        public async Task<bool> UpdateUser(int id, Users user)
        {
            var idUser = _context.Users.FirstOrDefault(x => x.Id == id);
            if (idUser == null)
            {
                return false;
            }
            idUser.Email = user.Email;
            idUser.Name = user.Name;
            idUser.Address = user.Address;
            idUser.Phone = user.Phone;
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }
    }   
}
