using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }

        #region relationships

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        #endregion
    }
}