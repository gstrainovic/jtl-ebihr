using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAuftragEckdaten
{
    public int KAuftrag { get; set; }

    public DateTime? DLetzterVersand { get; set; }

    public DateTime? DGedruckt { get; set; }

    public DateTime? DGemailt { get; set; }

    public DateTime? DVersandMail { get; set; }

    public DateTime? DZahlungsMail { get; set; }

    public decimal FWertNetto { get; set; }

    public decimal FWertBrutto { get; set; }

    public decimal FZahlung { get; set; }

    public decimal FGutschrift { get; set; }

    public bool NIstNachnahme { get; set; }

    public DateTime? DBezahlt { get; set; }

    public bool NIstKomplettRetourniert { get; set; }

    public byte NRechnungStatus { get; set; }

    public byte NZahlungStatus { get; set; }

    public int NAnzahlPakete { get; set; }

    public decimal FWertRechnungNetto { get; set; }

    public decimal FWertRechnungBrutto { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int NAnzahlVersendetePakete { get; set; }

    public byte NIstFuerAuslieferungGesperrt { get; set; }

    public string? CRechnungsnummern { get; set; }

    public decimal FOffenerWert { get; set; }

    public decimal FOffenerWertOhneStorno { get; set; }

    public virtual TAuftrag KAuftragNavigation { get; set; } = null!;
}
