using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VRechnung1
{
    public int KRechnung { get; set; }

    public int? KBenutzer { get; set; }

    public int? KKunde { get; set; }

    public string CRechnungsnr { get; set; } = null!;

    public DateTime DErstellt { get; set; }

    public DateTime DValutadatum { get; set; }

    public string? CKundennr { get; set; }

    public string? CKundengruppe { get; set; }

    public int? KKundengruppe { get; set; }

    public string CFirma { get; set; } = null!;

    public int? KFirmaHistory { get; set; }

    public int? NZahlungszielTage { get; set; }

    public decimal FSkonto { get; set; }

    public int NSkontoInTage { get; set; }

    public bool NMahnstop { get; set; }

    public bool NStatus { get; set; }

    public string? CVersandlandIso { get; set; }

    public string? CVersandlandBundeslandkuerzel { get; set; }

    public string CVersandlandWaehrung { get; set; } = null!;

    public decimal FVersandlandWaehrungsfaktor { get; set; }

    public string CWaehrung { get; set; } = null!;

    public decimal FWaehrungsfaktor { get; set; }

    public int? KZahlungsart { get; set; }

    public string? CZahlungsart { get; set; }

    public int? KSprache { get; set; }

    public int? KFarbe { get; set; }

    public int NSteuereinstellung { get; set; }

    public string? CUstId { get; set; }

    public byte NIstExterneRechnung { get; set; }

    public bool NExistierendeRechnungDrucken { get; set; }

    public bool NArchiv { get; set; }

    public string? CVersandart { get; set; }

    public DateTime? DLeistungsdatum { get; set; }

    public byte NRechnungStatus { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int? KPlattform { get; set; }

    public string? CExterneAuftragsnummer { get; set; }

    public int? KVersandArt { get; set; }

    public bool NIstEntwurf { get; set; }

    public bool NStorno { get; set; }

    public string? CKundeUstId { get; set; }

    public int? KShop { get; set; }

    public string? CEbayUsername { get; set; }

    public int? NDebitorennr { get; set; }
}
