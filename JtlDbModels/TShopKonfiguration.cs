using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TShopKonfiguration
{
    public int KShop { get; set; }

    public byte? NImport { get; set; }

    public byte? NImportArtikelKategorien { get; set; }

    public byte? NImportBestellungenKunden { get; set; }

    public byte? NUpload { get; set; }

    public byte? NUploadArtikelKomplett { get; set; }

    public byte? NUploadArtikelPreise { get; set; }

    public byte? NUploadArtikelBestand { get; set; }

    public byte? NUploadKundendaten { get; set; }

    public byte? NUploadBilder { get; set; }

    public byte? NArtikelMergen { get; set; }

    public decimal? NMaxMb { get; set; }

    public int? NMaxBilder { get; set; }

    public int? NMaxEntities { get; set; }

    public byte? NHerstellerGefiltertSenden { get; set; }

    public byte? NImportBilder { get; set; }

    public int NMaxPull { get; set; }

    public bool NSteuerDurchWawiBerechnen { get; set; }

    public bool NKundendatenAktualisieren { get; set; }

    public bool NBilderBeiImportLoeschen { get; set; }

    public string? CVersandlandIso { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public int NMaxQuickSync { get; set; }

    public bool NVersandSteuernDurchWawiBerechnen { get; set; }
}
