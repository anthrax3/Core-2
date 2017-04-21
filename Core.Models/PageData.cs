using System.Collections.Generic;

namespace Core.Models
{
    public class PageData 
    {
        public int Id { get; set; }
        public virtual ICollection<Data> Data { get; set; }
        
    }
}