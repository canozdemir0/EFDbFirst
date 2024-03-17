using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class StoraggeShipper
{
    public int KargoId { get; set; }

    public string? KargoAdi { get; set; }

    public string? KargoTel { get; set; }
}
