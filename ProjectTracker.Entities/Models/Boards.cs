﻿using ProjectTracker.Entities.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Entities.Models
{
    public class Boards : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
    }
}
