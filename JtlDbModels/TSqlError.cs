using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSqlError
{
    public int KSqlError { get; set; }

    public int KErrorMessage { get; set; }

    public string? CErrorData { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TSqlErrorMessage KErrorMessageNavigation { get; set; } = null!;
}
