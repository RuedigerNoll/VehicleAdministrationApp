using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("Maintenance")]

    [NavigationItem]
    public class Maintenance
    {
        public Maintenance()
        {
            Details = new List<MaintenanceDetail>();
        }

        [Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [JsonIgnore]
        public int Id { get; set; }

        public string Name { get; set; }
        public virtual IList<MaintenanceDetail> Details { get; set; } 

        public decimal? Costs { get; set; }

        public int SpeedoMeter { get; set; }

        public DateTime? Date { get; set; }

        public string Notice { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        
    }
}
