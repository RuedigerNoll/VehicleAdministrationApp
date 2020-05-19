using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("Vehicles")]
    [NavigationItem]
    public class Vehicle
    {
        public Vehicle()
        {
            Maintenances = new List<Maintenance>();
            Refuellings = new List<Refuelling>();
        }

        [Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }

        public DateTime? YearOfConstruction { get; set; }

        public string Brand{ get; set; }

        public string Model { get; set; }

        public string Motor { get; set; }

        public string Power { get; set; }

        public string LicencePlate { get; set; }

        public string WheelSizeRear { get; set; }
        public string WheelSizeFront { get; set; }

        public int TareWeight { get; set; }
        public string Notice { get; set; }
        public virtual IList<Maintenance> Maintenances { get; set; }

        public virtual IList<Refuelling> Refuellings { get; set; }

    }
}
