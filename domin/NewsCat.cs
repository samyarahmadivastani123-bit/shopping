using Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domin
{
    public class NewsCat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<News> MyNews { get; set; }
    }
}
