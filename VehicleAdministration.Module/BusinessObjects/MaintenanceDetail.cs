using DevExpress.ExpressApp.Data;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("MaintenanceDetails")]
    public class MaintenanceDetail
    {
        [DevExpress.Xpo.Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [JsonIgnore]
        public int Id { get; set; }
        
        public virtual MaintenanceType MaintenanceType { get; set; }
        
        public virtual SparePart SparePart { get; set; }

        [PersistentAlias("SparePart.Price")]
        public decimal? Costs { get; set; }

    }
}
