using App.Entities; //Relacion con las entidades
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL
{

    //Metodos  de insercion Se crean las consultas (Query).

    public class UserRepository
    {
        private TicketsDbContext _context;

        //constructor
        public UserRepository()
        {
            _context = new TicketsDbContext();
        }

        //Queries
        //Inserta un registro a la tabla users
        public void InsertUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

        }

        public List<User> GetAll()
        {
            return _context.Users.Include("Addresses").ToList();
        }

        public User GetByNameAndId(int id, string name)
        {
            return _context.Users.FirstOrDefault(x => x.Name == name && x.Id != id);
        }
    }
}
