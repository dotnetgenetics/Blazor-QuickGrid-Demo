using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class SupplierCategory
{
    public int SupplierCategoryId { get; set; }

    public string SupplierCategoryName { get; set; } = null!;

    public int LastEditedBy { get; set; }

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
