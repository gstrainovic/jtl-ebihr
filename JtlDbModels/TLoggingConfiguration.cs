using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TLoggingConfiguration
{
    public byte KLogsitzungTyp { get; set; }

    public DateTime DLogDateEnd { get; set; }

    public bool NDisableLogging { get; set; }
}
