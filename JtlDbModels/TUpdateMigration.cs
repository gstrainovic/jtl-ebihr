using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TUpdateMigration
{
    public string? CVersion { get; set; }

    public byte[] BHash { get; set; } = null!;

    public string? CObjectname { get; set; }

    public string? CError { get; set; }

    public string CSqlId { get; set; } = null!;

    public int KUpdateMigration { get; set; }
}
