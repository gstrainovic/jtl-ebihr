﻿using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Tkunde
{
    public int KKunde { get; set; }

    public int? KInetKunde { get; set; }

    public int? KKundenKategorie { get; set; }

    public string? CKundenNr { get; set; }

    public DateTime? DErstellt { get; set; }

    public decimal FRabatt { get; set; }

    public string? CNewsletter { get; set; }

    public string? CEbayName { get; set; }

    public int? KBuyer { get; set; }

    public string? CGeburtstag { get; set; }

    public string? CWww { get; set; }

    public string? CSperre { get; set; }

    public int? KKundenGruppe { get; set; }

    public int? NZahlungsziel { get; set; }

    public int? KSprache { get; set; }

    public string? CHerkunft { get; set; }

    public string? CKassenKunde { get; set; }

    public string? CHrnr { get; set; }

    public int? KZahlungsart { get; set; }

    public int? NDebitorennr { get; set; }

    public string? CSteuerNr { get; set; }

    public int? NKreditlimit { get; set; }

    public int? KKundenDrucktext { get; set; }

    public byte NMahnstopp { get; set; }

    public int NMahnrhythmus { get; set; }

    public byte KFirma { get; set; }

    public decimal? FProvision { get; set; }

    public byte NVertreter { get; set; }

    public decimal FSkonto { get; set; }

    public int NSkontoInTagen { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TAuftragAdresse> TAuftragAdresses { get; set; } = new List<TAuftragAdresse>();

    public virtual ICollection<TAuftrag> TAuftrags { get; set; } = new List<TAuftrag>();

    public virtual ICollection<TExterneRechnung> TExterneRechnungs { get; set; } = new List<TExterneRechnung>();

    public virtual ICollection<TShippingMethodMapping> TShippingMethodMappings { get; set; } = new List<TShippingMethodMapping>();

    public virtual ICollection<TTicket> TTickets { get; set; } = new List<TTicket>();
}
