﻿using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VPositionstypSteuerschluessel
{
    public int NPositionstyp { get; set; }

    public int KSteuersatz { get; set; }

    public int? KSteuerzone { get; set; }

    public int? KSteuerklasse { get; set; }

    public int? KSteuerschluessel { get; set; }

    public int? KSteuerschluesselIgl { get; set; }

    public int? KSteuerschluesselUstIgl { get; set; }

    public int? KSteuerschluesselReverseCharge { get; set; }
}
