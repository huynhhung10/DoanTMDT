using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanTMDT.Shared
{
    public class Brand
    {
        public int Id { get; set; } 
        public string BrandName { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string BrandUrl { get; set; } = string.Empty;
        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;

        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;
    }
}
