using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VGutschein
{
    public int KArtikel { get; set; }

    public int NTyp { get; set; }

    public int? NAusgabeart { get; set; }

    public int? KVorlagenset { get; set; }

    public string CIso { get; set; } = null!;

    public decimal? NBetrag { get; set; }

    public string? CKampagne { get; set; }

    public bool NHatFestenBetrag { get; set; }

    public byte NArt { get; set; }
}
