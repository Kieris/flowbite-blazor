using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Flowbite.Blazor.Forms.Base;

public class BaseInput<TValue> : InputBase<TValue>
{
    /// <summary>
    /// Defines whether to show errors before input has had focus. The default is true.
    /// If set to false, errors will only show when a button has had focus independent of
    /// if the submit button has been clicked.
    /// </summary>
    [Parameter]
    public bool ShowError { get; set; } = true;
    
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
    /// The style classes for the top level div of the element.
    /// </summary>
    [Parameter] public string? Class { get; set; }
    
    /// <summary>
    /// The classes to apply for the rounding of the input element
    /// </summary>
    [Parameter]
    public string RoundedClass { get; set; } = "rounded-lg";
    
    /// <summary>
    /// Defines whether error and success messages should be displayed inside of an Alert component
    /// </summary>
    [Parameter]
    public bool AlertStyle { get; set; }
    
    /// <summary>
    /// Defines the text, if any, shown for the label. This will use Name from the DisplayAttribute if defined.
    /// </summary>
    [Parameter] public string? LabelText { get; set; }
    /// <summary>
    /// Defines the placeholder shown inside the input. This will use Prompt from the DisplayAttribute if defined.
    /// </summary>
    [Parameter] public string? Placeholder { get; set; }
    /// <summary>
    /// The text shown as a description under the input. This text will be overridden by any content in
    /// the <see cref="Description"/> fragment. This will use Description from the DisplayAttribute if defined. 
    /// </summary>
    [Parameter] public string? DescriptionText { get; set; }
    /// <summary>
    /// Defines a success message for when the input value is valid
    /// </summary>
    [Parameter] public string? SuccessMessage { get; set; }
    /// <summary>
    /// Defines the size of the input as long as <see cref="CustomSize"/> is null. The default is Medium.
    /// </summary>
    [Parameter] public InputSizes Size { get; set; } = InputSizes.Medium;
    /// <summary>
    /// Defines the spacing for the input div. Default is (mb-2). 
    /// </summary>
    [Parameter] public string Spacing { get; set; } = "mb-2";
    /// <summary>
    /// Defines classes to make the input a custom size. (e.g. p-2 text-sm)
    /// </summary>
    [Parameter] public string? CustomSize { get; set; }

    /// <summary>
    /// Defines whether the input is disabled
    /// </summary>
    [Parameter] public bool Disabled { get; set; }
    /// <summary>
    /// Used to define whether to explicitly exclude a label. The default is true (include the label).
    /// </summary>
    [Parameter] public bool IncludeLabel { get; set; } = true;
    /// <summary>
    /// Content placed inside the <Icon></Icon> fragment. This will include content on either side of the input based
    /// on <see cref="GroupType"/>
    /// </summary>
    [Parameter] public RenderFragment? Icon { get; set; }
    /// <summary>
    /// Used to display a description under the input as more than a simple string like with <see cref="DescriptionText"/>
    /// </summary>
    [Parameter] public RenderFragment? Description { get; set; }
    /// <summary>
    /// Gets or sets the reference to the rendered element.
    /// </summary>
    public ElementReference ElementRef { get; set; }
    /// <summary>
    /// Used to define the placement of the content inside <see cref="Icon"/> with relation to the input
    /// </summary>
    [Parameter]
    public InputGroupTypes GroupType { get; set; } = InputGroupTypes.Left;
    
    /// <summary>
    /// The id of the input which is used to connect label and input. The default is Guid.NewGuid().
    /// </summary>
    [Parameter]
    public string? Id { get; set; } = Guid.NewGuid().ToString();
    
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
                var displayName = displayAttribute.Name;
                if (!string.IsNullOrEmpty(displayName) && string.IsNullOrEmpty(LabelText))
                {
                    LabelText = displayName;
                }

                var placeholder = displayAttribute.Prompt;
                if (!string.IsNullOrEmpty(placeholder) && string.IsNullOrEmpty(Placeholder))
                {
                    Placeholder = placeholder;
                }
                
                var desc = displayAttribute.Description;
                if (!string.IsNullOrEmpty(desc) && string.IsNullOrEmpty(DescriptionText))
                {
                    DescriptionText = desc;
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
    
    /// <inheritdoc />
    protected override bool TryParseValueFromString(string? value, [MaybeNullWhen(false)] out TValue result, [NotNullWhen(false)] out string? validationErrorMessage)
    {
        if (BindConverter.TryConvertTo<TValue>(value, CultureInfo.InvariantCulture, out result))
        {
            validationErrorMessage = null;
            return true;
        }
        else
        {
            validationErrorMessage =
                $"The {DisplayName ?? FieldIdentifier.FieldName} field must be a {typeof(TValue)}.";
            return false;
        }
    }

    /// <summary>
    /// Returns whether errors should be shown which also affects text color (red)
    /// </summary>
    internal bool Errors() => ShowError && EditContext.GetValidationMessages(FieldIdentifier).Any();

    /// <summary>
    /// Returns whether input is valid which also affects text color (green)
    /// </summary>
    internal bool Success() => CssClass.Contains("modified") && !EditContext.GetValidationMessages(FieldIdentifier).Any();

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