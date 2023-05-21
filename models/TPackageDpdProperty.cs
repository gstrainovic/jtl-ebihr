using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPackageDpdProperty
{
    public int KPackageDpdProperties { get; set; }

    public int KPackage { get; set; }

    public string CDelisId { get; set; } = null!;

    public virtual TPackage KPackageNavigation { get; set; } = null!;
}
