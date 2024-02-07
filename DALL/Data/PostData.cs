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
    public class PostData: Ipost
    {

        private readonly ProjectContext _context;

        public PostData(ProjectContext context)
        {
            _context = context;
        }
        public async Task<List<Post>> GetAllPost()
        {

            List<Post> posts = await _context.Post.ToListAsync();
            return posts;
        }
        public async Task<bool> AddPost(Post post)
        {
            await _context.Post.AddAsync(post);
            try
            {
                var isOk = _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

            }

            return true;
        }

        public async Task<bool> DeletePost(int id)
        {
            var idPost = _context.Post.FirstOrDefault(x => x.Id == id);
            _context.Post.Remove(idPost);
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }

        public async Task<bool> UpdatePost(int id, Post post)
        {
            var idPost = _context.Post.FirstOrDefault(x => x.Id == id);
            if (idPost == null)
            {
                return false;
            }
            
            idPost.Conntect = post.Conntect;
            idPost.Like = post.Like;
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }
    }
}
