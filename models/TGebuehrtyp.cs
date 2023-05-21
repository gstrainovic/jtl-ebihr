using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TGebuehrtyp
{
    public int KGebuehrtyp { get; set; }

    public string CName { get; set; } = null!;

    public string CNameExtern { get; set; } = null!;

    public int NTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
