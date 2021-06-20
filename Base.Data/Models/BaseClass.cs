using System;

namespace Base.Data.Models
{
    public class BaseClass
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class BaseDescClass: BaseClass
    {
        public string Title { get; set; }
        //public string Description { get; set; }
    }
}
