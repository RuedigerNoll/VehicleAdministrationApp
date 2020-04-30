using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("Refuelling")]

    [NavigationItem]
    public class Refuelling
    {
        [Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        public int Id { get; set; }
        public FuelType FuelType { get; set; }
        public decimal Costs { get; set; }
        public decimal PricePerLitre { get; set; }

        public decimal Litres { get; set; }

        public int SpeedoMeter { get; set; }

        public DateTime Date { get; set; }

        public bool FullRefuelling { get; set; }

        public string Notice { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
