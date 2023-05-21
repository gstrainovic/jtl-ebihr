using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TArtikelMehrzweckGutschein
{
    public int KArtikel { get; set; }

    public byte NIsMehrzweckGutschein { get; set; }

    public int NGutscheinTyp { get; set; }

    public int? NGutscheinVersandArt { get; set; }

    public int? KGutscheinDruckVorlage { get; set; }

    public string CIso { get; set; } = null!;

    public decimal? NBetrag { get; set; }

    public string? CKampagne { get; set; }

    public bool NHatFestenBetrag { get; set; }

    public byte NGutscheinArt { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TVorlagenset? KGutscheinDruckVorlageNavigation { get; set; }
}
