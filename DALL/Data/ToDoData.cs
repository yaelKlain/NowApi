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
    public class ToDoData: IToDo
    {
                
            private readonly ProjectContext _context;

            public ToDoData(ProjectContext context)
            {
                _context = context;
            }
            public async Task<List<ToDo>> GetAllToDo()
            {

                List<ToDo> todos = await _context.ToDo.ToListAsync();
                return todos;
            }
            public async Task<bool> AddToDo(ToDo task)
            {                
                await _context.ToDo.AddAsync(task);
            try
            {
                var isOk = _context.SaveChanges() > 0;
            }
            catch(Exception ex) 
            {

            }
                
                return true;
            }

            public async Task<bool> DeleteToDo(int id)
            {
                var idTodo = _context.ToDo.FirstOrDefault(x => x.Id == id);
                _context.ToDo.Remove(idTodo);
                var isOk = _context.SaveChanges() >=0;
                return isOk;
            }

            public async Task<bool> UpdateToDo(int id, ToDo todo)
            {
                var idTodo = _context.ToDo.FirstOrDefault(x => x.Id == id);
                if (idTodo == null)
                {
                    return false;
                }
                idTodo.Name = todo.Name;
                idTodo.createDate = todo.createDate;
                idTodo.completed = todo.completed;
                var isOk = _context.SaveChanges() >= 0;
                return isOk;
            }

        //public async Task<bool> UpdateToDo(int id, ToDo todo)
        //{
        //    var idTodo = _context.ToDo.FirstOrDefault(x => x.Id == id);
        //    if (idTodo == null)
        //    {
        //        return false;
        //    }
        //    idTodo.Name = todo.Name;
        //    idTodo.createDate = todo.createDate;
        //    idTodo.completed = todo.completed;
        //    var isOk = _context.SaveChanges() >= 0;
        //    return isOk;
        //}


    }
    }





