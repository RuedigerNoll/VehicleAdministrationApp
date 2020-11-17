using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using VehicleAdministration.Module.BusinessObjects;

namespace VehicleAdministration.Module.Controllers
{
    public partial class UpdateMaintenanceDetailsController : ViewController
    {
        public UpdateMaintenanceDetailsController()
        {
            InitializeComponent();

            TargetObjectType = typeof(MaintenanceDetail);
            TargetViewType = ViewType.DetailView;
        }

        protected override void OnActivated()
        {
            base.OnActivated();


            //var currentMd = this.View.CurrentObject as MaintenanceDetail;

            //if (currentMd?.SparePart == null)
            //    return;

            //currentMd.Costs = currentMd.SparePart.Price;
        }
    }
}
