using Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Interfase
{
    public interface Ipost
    {
        Task<List<Post>> GetAllPost();
        Task<bool> DeletePost(int id);
        Task<bool> UpdatePost(int id, Post todo);
        Task<bool> AddPost(Post task);
    }
}
