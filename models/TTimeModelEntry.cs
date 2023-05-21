using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TTimeModelEntry
{
    public int KTimeModelEntry { get; set; }

    public int KTimeModel { get; set; }

    public byte NWeekDay { get; set; }

    public TimeSpan NFromTime { get; set; }

    public TimeSpan NToTime { get; set; }

    public int KTimeModelType { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TTimeModel KTimeModelNavigation { get; set; } = null!;

    public virtual TTimeModelType KTimeModelTypeNavigation { get; set; } = null!;
}
