using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VUstIdKorrektur
{
    public int KAuftrag { get; set; }

    public string CAuftragsnummer { get; set; } = null!;

    public DateTime DAuftragsdatum { get; set; }

    public string? CVersandland { get; set; }

    public string? CVersandlandIso { get; set; }

    public string? CLieferland { get; set; }

    public string? CLieferlandIso { get; set; }

    public string? CRechnungsland { get; set; }

    public string? CRechnungslandIso { get; set; }

    public string? CKundeUstId { get; set; }

    public int NRechnungVorhanden { get; set; }

    public int NRechnungskorrekturVorhanden { get; set; }

    public string? CIstUmsatzsteueridentnummer { get; set; }

    public string? CSollUmsatzsteueridentnummer { get; set; }
}
