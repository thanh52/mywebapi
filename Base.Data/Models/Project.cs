using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Data.Models
{
    [Table("Projects")]
    public class Project: BaseDescClass
    {
        public Guid Id { get; set; }
        public short SortOrder { get; set; }
        public int SaleType { get; set; }
        public Guid CustomerId { get; set; }
        public int Status { get; set; }
        public string ProductTags { get; set; }
        public Guid AttachmentId { get; set; }
        public int CustomerType { get; set; }
        public bool IsMidTerm { get; set; }
        public string Note { get; set; }
        public int YOI { get; set; }
        public int QOI { get; set; }
        public Guid? ParentId { get; set; }
    }
}
