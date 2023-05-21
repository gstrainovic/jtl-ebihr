using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TPreiskalkulation
{
    public string CName { get; set; } = null!;

    public int NAb { get; set; }

    public byte? NOperator { get; set; }

    public decimal NWert { get; set; }

    public DateTime? DModifiziert { get; set; }

    public string CPlattform { get; set; } = null!;

    public byte? NPreisglaettungBis10 { get; set; }

    public byte? NPreisglaettungBis100 { get; set; }

    public byte? NPreisglaettungBis1000 { get; set; }

    public byte? NPreisglaettungBis10000 { get; set; }

    public byte? BSonderpreisAb { get; set; }

    public DateTime? DSonderpreisAb { get; set; }

    public byte? BSonderpreisBis { get; set; }

    public DateTime? DSonderpreisBis { get; set; }

    public byte? BSonderpreiLager { get; set; }

    public int? NSonderpreisLager { get; set; }

    public string? CSonderpreisPlattform { get; set; }

    public byte? NIndexPreisAlt { get; set; }

    public byte? NIndexPreisAltKundengruppe { get; set; }

    public byte? NIndexPreisAltMarktplatz { get; set; }

    public byte? NIndexPreisNeu { get; set; }

    public byte? NIndexPreisNeuKundengruppe { get; set; }

    public byte? NIndexPreisNeuMarktplatz { get; set; }

    public string? CSonderpreisKundengruppe { get; set; }

    public byte? NDelete { get; set; }

    public byte? NDeaktivate { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
