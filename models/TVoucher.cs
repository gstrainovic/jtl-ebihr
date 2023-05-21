using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVoucher
{
    public int KVouchers { get; set; }

    public string? CName { get; set; }

    public int? KZahlungsart { get; set; }

    public int? KArtikelGutschein { get; set; }

    public bool NMonatsuebergreifend { get; set; }

    public int NApiTyp { get; set; }

    public virtual TArtikel? KArtikelGutscheinNavigation { get; set; }

    public virtual TZahlungsart? KZahlungsartNavigation { get; set; }

    public virtual TVouchersToken? TVouchersToken { get; set; }
}
