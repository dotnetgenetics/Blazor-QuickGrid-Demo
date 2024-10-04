using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class City
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public int StateProvinceId { get; set; }

    public long? LatestRecordedPopulation { get; set; }

    public int LastEditedBy { get; set; }

    public virtual ICollection<Customer> CustomerDeliveryCities { get; set; } = new List<Customer>();

    public virtual ICollection<Customer> CustomerPostalCities { get; set; } = new List<Customer>();

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual StateProvince StateProvince { get; set; } = null!;

    public virtual ICollection<Supplier> SupplierDeliveryCities { get; set; } = new List<Supplier>();

    public virtual ICollection<Supplier> SupplierPostalCities { get; set; } = new List<Supplier>();

    public virtual ICollection<SystemParameter> SystemParameterDeliveryCities { get; set; } = new List<SystemParameter>();

    public virtual ICollection<SystemParameter> SystemParameterPostalCities { get; set; } = new List<SystemParameter>();
}
