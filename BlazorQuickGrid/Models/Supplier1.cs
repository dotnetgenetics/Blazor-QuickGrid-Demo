using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class Supplier1
{
    public int SupplierId { get; set; }

    public string SupplierName { get; set; } = null!;

    public string? SupplierCategoryName { get; set; }

    public string? PrimaryContact { get; set; }

    public string? AlternateContact { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string FaxNumber { get; set; } = null!;

    public string WebsiteUrl { get; set; } = null!;

    public string? DeliveryMethod { get; set; }

    public string? CityName { get; set; }

    public string? SupplierReference { get; set; }
}
