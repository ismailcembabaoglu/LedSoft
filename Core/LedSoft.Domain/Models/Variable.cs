using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Variable
{
    public int Id { get; set; }

    public string? Variablecode { get; set; }

    public string? Value { get; set; }
}
