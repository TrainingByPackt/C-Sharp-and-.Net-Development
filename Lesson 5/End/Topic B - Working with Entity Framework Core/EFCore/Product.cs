using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.CS7
{
    public class Product
    {
        public int ProductID { get; set; }
        [Display(Name = "Units In Stock")]
        public short UnitsInStock { get; set; }
        [Required]
        [StringLength(40)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Unit Price")]
        public decimal? UnitPrice { get; set; }

        // these two define the foreign key relationship
        // to the Categories table
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
