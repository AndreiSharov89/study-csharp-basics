// Sharov Andrei group 124/11
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    abstract class Shape
    {
        protected string name { get; set; }

        //public Shape(string name)
        //{
        //    this.name = name;
        //}

        public Shape()
        {
            this.name = "shape";
        }
        public string Name()
        { 
            return this.name;
        }

    }
}

