using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("FuelTypes")]

    [NavigationItem]
    public class FuelType
    {
        [Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
