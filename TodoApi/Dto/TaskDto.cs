﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Dto
{
    public class TaskDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
