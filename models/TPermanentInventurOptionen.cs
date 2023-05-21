using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPermanentInventurOptionen
{
    public int KWarenLager { get; set; }

    public bool NPermanentInventur { get; set; }

    public bool NPermanentInventurProzessSaKo { get; set; }

    public bool NPermanentInventurProzessRoKo { get; set; }

    public bool NPermanentInventurProzessUmlagerung { get; set; }

    public bool NPermanentInventurProzessMinusbuchung { get; set; }

    public bool NPermanentInventurDayMo { get; set; }

    public bool NPermanentInventurDayDi { get; set; }

    public bool NPermanentInventurDayMi { get; set; }

    public bool NPermanentInventurDayDo { get; set; }

    public bool NPermanentInventurDayFr { get; set; }

    public bool NPermanentInventurDaySa { get; set; }

    public bool NPermanentInventurDaySo { get; set; }

    public int NPermanentInventurProcedure { get; set; }

    public bool NPermanentInventurProcedureSkip { get; set; }

    public bool NPermanentInventurWithStock { get; set; }

    public decimal NPermanentInventurMaxQuantity { get; set; }

    public int NPermanentInventurMaxItems { get; set; }

    public int NPermanentInventurMinMonth { get; set; }

    public bool NPermanentInventurCheckList { get; set; }
}
