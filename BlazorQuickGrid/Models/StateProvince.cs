using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class StateProvince
{
    public int StateProvinceId { get; set; }

    public string StateProvinceCode { get; set; } = null!;

    public string StateProvinceName { get; set; } = null!;

    public int CountryId { get; set; }

    public string SalesTerritory { get; set; } = null!;

    public long? LatestRecordedPopulation { get; set; }

    public int LastEditedBy { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country Country { get; set; } = null!;

    public virtual Person LastEditedByNavigation { get; set; } = null!;
}
