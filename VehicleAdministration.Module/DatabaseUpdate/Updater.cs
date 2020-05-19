using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using VehicleAdministration.Module.BusinessObjects;

namespace VehicleAdministration.Module.DatabaseUpdate
{
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    public class Updater : ModuleUpdater
    {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion)
        {
        }
        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();

            PermissionPolicyUser sampleUser = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "User"));
            if (sampleUser == null)
            {
                sampleUser = ObjectSpace.CreateObject<PermissionPolicyUser>();
                sampleUser.UserName = "User";
                sampleUser.SetPassword("");
            }
            PermissionPolicyRole defaultRole = CreateDefaultRole();
            sampleUser.Roles.Add(defaultRole);

            PermissionPolicyUser userAdmin = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "Admin"));
            if (userAdmin == null)
            {
                userAdmin = ObjectSpace.CreateObject<PermissionPolicyUser>();
                userAdmin.UserName = "Admin";
                // Set a password if the standard authentication type is used
                userAdmin.SetPassword("");
            }
            // If a role with the Administrators name doesn't exist in the database, create this role
            PermissionPolicyRole adminRole = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Administrators"));
            if (adminRole == null)
            {
                adminRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
                adminRole.Name = "Administrators";
            }
            adminRole.IsAdministrative = true;
            userAdmin.Roles.Add(adminRole);

            CreateConfigurations<MaintenanceType>(ObjectSpace, @"DatabaseUpdate\MaintenanceTypes.json");
            CreateConfigurations<SparePartCategory>(ObjectSpace, @"DatabaseUpdate\SparePartCategories.json");
            CreateConfigurations<Manufacturer>(ObjectSpace, @"DatabaseUpdate\Manufactures.json");
            CreateVehicles(ObjectSpace, @"DatabaseUpdate\Vehicles.json");            

            ObjectSpace.CommitChanges();
        }

        private void CreateConfigurations<T>(IObjectSpace objectSpace, string jsonFileName)
        {
            var filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), jsonFileName);
            var json = File.ReadAllText(filePath);

            var listOfConfigurations = JsonSerializer.Deserialize<IList<T>>(json);

            foreach (var item in listOfConfigurations)
            {
                var itemValue = item.GetType().GetProperty("Name").GetValue(item);
                if (itemValue == null)
                    continue;

                var result = objectSpace.FindObject<T>(
                    CriteriaOperator.Parse("Name = ?", itemValue as string));
                if (result != null)
                    continue;

                var configuration = objectSpace.CreateObject<T>();
                configuration.GetType().GetProperty("Name").SetValue(configuration, itemValue, null);
            }
        }

        private void CreateVehicles(IObjectSpace objectSpace, string jsonFileName)
        {
            var filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), jsonFileName);
            var json = File.ReadAllText(filePath);

            var listOfConfigurations = JsonSerializer.Deserialize<IList<Vehicle>>(json);

            foreach (var item in listOfConfigurations)
            {
                var result = objectSpace.FindObject<Vehicle>(CriteriaOperator.Parse("Name = ?", item.Name));
                if (result != null)
                    continue;

                var configuration = objectSpace.CreateObject<Vehicle>();
                configuration.Name = item.Name;
                configuration.Brand = item.Brand;
                configuration.IdentificationNumber = item.IdentificationNumber;
                configuration.LicencePlate = item.LicencePlate;
                configuration.Model = item.Model;
                configuration.Motor = item.Motor;
                configuration.Notice = item.Notice;
                configuration.Power = item.Power;
                configuration.TareWeight = item.TareWeight;
                configuration.WheelSizeFront = item.WheelSizeFront;
                configuration.WheelSizeRear = item.WheelSizeRear;
                configuration.YearOfConstruction = item.YearOfConstruction;
            }
        }

        public override void UpdateDatabaseBeforeUpdateSchema()
        {
            base.UpdateDatabaseBeforeUpdateSchema();
        }
        private PermissionPolicyRole CreateDefaultRole()
        {
            PermissionPolicyRole defaultRole = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "Default"));
            if (defaultRole == null)
            {
                defaultRole = ObjectSpace.CreateObject<PermissionPolicyRole>();
                defaultRole.Name = "Default";

                defaultRole.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.Read, "[ID] = CurrentUserId()", SecurityPermissionState.Allow);
                defaultRole.AddNavigationPermission(@"Application/NavigationItems/Items/Default/Items/MyDetails", SecurityPermissionState.Allow);
                defaultRole.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "ChangePasswordOnFirstLogon", "[ID] = CurrentUserId()", SecurityPermissionState.Allow);
                defaultRole.AddMemberPermission<PermissionPolicyUser>(SecurityOperations.Write, "StoredPassword", "[ID] = CurrentUserId()", SecurityPermissionState.Allow);
                defaultRole.AddTypePermissionsRecursively<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Deny);
                defaultRole.AddTypePermissionsRecursively<ModelDifference>(SecurityOperations.ReadWriteAccess, SecurityPermissionState.Allow);
                defaultRole.AddTypePermissionsRecursively<ModelDifferenceAspect>(SecurityOperations.ReadWriteAccess, SecurityPermissionState.Allow);
                defaultRole.AddTypePermissionsRecursively<ModelDifference>(SecurityOperations.Create, SecurityPermissionState.Allow);
                defaultRole.AddTypePermissionsRecursively<ModelDifferenceAspect>(SecurityOperations.Create, SecurityPermissionState.Allow);
            }
            return defaultRole;
        }
    }
}
