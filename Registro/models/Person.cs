using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro.models
{
    public struct Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
