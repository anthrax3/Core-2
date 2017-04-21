using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
   public class PageTemplate
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DataTemplate> DataTemplates { get; set; }
        
    }
}
