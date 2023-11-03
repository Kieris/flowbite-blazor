using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Flowbite.Blazor.Forms.Base;

public class BaseInput<TValue> : BaseValidationComponent<TValue>
{
    /// <summary>
    /// Overrides the color for background, border, and ring
    /// </summary>
    [Parameter]
    public string? ColorClass { get; set; }
    
    /// <summary>
    /// Defines whether the label should be read only and not displayed.
    /// </summary>
    [Parameter]
    public bool LabelScreenReaderOnly { get; set; }
    
    /// <summary>
    /// The classes to apply for the rounding of the input element
    /// </summary>
    [Parameter]
    public string RoundedClass { get; set; } = "rounded-lg";
    
    /// <summary>
    /// Defines whether error and success messages are displayed on the top or bottom. Default is false or bottom.
    /// </summary>
    [Parameter]
    public bool MessageTop { get; set; }
    /// <summary>
    /// Defines the placeholder shown inside the input. This will use Prompt from the DisplayAttribute if defined.
    /// </summary>
    [Parameter] public string? Placeholder { get; set; }
    /// <summary>
    /// Defines the size of the input as long as <see cref="CustomSize"/> is null. The default is Medium.
    /// </summary>
    [Parameter] public InputSizes Size { get; set; } = InputSizes.Medium;
    /// <summary>
    /// Defines the spacing for the input div. Default is (mb-2). 
    /// </summary>
    [Parameter] public string Spacing { get; set; } = "mb-2";
    
    /// <summary>
    /// Used to define whether to explicitly exclude a label. The default is true (include the label).
    /// </summary>
    [Parameter] public bool IncludeLabel { get; set; } = true;
    
    /// <summary>
    /// Used to define the classes that change the size of the input based on <see cref="Size"/>
    /// </summary>
    internal string _size = string.Empty;

    /// <summary>
    /// Sets necessary fields/parameters whenever parameters change
    /// </summary>
    protected override void OnInitialized()
    {
        try
        {
            base.OnInitialized();
            switch (Size)
            {
                case InputSizes.Large:
                    _size = "p-4 sm:text-base";
                    break;
                case InputSizes.Small:
                    _size = "p-2 sm:text-xs";
                    break;
                default:
                    _size = "p-2.5 text-sm";
                    break;
            }
            if (this.FieldIdentifier.Model.GetType()
                .GetProperty(this.FieldIdentifier.FieldName)?
                .GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute displayAttribute)
            {
                var placeholder = displayAttribute.Prompt;
                if (!string.IsNullOrEmpty(placeholder) && string.IsNullOrEmpty(Placeholder))
                {
                    Placeholder = placeholder;
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
    

    /// <summary>
    /// Defines the colors for the input based on validation
    /// </summary>
    internal string GetNormalClass()
    {
        if (EditContext != default!)
        {
            if(ShowError && EditContext.GetValidationMessages(FieldIdentifier).Any()) return "input-error";
            if(Success()) return "input-success";
        }
        return "input-normal";
    }

    /// <summary>
    /// Defines the colors for the label based on validation
    /// </summary>
    internal string GetLabelColor()
    {
        if (EditContext != default!)
        {
            if(ShowError && EditContext.GetValidationMessages(FieldIdentifier).Any()) return "text-danger-700 dark:text-danger-500";
            if(Success()) return "text-success-700 dark:text-success-500";
        }
        return "text-neutral-900 dark:text-white";
    }
}