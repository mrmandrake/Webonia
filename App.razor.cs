using Avalonia.Web.Blazor;

namespace Webonia;

public partial class App
{
    protected override void OnParametersSet()
    {
        WebAppBuilder.Configure<Webonia.Lib.App>()
            .SetupWithSingleViewLifetime();

        base.OnParametersSet();
    }
}
