using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleAdministration.Module.BusinessObjects
{
    [ImageName("BO_FileAttachment")]
    public class MaintenanceDetailsFileData : FileAttachment
    {
        public MaintenanceDetailsFileData()
            :base()
        {
            DocumentType = DocumentType.Unknown;
        }

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [NotMapped]
        public DocumentType DocumentType { get; }
    }
}
