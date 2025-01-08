using MudBlazor;

namespace NamozVaqtlari.Themes;

public class Theme
{
    public static MudTheme SpacesTheme()
    {
        var theme = new MudTheme()
        {
            PaletteLight = SpacesLightPalette,
            PaletteDark = SpacesDarkPalette,
            LayoutProperties = new LayoutProperties()
        };
        return theme;
    }

    private static readonly PaletteLight SpacesLightPalette = new()
    {
        Black = "#42313a", // Темный цвет
        AppbarText = "#6c2d2c", // Цвет текста в AppBar
        AppbarBackground = "#9f4636", // Фон AppBar
        DrawerBackground = "#f1dcc9", // Фон Drawer
        GrayLight = "#f1dcc9", // Легкий серый (заменен на новый цвет)
        GrayLighter = "#f1dcc9", // Более светлый серый (заменен на новый цвет)
    };


    private static readonly PaletteDark SpacesDarkPalette = new()
    {
        Primary = "#7e6fff",
        Surface = "#1e1e2d",
        Background = "#1a1a27",
        BackgroundGray = "#151521",
        AppbarText = "#92929f",
        AppbarBackground = "rgba(26,26,39,0.8)",
        DrawerBackground = "#1a1a27",
        ActionDefault = "#74718e",
        ActionDisabled = "#9999994d",
        ActionDisabledBackground = "#605f6d4d",
        TextPrimary = "#b2b0bf",
        TextSecondary = "#92929f",
        TextDisabled = "#ffffff33",
        DrawerIcon = "#92929f",
        DrawerText = "#92929f",
        GrayLight = "#2a2833",
        GrayLighter = "#1e1e2d",
        Info = "#4a86ff",
        Success = "#3dcb6c",
        Warning = "#ffb545",
        Error = "#ff3f5f",
        LinesDefault = "#33323e",
        TableLines = "#33323e",
        Divider = "#292838",
        OverlayLight = "#1e1e2d80",
    };
}