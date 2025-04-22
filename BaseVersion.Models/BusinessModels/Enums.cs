using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseVersion.Models.BusinessModels
{
    public enum EnumAction
    {
        Create,
        Update,
        Delete
    }

    public enum EnumStatus
    {
        Created,
        Updated,
        Deleted,
        Approved,
        Rejected,
        PendingForApproval
    }
}
