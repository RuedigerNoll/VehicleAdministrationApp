﻿using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VehicleAdministration.Module.BusinessObjects
{
    [Table("MaintenanceTypes")]

    [NavigationItem]
    public class MaintenanceType
    {
        [Key]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        
    }

}
