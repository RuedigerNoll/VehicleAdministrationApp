using DevExpress.ExpressApp.Data;
using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("MaintenanceDetail")]
    public class MaintenanceDetail
    {
        [Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        public int Id { get; set; }
        public MaintenanceType MaintenanceType { get; set; }

        public decimal? Costs { get; set; }
    }
}
