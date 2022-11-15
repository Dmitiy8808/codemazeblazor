using Microsoft.AspNetCore.Components;

namespace CodeMazeBlazor.Components
{
    public partial class Home
    {
       
        [Parameter]
        public string? Title { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object>? AdditionalAttributes { get; set; }

        [CascadingParameter(Name = "HeadingColor")]
        public string? Color { get; set; }
        [Parameter]
        public RenderFragment? VisitShopComponent { get; set; }

    }
}