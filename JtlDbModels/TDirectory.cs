using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TDirectory
{
    public int KDirectory { get; set; }

    public int? KParentDirectory { get; set; }

    public string CName { get; set; } = null!;

    public int NSort { get; set; }

    public int KBenutzer { get; set; }

    public DateTime DCreated { get; set; }

    public int NType { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual ICollection<TDirectory> InverseKParentDirectoryNavigation { get; set; } = new List<TDirectory>();

    public virtual TDirectory? KParentDirectoryNavigation { get; set; }

    public virtual ICollection<TScript> TScripts { get; set; } = new List<TScript>();
}
