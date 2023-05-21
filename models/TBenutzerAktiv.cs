using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TBenutzerAktiv
{
    public int KBenutzerAktiv { get; set; }

    public int? KBenutzer { get; set; }

    public int? NApplikation { get; set; }

    public DateTime? DLetzteAktion { get; set; }

    public string? CUniqueId { get; set; }

    public string? CCustom { get; set; }

    public byte? BAbmelden { get; set; }

    public string? CRechnername { get; set; }

    public int? KWarenlager { get; set; }

    public int? KMandant { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
