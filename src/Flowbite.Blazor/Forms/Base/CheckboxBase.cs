using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Flowbite.Blazor.Components.Base;
using Microsoft.AspNetCore.Components;

namespace Flowbite.Blazor.Forms.Base;

public class CheckboxBase : BaseComponent
{
        /// <summary>
    /// RenderFragment to define a completely custom label
    /// </summary>
    [Parameter]
    public RenderFragment? Label { get; set; }

    /// <summary>
    /// Defines the text, if any, shown for the label. This will use Name from the DisplayAttribute if defined.
    /// </summary>
    [Parameter]
    public string? LabelText { get; set; }

    /// <summary>
    /// Defines the color of the checkbox when checked. Options are primary, supporting, accent, warning, danger, and success.
    /// </summary>
    [Parameter]
    public string Color { get; set; } = "primary";

    /// <summary>
    /// Defines whether the input is disabled
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }
    
    /// <summary>
    /// The value of the checkbox and the checked state
    /// </summary>
    [Parameter]
    public bool Checked { get; set; }
    
    /// <summary>
    /// The model/class of the field with the attribute
    /// </summary>
    [Parameter]
    public object? AttributeModel { get; set; }
    
    /// <summary>
    /// The name of the field with attribute as string
    /// </summary>
    [Parameter]
    public string? AttributeField { get; set; }

    /// <summary>
    /// Triggered when the value changes and sends the value when invoked
    /// </summary>
    [Parameter]
    public EventCallback<bool> OnChanged { get; set; }

    /// <summary>
    /// Internal field holding checkbox state
    /// </summary>
    internal bool _isChecked;

    /// <summary>
    /// Triggered when value changes to invoke callback
    /// </summary>
    internal async Task Clicked(ChangeEventArgs e)
    {
        bool value = (bool)e.Value!;
        Checked = value;
        await OnChanged.InvokeAsync(value);
    }
    
    /// <summary>
    /// Sets necessary fields/parameters whenever parameters change
    /// </summary>
    protected override Task OnParametersSetAsync()
    {
        try
        {
            _isChecked = Checked;
            if (AttributeModel is not null && AttributeField is not null && AttributeModel.GetType()
                .GetProperty(AttributeField)?
                .GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute displayAttribute)
            {
                var displayName = displayAttribute.Name;
                if (!string.IsNullOrEmpty(displayName) && string.IsNullOrEmpty(LabelText))
                {
                    LabelText = displayName;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return base.OnParametersSetAsync();
    }
}