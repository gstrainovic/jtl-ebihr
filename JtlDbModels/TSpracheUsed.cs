using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TSpracheUsed
{
    public int KSprache { get; set; }

    public string? CNameEng { get; set; }

    public string? CNameDeu { get; set; }

    public string? CIso { get; set; }

    public byte? NStandard { get; set; }

    public string? CKultur { get; set; }

    public string CIso2 { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TAuftrag> TAuftrags { get; set; } = new List<TAuftrag>();

    public virtual ICollection<TTextbausteinInhaltSprache> TTextbausteinInhaltSpraches { get; set; } = new List<TTextbausteinInhaltSprache>();
}
