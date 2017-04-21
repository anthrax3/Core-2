using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Core.Models
{
    public class Page
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }
        public bool Deactive { get; set; }
        public string Banner { get; set; }
        public string Icon { get; set; }
        public string Content { get; set; }

        public int? PageTemplateId { get; set; }
        public virtual PageTemplate PageTemplate { get; set; }

        public int? PageDataId { get; set; }
        public virtual PageData PageData { get; set; }

        public string Data(string name) {

         
            var data = PageData?.Data.FirstOrDefault(d => d.Key.ToLower() == name.ToLower());
            return data != null ? data.Value : null;
        }

    }
}
