using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TState
{
    public int KState { get; set; }

    public int KPackage { get; set; }

    public int? KStateServer { get; set; }

    public byte NStateType { get; set; }

    public DateTime? DDate { get; set; }

    public string CText { get; set; } = null!;

    public string? CProviderState { get; set; }

    public string CLocation { get; set; } = null!;

    public string CCountry { get; set; } = null!;

    public virtual TPackage KPackageNavigation { get; set; } = null!;
}
