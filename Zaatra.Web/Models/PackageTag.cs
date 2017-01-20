using System.ComponentModel.DataAnnotations.Schema;

namespace Zaatra.Models
{
    [Table("PackageTag")]
    public class PackageTag
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int TagId { get; set; }

        public Package Package { get; set; }
        public Tag Tag { get; set; }
    }
}