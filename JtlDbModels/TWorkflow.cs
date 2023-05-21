using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TWorkflow
{
    public int KWorkflow { get; set; }

    public string CName { get; set; } = null!;

    public int NEvent { get; set; }

    public int NObjekt { get; set; }

    public int NVerknuepfung { get; set; }

    public int NPos { get; set; }

    public int NTyp { get; set; }

    public int NApplikation { get; set; }

    public long? NSchedulerOptions { get; set; }

    public DateTime? DtSchedulerTime { get; set; }

    public int? NSchedulerHour { get; set; }

    public int? NSchedulerMinute { get; set; }

    public int? NSchedulerDayValue { get; set; }

    public int? NSchedulerMonthValue { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
