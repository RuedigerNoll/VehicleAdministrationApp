using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using System.Text.Json;
using System.Linq;
using VehicleAdministration.Module.BusinessObjects;

namespace VehicleAdministration.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class Export2JsonViewController : ViewController
    {
        public Export2JsonViewController()
        {
            InitializeComponent();
            TargetViewType = ViewType.ListView;
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            if (e.SelectedObjects == null || e.SelectedObjects.Count == 0)
                return;

            var exportType = e.SelectedObjects[0]?.GetType();
            if (exportType == null)
                return;

            var x = this.View.ObjectTypeInfo;
            var list = e.SelectedObjects.OfType<Maintenance>().ToList();
            var result = JsonSerializer.Serialize<System.Collections.Generic.IList<Maintenance>>(list);
            System.IO.File.WriteAllText($"C:\\Temp\\{exportType.Name}", result);
        }
    }
}
