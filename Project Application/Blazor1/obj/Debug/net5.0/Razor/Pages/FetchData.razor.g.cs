#pragma checksum "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e362f932017c9f41f9dc7c79e736d63a840278a"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Blazor1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\_Imports.razor"
using Blazor1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
using Blazor1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
using C1.Chart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
using ChartJs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
using C1.Blazor.Chart;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 18 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 21 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 34 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 37 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 38 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 39 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 40 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n   ");
            __builder.OpenComponent<C1.Blazor.Chart.FlexChart>(20);
            __builder.AddAttribute(21, "ItemsSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 48 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                           forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "BindingX", "Date");
            __builder.AddAttribute(23, "Class", "chart");
            __builder.AddAttribute(24, "ChartType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.ChartType>(
#nullable restore
#line 48 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                                                                               ChartType.Bar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "SeriesCollection", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<C1.Blazor.Chart.Series>(26);
                __builder2.AddAttribute(27, "Binding", "TemperatureC");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(28, "AxisCollection", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<C1.Blazor.Chart.Axis>(29);
                __builder2.AddAttribute(30, "AxisType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.AxisType>(
#nullable restore
#line 54 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                       AxisType.X

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.Position>(
#nullable restore
#line 54 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                                             Position.Bottom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "Title", "Temperature, C");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n\r\n        ");
                __builder2.OpenComponent<C1.Blazor.Chart.Axis>(34);
                __builder2.AddAttribute(35, "AxisType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.AxisType>(
#nullable restore
#line 56 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                        AxisType.Y

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.Position>(
#nullable restore
#line 56 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                                              Position.Left

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "AxisLine", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                                                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "MajorTickMarks", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<C1.Chart.TickMark>(
#nullable restore
#line 56 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                                                                                               TickMark.None

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "MajorGrid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 59 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"


}   

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\awake\OneDrive\Desktop\the Boekel Ecovillage\Blazor1\Blazor1\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);



    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591