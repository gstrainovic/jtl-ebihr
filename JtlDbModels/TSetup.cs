using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSetup
{
    public int KMandant { get; set; }

    public byte NAbgleichstyp { get; set; }

    public int KZiel { get; set; }

    public int NIntervall { get; set; }

    public int? NRequestStatus { get; set; }
}
