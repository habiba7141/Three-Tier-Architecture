using DataAcessLayer.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.CRUDoperations
{
    public class User : IUser
    {
        private readonly ApplicationDbContext _context;
        public User(ApplicationDbContext context)
        {
            _context = context;
        }
        public void add(Registeration user)
        {
            _context.Registerations.Add(user); 
            _context.SaveChanges();

        }
    }
}
