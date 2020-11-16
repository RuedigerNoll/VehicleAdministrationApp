using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("Maintenances")]
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

        public decimal Costs { get; set; }

        public int SpeedoMeter { get; set; }

        public DateTime? Date { get; set; }

        public string Notice { get; set; }
        [JsonIgnore]
        public virtual Vehicle Vehicle { get; set; }

    }

    [DomainLogic(typeof(Maintenance))]
    public class MaintenanceLogic
    {

        public decimal Get_Costs(Maintenance instance)
        {
            if (instance.Details?.Count > 0)
                return Convert.ToDecimal(instance.Details.Sum(d => d.Costs));

            return 0;
        }

        public void AfterConstruction(Maintenance instance)
        {
            if (instance == null)
                return;

        }
    }
}
