using System.ComponentModel.DataAnnotations.Schema;

namespace TimerStore.Models
{
    public class Product
    {
        public long ProductID { get; set; }

        public string Name { get; set; }

        public string ProductImg { get; set; }

        public string Description { get; set; }

        public bool Favourite { get; set; }

        public string Gender { get; set; }

        public string MechanismType { get; set; }

        public string CaseMaterial { get; set; }

        public string wristletType { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        public double Discount { get; set; }

        public string Category { get; set; }

        public string BrandName { get; set; }

        public int totalCount { get; set; }

    }
}
