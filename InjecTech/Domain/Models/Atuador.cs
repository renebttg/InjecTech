using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecTech.Domain.Models
{
    public abstract class Atuador
    {
        public abstract void acionar(double parametro);
    }
}
