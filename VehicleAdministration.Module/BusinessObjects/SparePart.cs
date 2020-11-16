using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("SpareParts")]

    [NavigationItem]
    public class SparePart
    {
        [Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [JsonIgnore]
        public int Id { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual SparePartCategory Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }  
        public string PartNumber { get; set; }
    }
}
