﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class AmeiseImporttyp
{
    public int KImportTyp { get; set; }

    public int KImportTypParent { get; set; }

    public string? CName { get; set; }

    public byte NSort { get; set; }
}
