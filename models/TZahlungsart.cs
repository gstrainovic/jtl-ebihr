using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TZahlungsart
{
    public int KZahlungsart { get; set; }

    public string? CName { get; set; }

    public string? CPrtString { get; set; }

    public byte? NLastschrift { get; set; }

    public string? CPrtStringVor { get; set; }

    public string? CPaymentOption { get; set; }

    public string? CKonto { get; set; }

    public byte? NAusliefernVorZahlung { get; set; }

    public byte NPrioritaet { get; set; }

    public byte NMahnwesenAktiv { get; set; }

    public decimal? FSkontoWert { get; set; }

    public int? NSkontoZeitraum { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NMatchingOptionen { get; set; }

    public bool NIstStandard { get; set; }

    public bool? NAktiv { get; set; }

    public virtual ICollection<TVoucherEinloesungen> TVoucherEinloesungens { get; set; } = new List<TVoucherEinloesungen>();

    public virtual ICollection<TVoucher> TVouchers { get; set; } = new List<TVoucher>();
}
