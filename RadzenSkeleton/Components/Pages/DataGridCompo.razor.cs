using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using RadzenSkeleton.Components.Models;

namespace RadzenSkeleton.Components.Pages
{
    public partial class DataGridCompo
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        public ValueModel[] CouponTrays { get; set; }
        public ValueModel[] VialTrays { get; set; }

        public DataGridCompo()
        {
            CouponTrays = new ValueModel[10];
            for (int i = 0; i < CouponTrays.Length; i++) {
                CouponTrays[i] = new ValueModel(i);
            }
            VialTrays = new ValueModel[15];
            for (int i = 0; i < VialTrays.Length; i++) {
                VialTrays[i] = new ValueModel(i);
            }
        }
    }
}
