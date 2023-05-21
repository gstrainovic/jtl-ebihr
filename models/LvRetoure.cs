using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvRetoure
{
    public int KRmretoure { get; set; }

    public int KRmstatus { get; set; }

    public int KFirma { get; set; }

    public int? KBestellung { get; set; }

    public int? KBestellungUmtausch { get; set; }

    public int? KGutschrift { get; set; }

    public string? CFirma { get; set; }

    public byte NHerkunft { get; set; }

    public string? Warenlager { get; set; }

    public int KWarenlager { get; set; }

    public string? CBenutzer { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string? CBestellNr { get; set; }

    public string? CRechnungsNr { get; set; }

    public string? ExterneAuftragsnummer { get; set; }

    public int? FAnzahlLieferschein { get; set; }

    public int? AnzahlBestellungen { get; set; }

    public string CRetoureNr { get; set; } = null!;

    public string? CAnsprechpartner { get; set; }

    public DateTime DErstellt { get; set; }

    public string? CKommentarExtern { get; set; }

    public string? CKommentarIntern { get; set; }

    public string? CFfnReturnId { get; set; }

    public string? CExternalNumber { get; set; }

    public string? CKundeFirma { get; set; }

    public string? CAnrede { get; set; }

    public string? CTitel { get; set; }

    public string? CVorname { get; set; }

    public string? CName { get; set; }

    public string? CStrasse { get; set; }

    public string? CPlz { get; set; }

    public string? COrt { get; set; }

    public string? CLand { get; set; }

    public string? CTel { get; set; }

    public string? CZusatz { get; set; }

    public string? CAdressZusatz { get; set; }

    public string? CPostId { get; set; }

    public string? CMobil { get; set; }

    public string? CMail { get; set; }

    public string? CFax { get; set; }

    public string? CBundesland { get; set; }

    public string? CIso { get; set; }

    public string? AbholadresseCFirma { get; set; }

    public string? AbholadresseCAnrede { get; set; }

    public string? AbholadresseCTitel { get; set; }

    public string? AbholadresseCVorname { get; set; }

    public string? AbholadresseCName { get; set; }

    public string? AbholadresseCStrasse { get; set; }

    public string? AbholadresseCPlz { get; set; }

    public string? AbholadresseCOrt { get; set; }

    public string? AbholadresseCLand { get; set; }

    public string? AbholadresseCTel { get; set; }

    public string? AbholadresseCZusatz { get; set; }

    public string? AbholadresseCAdressZusatz { get; set; }

    public string? AbholadresseCPostId { get; set; }

    public string? AbholadresseCMobil { get; set; }

    public string? AbholadresseCMail { get; set; }

    public string? AbholadresseCFax { get; set; }

    public string? AbholadresseCBundesland { get; set; }

    public string? AbholadresseCIso { get; set; }

    public string CStatus { get; set; } = null!;

    public string? CGutschriftNr { get; set; }

    public string? CTrackingId { get; set; }

    public string? EbayUsername { get; set; }

    public string? CKundenNr { get; set; }

    public bool? IsFfnCustomer { get; set; }

    public string? CReturnId { get; set; }
}
