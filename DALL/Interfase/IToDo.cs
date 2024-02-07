using Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Interfase
{
    public interface IToDo
    {

        Task<List<ToDo>> GetAllToDo();
        
        Task<bool> DeleteToDo(int id);
        Task<bool> UpdateToDo(int id, ToDo todo);
        Task<bool> AddToDo(ToDo task);
    }
}
