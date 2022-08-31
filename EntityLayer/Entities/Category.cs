using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(30)]
        public string Name { get; set; }


        #region Relationships

        public ICollection<Product> Products { get; set; }

        #endregion
    }
}