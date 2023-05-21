using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOperation
{
    public int KOperation { get; set; }

    public string COperationNumber { get; set; } = null!;

    public string CName { get; set; } = null!;

    public string? CDescription { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public bool NIsInternal { get; set; }

    public DateTimeOffset DCreated { get; set; }

    public int? KBenutzerLastChanged { get; set; }

    public DateTimeOffset DLastChanged { get; set; }

    public bool NIsInactive { get; set; }

    public bool NIsCompletionMandatory { get; set; }

    public virtual ICollection<TOperationFile> TOperationFiles { get; set; } = new List<TOperationFile>();

    public virtual ICollection<TOperationLabel> TOperationLabels { get; set; } = new List<TOperationLabel>();

    public virtual ICollection<TOperationStep> TOperationSteps { get; set; } = new List<TOperationStep>();

    public virtual ICollection<TWorkJobOperation> TWorkJobOperations { get; set; } = new List<TWorkJobOperation>();
}
