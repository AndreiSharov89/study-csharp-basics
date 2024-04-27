using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal interface IRotate
    {
        protected bool IfRotated { get; set; }

        void Rotate();
    }
}
