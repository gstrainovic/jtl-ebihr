using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAntwortkanal
{
    public int KAntwortkanal { get; set; }

    public string CAdresse { get; set; } = null!;

    public DateTime DErstellung { get; set; }

    public DateTime? DDeaktivierung { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NTyp { get; set; }

    public virtual ICollection<TErreichbarkeit> TErreichbarkeits { get; set; } = new List<TErreichbarkeit>();

    public virtual ICollection<TNachrichtEntwurfTyp> TNachrichtEntwurfTyps { get; set; } = new List<TNachrichtEntwurfTyp>();

    public virtual ICollection<TNachrichtTyp> TNachrichtTyps { get; set; } = new List<TNachrichtTyp>();
}
