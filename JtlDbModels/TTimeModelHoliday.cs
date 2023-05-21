using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTimeModelHoliday
{
    public int KTimeModelHoliday { get; set; }

    public int KTimeModel { get; set; }

    public DateTime DDate { get; set; }

    public bool NYearly { get; set; }

    public TimeSpan NFromTime { get; set; }

    public TimeSpan NToTime { get; set; }

    public string CName { get; set; } = null!;

    public int KTimeModelType { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TTimeModel KTimeModelNavigation { get; set; } = null!;

    public virtual TTimeModelType KTimeModelTypeNavigation { get; set; } = null!;
}
