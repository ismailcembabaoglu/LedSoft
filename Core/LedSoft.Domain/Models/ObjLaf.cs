using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjLaf
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public byte[]? Layoutxml { get; set; }

    public string? LayoutxmlHash { get; set; }

    public byte[]? Codedll { get; set; }

    public string? CodedllHash { get; set; }

    public byte[]? Codefile { get; set; }

    public bool? Locked { get; set; }

    public bool? Systemlocked { get; set; }

    public string? Contentxml { get; set; }

    public string? Propertiesxml { get; set; }

    public string? Gridsxml { get; set; }

    public byte[]? Printlayout { get; set; }

    public string? PrintlayoutHash { get; set; }

    public int? Formwidth { get; set; }

    public int? Formheight { get; set; }

    public string? Projectcode { get; set; }

    public string? Weblayout { get; set; }

    public DateTime? Createdatetime { get; set; }

    public DateTime? Modifydatetime { get; set; }

    public DateTime? Publishdatetime { get; set; }
}
