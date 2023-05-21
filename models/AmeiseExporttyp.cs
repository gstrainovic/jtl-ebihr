using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class AmeiseExporttyp
{
    public int KExportTyp { get; set; }

    public int KExportTypParent { get; set; }

    public string? CName { get; set; }

    public byte NSort { get; set; }
}
