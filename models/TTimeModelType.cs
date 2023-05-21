using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTimeModelType
{
    public int KTimeModelType { get; set; }

    public string CName { get; set; } = null!;

    public bool NAvailable { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TTimeModelEntry> TTimeModelEntries { get; set; } = new List<TTimeModelEntry>();

    public virtual ICollection<TTimeModelHoliday> TTimeModelHolidays { get; set; } = new List<TTimeModelHoliday>();
}
