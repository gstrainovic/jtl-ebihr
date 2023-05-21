using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TIduUploadQueue
{
    public int KIduUploadQueue { get; set; }

    public int KBeleg { get; set; }

    public byte NBelegtyp { get; set; }

    public string COrderId { get; set; } = null!;

    public string CBelegnummer { get; set; } = null!;

    public int KUser { get; set; }

    public int NAusgabeVersuche { get; set; }

    public int NUploadVersuche { get; set; }

    public byte NStatus { get; set; }

    public DateTime DErstelltUtc { get; set; }

    public DateTime DBelegdatum { get; set; }

    public DateTime? DAusgabeGestartetUtc { get; set; }

    public DateTime? DAusgabeBeendetUtc { get; set; }

    public DateTime? DUploadErfolgtUtc { get; set; }

    public string? CMeldung { get; set; }

    public string? CBezugsbelegnummer { get; set; }
}
