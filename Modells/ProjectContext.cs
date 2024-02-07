using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modells
{
    public class ProjectContext: DbContext
    {              
            public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }
            public DbSet<ToDo> ToDo { get; set; }
            public DbSet<Post> Post { get; set; }
            public DbSet<Users> Users { get; set; }
            public DbSet<Photo> Photo { get; set; }

        }
    }

