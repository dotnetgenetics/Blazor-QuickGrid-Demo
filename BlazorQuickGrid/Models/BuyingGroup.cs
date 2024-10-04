using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class BuyingGroup
{
    public int BuyingGroupId { get; set; }

    public string BuyingGroupName { get; set; } = null!;

    public int LastEditedBy { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<SpecialDeal> SpecialDeals { get; set; } = new List<SpecialDeal>();
}
