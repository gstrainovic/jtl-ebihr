using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VLieferschein
{
    public int KLieferschein { get; set; }

    public int KBestellung { get; set; }

    public int? KLieferantenBestellung { get; set; }

    public int KBenutzer { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string CBestellNr { get; set; } = null!;

    public int KFirma { get; set; }

    public int? KVersandart { get; set; }

    public int KKunde { get; set; }

    public string? CKundenNr { get; set; }

    public int? KLieferadresse { get; set; }

    public int KSprache { get; set; }

    public string? CHinweis { get; set; }

    public DateTime? DMailVersand { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DGedruckt { get; set; }

    public int? NFulfillment { get; set; }

    public string? CLieferadresseKundenNr { get; set; }

    public string? CLieferadresseTitel { get; set; }

    public string? CLieferadresseAnrede { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public string? CLieferadresseNachname { get; set; }

    public string? CLieferadresseZusatz { get; set; }

    public string? CLieferadresseAdressZusatz { get; set; }

    public string? CLieferadresseStrasse { get; set; }

    public string? CLieferadressePlz { get; set; }

    public string? CLieferadresseOrt { get; set; }

    public string? CLieferadresseBundesland { get; set; }

    public string? CLieferadresseLand { get; set; }

    public string? CLieferadresseLandIso { get; set; }

    public string? CLieferadresseMail { get; set; }

    public string? CLieferadresseTelefon { get; set; }

    public string? CLieferadresseFax { get; set; }

    public string? CLieferadresseMobil { get; set; }

    public int? KSessionId { get; set; }

    public string? CFirmaName { get; set; }

    public string? CFirmaStrasse { get; set; }

    public string? CFirmaPlz { get; set; }

    public string? CFirmaOrt { get; set; }

    public string CFirmaLandIso { get; set; } = null!;

    public string? CFirmaTelefon { get; set; }

    public string? CFirmaFax { get; set; }

    public string? CFirmaMail { get; set; }

    public int NIstVersendet { get; set; }

    public byte NKomplettAusgeliefert { get; set; }
}
