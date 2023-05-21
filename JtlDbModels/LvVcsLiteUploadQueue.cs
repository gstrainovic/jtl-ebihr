using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvVcsLiteUploadQueue
{
    public int KVcsLiteUploadQueue { get; set; }

    public int KExternerBeleg { get; set; }

    public string CBelegnummer { get; set; } = null!;

    public string COrderId { get; set; } = null!;

    public string CShippingId { get; set; } = null!;

    public string CTransactionId { get; set; } = null!;

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

    public DateTime? DLetzteStatusAenderung { get; set; }
}
