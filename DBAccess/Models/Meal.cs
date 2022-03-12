using DBAccess.Models.Base;

namespace DBAccess.Models
{
    public class Meal : BaseEntity
    {
        
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
