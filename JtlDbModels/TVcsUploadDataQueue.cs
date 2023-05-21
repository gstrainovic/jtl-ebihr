using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVcsUploadDataQueue
{
    public int KVcsUploadDataQueue { get; set; }

    public int? KRechnung { get; set; }

    public int? KGutschrift { get; set; }

    public string? CShippingId { get; set; }

    public int? NVersuche { get; set; }

    public byte NTyp { get; set; }

    public int KUser { get; set; }

    public string? CTransactionId { get; set; }
}
