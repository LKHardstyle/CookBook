using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class RecipeType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public RecipeType(string name, int id = -1)
        {
            Name = name;
            if (Id != -1)
                Id = id;
        }

        public RecipeType() { }
    }
}
