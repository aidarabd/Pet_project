using DBAccess.Models.Base;

namespace DBAccess.Models
{
    public class Ingredient : BaseEntity
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }
}
