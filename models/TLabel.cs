using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TLabel
{
    public int KLabel { get; set; }

    public byte NTyp { get; set; }

    public string CName { get; set; } = null!;

    public string? CColor { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TArtikelLabel> TArtikelLabels { get; set; } = new List<TArtikelLabel>();

    public virtual ICollection<TEingangskanalEmailLabel> TEingangskanalEmailLabels { get; set; } = new List<TEingangskanalEmailLabel>();

    public virtual ICollection<TLabelBenutzergruppeRechte> TLabelBenutzergruppeRechtes { get; set; } = new List<TLabelBenutzergruppeRechte>();

    public virtual ICollection<TTicketLabel> TTicketLabels { get; set; } = new List<TTicketLabel>();

    public virtual ICollection<TVaterLabelLabel> TVaterLabelLabelKLabelNavigations { get; set; } = new List<TVaterLabelLabel>();

    public virtual ICollection<TVaterLabelLabel> TVaterLabelLabelKVaterNavigations { get; set; } = new List<TVaterLabelLabel>();
}
