using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVertrauenswuerdigerAbsender
{
    public int KVertrauenswuerdigerAbsender { get; set; }

    public string CAbsender { get; set; } = null!;

    public byte NAbsenderTyp { get; set; }

    public int KBenutzerErsteller { get; set; }

    public DateTime DErstelldatum { get; set; }
}
