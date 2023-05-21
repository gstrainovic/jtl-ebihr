using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMessage1
{
    public int KMessage { get; set; }

    public int KPackage { get; set; }

    public int? KMessageServer { get; set; }

    public string CCode { get; set; } = null!;

    public byte NStatus { get; set; }

    public DateTime DTimestamp { get; set; }

    public byte NSource { get; set; }

    public string CContent { get; set; } = null!;

    public string CContentShort { get; set; } = null!;

    public virtual TPackage KPackageNavigation { get; set; } = null!;
}
