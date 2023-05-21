using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCustomerQueryOverview
{
    public int KCustomerQueryOverview { get; set; }

    public string CName { get; set; } = null!;

    public string CQueryText { get; set; } = null!;

    public int NTyp { get; set; }

    public int NSort { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte[]? BIcon { get; set; }

    public int NBereich { get; set; }

    public int? KParent { get; set; }

    public virtual ICollection<TCustomerQueryOverviewColumn> TCustomerQueryOverviewColumns { get; set; } = new List<TCustomerQueryOverviewColumn>();

    public virtual ICollection<TCustomerQueryOverviewRecht> TCustomerQueryOverviewRechts { get; set; } = new List<TCustomerQueryOverviewRecht>();
}
