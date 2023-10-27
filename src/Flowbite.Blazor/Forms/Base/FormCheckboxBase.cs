using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Flowbite.Blazor.Forms.Base;

public class FormCheckboxBase: BaseInput<bool>
{
    /// <summary>
    /// RenderFragment to define a completely custom label
    /// </summary>
    [Parameter]
    public RenderFragment? Label { get; set; }
    
    /// <summary>
    /// Defines the color of the checkbox when checked. Options are primary, supporting, accent, warning, danger, and success.
    /// </summary>
    [Parameter]
    public string? Color { get; set; } = "primary";
    
    /// <summary>
    /// Defines whether there is a border and the label area is expanded
    /// </summary>
    [Parameter]
    public bool Bordered { get; set; }
    
    /// <summary>
    /// Defines whether to use "advanced" settings and hide the default checkbox
    /// </summary>
    [Parameter]
    public bool Advanced { get; set; }
    
    /// <summary>
    /// Defines the class for when the checkbox should be hidden to create an "advanced checkbox"
    /// </summary>
    [Parameter]
    public string? AdvancedClass { get; set; }

    /// <summary>
    /// Defines the rounding class for the border when <see cref="Bordered"/> is true
    /// </summary>
    [Parameter]
    public string RoundedClass { get; set; } = "rounded";

    /// <summary>
    /// Triggered when the value changes and sends the value when invoked
    /// </summary>
    [Parameter]
    public EventCallback<bool> OnChanged { get; set; }
    
    /// <inheritdoc />
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        Spacing = "ml-2";
    }

    /// <summary>
    /// Triggered when value changes to invoke callback
    /// </summary>
    internal async Task Clicked()
    {
        await OnChanged.InvokeAsync(CurrentValue);
    }

    /// <inheritdoc />
    protected override bool TryParseValueFromString(string? value, out bool result, [NotNullWhen(false)] out string? validationErrorMessage)
        => throw new NotSupportedException($"This component does not parse string inputs. Bind to the '{nameof(CurrentValue)}' property, not '{nameof(CurrentValueAsString)}'.");
}