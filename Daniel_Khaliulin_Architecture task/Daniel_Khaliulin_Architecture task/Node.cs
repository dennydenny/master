﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    public abstract class Node
    {
        // Сделать set приватным???
        public String Name { get;  set; }
        public Folder Parent { get; set; }
    }
}
