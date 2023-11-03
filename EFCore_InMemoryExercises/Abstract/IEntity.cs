﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_InMemoryExercises.Abstract
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
