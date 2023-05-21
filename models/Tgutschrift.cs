using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Tgutschrift
{
    public int KGutschrift { get; set; }

    public int? KRechnung { get; set; }

    public int? KKunde { get; set; }

    public string? CGutschriftNr { get; set; }

    public string? CKurzText { get; set; }

    public string? CText { get; set; }

    public decimal FPreis { get; set; }

    public decimal FMwSt { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CErloeskonto { get; set; }

    public byte? NErweitert { get; set; }

    public string? CWaehrung { get; set; }

    public decimal FFaktor { get; set; }

    public int? KFirma { get; set; }

    public int? KSprache { get; set; }

    public int? KBenutzer { get; set; }

    public string? CStatus { get; set; }

    public int? KRechnungsAdresse { get; set; }

    public int? KPlattform { get; set; }

    public string CVersandlandWaehrung { get; set; } = null!;

    public decimal FVersandlandWaehrungFaktor { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public DateTime? DMaildatum { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool NStorno { get; set; }

    public byte NStornoTyp { get; set; }

    public byte NIstExtern { get; set; }

    public string? CKundeUstId { get; set; }

    public byte NGutschriftStatus { get; set; }

    public virtual ICollection<TGutschriftStorno> TGutschriftStornos { get; set; } = new List<TGutschriftStorno>();

    public virtual ICollection<TRechnungKorrektur> TRechnungKorrekturs { get; set; } = new List<TRechnungKorrektur>();

    public virtual ICollection<TRechnungStorno> TRechnungStornos { get; set; } = new List<TRechnungStorno>();
}
