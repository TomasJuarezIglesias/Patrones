﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IVisitor
    {
        void Visitar(Procesador procesador);
        void Visitar(DiscoRigido discoRigido);
    }
}
