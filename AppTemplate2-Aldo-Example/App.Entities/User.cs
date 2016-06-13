using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
   public class User
    {

       //atributos de la tabla Users
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
       //crea una lista donde almacena las direcciones.
        public ICollection<Address> Addresses { get; set; }

    }
}
