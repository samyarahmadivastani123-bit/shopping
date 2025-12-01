using domin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin
{
    public class Prouduct
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Price { get; set; }
        public float Invoice { get; set; }

        public List<ProductComment>? prdcmt { get; set; }
        public List<ProductImage>? images { get; set; }
        //....................................................
        [ForeignKey("Cat")]
        public int CategoryId { get; set; }
        public Category Cat { get; set; }
    }
}
