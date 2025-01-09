using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
namespace NamozVaqtlari.Layout;

public partial class MainLayout : LayoutComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    private bool isDarkMode = true;

    private void Telegram()
    {
        var url ="https://t.me/Akbarkhan_0805";
        JSRuntime.InvokeVoidAsync("open", url, "_blank");
    }
    // [Inject] NavigationManager Navigation { get; set; } = default!;
    // private bool _isRegion = false;
    // protected override void OnInitialized()
    // {
    //     UpdateSwitchStateBasedOnUrl();

        // UpdateCurrentDate();

        // Timer timer = new Timer(state =>
        // {
        //     InvokeAsync(() =>
        //     {
        //         UpdateCurrentDate();
        //         StateHasChanged();
        //     });
        // }, null, TimeSpan.Zero, TimeSpan.FromDays(1));
    // }

    // private void NavigateToRegion()
    // {
    //     _isRegion = false;
    //     Navigation.NavigateTo("/region");
    // }

    // private void NavigateToLocation()
    // {
    //     _isRegion = true;
    //     Navigation.NavigateTo("/");
    // }

    // private void UpdateSwitchStateBasedOnUrl()
    // {
    //     var currentUrl = Navigation.Uri;

    //     if (currentUrl.EndsWith("/region"))
    //         _isRegion = false;
    //     else if (currentUrl.EndsWith("/"))
    //         _isRegion = true;
    // }

    // private string? currentDate;

    // private void UpdateCurrentDate()
    // {
    //     currentDate = DateTimeOffset.Now.ToString("dd MMM yyyy", new System.Globalization.CultureInfo("en-EN"));
    // }
}