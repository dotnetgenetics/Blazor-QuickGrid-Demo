using BlazorQuickGrid.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.EntityFrameworkCore;

namespace BlazorQuickGrid.Components.Pages
{
    public partial class Home
    {
        [Inject]
        IDbContextFactory<WideWorldImportersContext>? contextFactory { get; set; }

        private PaginationState pagination = new PaginationState { ItemsPerPage = 10 };
        private string Title = "Wide World Importers - Customers";
        private IQueryable<Customer>? itemsQueryable;
        private string nameFilter = string.Empty;

        private IQueryable<Customer>? FilteredCustomers
        {
            get
            {
                IQueryable<Customer>? Customers = itemsQueryable;

                if (!string.IsNullOrEmpty(nameFilter))
                    Customers = itemsQueryable?.Where(c => c.CustomerName.Contains(nameFilter, StringComparison.CurrentCultureIgnoreCase));

                if (Customers != null)
                    return Customers.AsQueryable();

                return null;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            var context = contextFactory.CreateDbContext();
            var customers = await context.Customers
                        .Include(x => x.CustomerCategory)
                        .Include(y => y.DeliveryCity)
                        .Include(z => z.PrimaryContactPerson)
                        .ToListAsync();

            itemsQueryable = customers.AsQueryable();
        }
    }
}
