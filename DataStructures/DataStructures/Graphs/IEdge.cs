﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    internal interface IEdge<E>
    {
        E Edge { get; }
    }
}