﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TPicklisteVorlageBoxen
{
    public int KPicklisteVorlageBoxen { get; set; }

    public int KPicklisteVorlage { get; set; }

    public int KLhm { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
