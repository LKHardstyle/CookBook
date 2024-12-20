﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessLayer.CustomQueryResults
{
    public class RecipeWithType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }   
        public byte[] Image { get; set; }
        public string Type { get; set; }
        public int RecipeTypeId { get; set; }
    }
}
