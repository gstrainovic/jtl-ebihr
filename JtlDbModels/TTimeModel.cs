using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TTimeModel
{
    public int KTimeModel { get; set; }

    public string CName { get; set; } = null!;

    public DateTimeOffset DCreated { get; set; }

    public DateTimeOffset DLastModified { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TResource> TResources { get; set; } = new List<TResource>();

    public virtual ICollection<TTimeModelEntry> TTimeModelEntries { get; set; } = new List<TTimeModelEntry>();

    public virtual ICollection<TTimeModelHoliday> TTimeModelHolidays { get; set; } = new List<TTimeModelHoliday>();

    public virtual ICollection<TTimeModelReplacement> TTimeModelReplacementKTimeModelNavigations { get; set; } = new List<TTimeModelReplacement>();

    public virtual ICollection<TTimeModelReplacement> TTimeModelReplacementKTimeModelReplacedNavigations { get; set; } = new List<TTimeModelReplacement>();
}
