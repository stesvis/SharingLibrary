using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_1
{
    public class Person_1
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}