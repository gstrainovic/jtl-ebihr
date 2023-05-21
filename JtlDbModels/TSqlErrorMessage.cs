using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSqlErrorMessage
{
    public int KErrorMessage { get; set; }

    public string CExceptionName { get; set; } = null!;

    public string? CErrorMessage { get; set; }

    public string CSpName { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TSqlError> TSqlErrors { get; set; } = new List<TSqlError>();
}
