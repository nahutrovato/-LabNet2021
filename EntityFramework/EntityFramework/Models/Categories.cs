using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EntityFramework.Models
{
    public class Categories
    {

        [Key]
        public int CategoryID{ get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

    }
}
