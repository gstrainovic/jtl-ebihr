using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTextbaustein
{
    public int KTextbaustein { get; set; }

    public string CName { get; set; } = null!;

    public int KTextbausteinGruppe { get; set; }

    public int NTyp { get; set; }

    public string? CTastenkombination { get; set; }

    public string? CAutotext { get; set; }

    public virtual TTextbausteinGruppe KTextbausteinGruppeNavigation { get; set; } = null!;

    public virtual ICollection<TTextbausteinInhaltSprache> TTextbausteinInhaltSpraches { get; set; } = new List<TTextbausteinInhaltSprache>();
}
