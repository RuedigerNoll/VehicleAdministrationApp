using DevExpress.ExpressApp.Data;
using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("MaintenanceDetail")]
    public class MaintenanceDetail
    {
        [Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [JsonIgnore]
        public int Id { get; set; }
        
        public virtual MaintenanceType MaintenanceType { get; set; }

        public virtual SparePart SparePart { get; set; }

        public decimal? Costs { get; set; }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        public virtual Maintenance Maintenance { get; set; }
    }
}
