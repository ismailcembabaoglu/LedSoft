using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ObjMenu
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Shortcaption { get; set; }

    public string? Longcaption { get; set; }

    public string? Parent { get; set; }

    public string? Module { get; set; }

    public string? Keyfunction { get; set; }

    public string? Parameter { get; set; }

    public string? Value { get; set; }

    public string? Imagecode { get; set; }

    public string? Menushortcut { get; set; }

    public string? Decleration { get; set; }

    public string? Screencode { get; set; }

    public int? Ord { get; set; }

    public bool? Autostart { get; set; }

    public string? Projectcode { get; set; }

    public bool? Showdefault { get; set; }

    public bool? ShowatDesktop { get; set; }

    public bool? ShowatWeb { get; set; }

    public bool? ShowatCross { get; set; }
}
