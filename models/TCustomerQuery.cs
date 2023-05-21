using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TCustomerQuery
{
    public int KCustomerQuery { get; set; }

    public string CName { get; set; } = null!;

    public string CQueryText { get; set; } = null!;

    public int KKontext { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TCustomerQueryRecht> TCustomerQueryRechts { get; set; } = new List<TCustomerQueryRecht>();

    public virtual ICollection<TCustomerQueryUser> TCustomerQueryUsers { get; set; } = new List<TCustomerQueryUser>();
}
