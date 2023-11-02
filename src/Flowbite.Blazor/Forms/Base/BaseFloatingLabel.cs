using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Flowbite.Blazor.Forms.Base;

public class BaseFloatingLabel<TValue> : InputBase<TValue>, IValidationComponent<TValue>
{
    string _filledLg = "pb-4.5 pt-6";
    string _stdInput = "bg-transparent border-2 std-border";
    string _stdLabel = "top-3 -z-10 peer-focus:left-0 peer-placeholder-shown:translate-y-0 peer-focus:scale-75";
    string _bgInput = "px-2.5 bg-transparent rounded-lg border-1";
    string _bgLabel = "z-10 bg-white dark:bg-neutral-900 px-2 peer-focus:px-2 peer-placeholder-shown:-translate-y-1/2 peer-placeholder-shown:top-1/2 peer-focus:scale-75 left-1";
    string _filledInput = "rounded-t-lg px-2.5 bg-neutral-50 dark:bg-neutral-700 border-2 std-border";
    string _filledLabel = "z-10 left-2.5 peer-placeholder-shown:translate-y-0 peer-focus:scale-75";
    internal string BaseClass = "absolute duration-300 transform scale-75 origin-[0] peer-placeholder-shown:scale-100";
    internal string BaseInputClasses = "block w-full appearance-none focus:outline-none focus:ring-0 peer";
    string _labelRed = "text-danger-600 dark:text-danger-500";
    internal string LabelSize = "";
    internal string InputSize = "";
    internal string LabelClass = "";
    internal string InputClass = "";
    string? _value;
    
    /// <summary>
    /// The style classes for the top level div of the element.
    /// </summary>
    [Parameter] public string? Class { get; set; }
    /// <summary>
    /// Defines whether to show errors before input has had focus. The default is true.
    /// If set to false, errors will only show when a button has had focus independent of
    /// if the submit button has been clicked.
    /// </summary>
    [Parameter]
    public bool ShowError { get; set; } = true;
    /// <summary>
    /// The id of the input which is used to connect label and input. The default is Guid.NewGuid().
    /// </summary>
    [Parameter]
    public string? Id { get; set; } = Guid.NewGuid().ToString();
    /// <summary>
    /// Used to display a description under the input as more than a simple string like with <see cref="DescriptionText"/>
    /// </summary>
    [Parameter] public RenderFragment? Description { get; set; }
    /// <summary>
    /// Defines whether the input is disabled
    /// </summary>
    [Parameter] public bool Disabled { get; set; }
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
    /// Defines the text, if any, shown for the label. This will use Name from the DisplayAttribute if defined.
    /// </summary>
    [Parameter] public string? LabelText { get; set; }
    /// <summary>
    /// Defines whether error and success messages should be displayed inside of an Alert component
    /// </summary>
    [Parameter]
    public bool AlertStyle { get; set; }
    
    
    /// <summary>
    /// Returns whether errors should be shown which also affects text color (red)
    /// </summary>
    public bool Errors() => ShowError && EditContext.GetValidationMessages(FieldIdentifier).Any();
    
    /// <summary>
    /// Returns whether input is valid which also affects text color (green)
    /// </summary>
    public bool Success() => CssClass.Contains("modified") && !EditContext.GetValidationMessages(FieldIdentifier).Any();
    
/// <summary>
    /// The type of floating label (standard, filled, outline)
    /// </summary>
    [Parameter]
    public FloatType FloatType { get; set; } = FloatType.Standard;
    
    /// <summary>
    /// Returns the current value when the text is changed
    /// </summary>
    [Parameter]
    public EventCallback<string> OnChanged { get; set; }

    /// <summary>
    /// Defines the type for the input. This should only include types that are string. If number type is needed, use
    /// NumberInput component. The default is text.
    /// </summary>
    [Parameter] public string Type { get; set; } = "text";
    
    
    /// <inheritdoc />
    protected override void OnInitialized()
    {
        base.OnInitialized();
        if (FloatType == FloatType.Standard)
        {
            LabelClass = _stdLabel;
            InputClass = _stdInput;
            
            switch (Size)
            {
                case InputSizes.Small:
                    LabelSize = "-translate-y-6 peer-focus:-translate-y-6 text-sm";
                    InputSize = "px-0 py-2 text-sm";
                    break;
                case InputSizes.Medium:
                    LabelSize = "-translate-y-6 peer-focus:-translate-y-6 text-sm";
                    InputSize = "py-2.5 px-0 text-sm";
                    break;
                case InputSizes.Large:
                    LabelSize = "-translate-y-6 peer-focus:-translate-y-6 md:text-md";
                    InputSize = "py-3.5 px-0 md:text-md";
                    break;
            }
        }
        else if (FloatType == FloatType.Filled)
        {
            LabelClass = _filledLabel;
            InputClass = _filledInput;
            
            switch (Size)
            {
                case InputSizes.Small:
                    LabelSize = "-translate-y-3 top-3 peer-focus:-translate-y-3 text-sm";
                    InputSize = "pb-1.5 pt-4 text-sm";
                    break;
                case InputSizes.Medium:
                    LabelSize = "-translate-y-4 top-4 peer-focus:-translate-y-4 text-sm";
                    InputSize = "pb-2.5 pt-5 text-sm";
                    break;
                case InputSizes.Large:
                    LabelSize = "-translate-y-6 top-6 peer-focus:-translate-y-6 md:text-md";
                    InputSize = "pb-4 pt-6 md:text-md";
                    break;
            }
        }
        else
        {
            LabelClass = _bgLabel;
            InputClass = _bgInput;
            
            switch (Size)
            {
                case InputSizes.Small:
                    LabelSize = "-translate-y-3 top-1 peer-focus:top-1 peer-focus:-translate-y-3 text-sm";
                    InputSize = "pb-1.5 pt-3 text-sm";
                    break;
                case InputSizes.Medium:
                    LabelSize = "-translate-y-4 top-2 peer-focus:top-2 peer-focus:-translate-y-4 text-sm";
                    InputSize = "pb-2.5 pt-4 text-sm";
                    break;
                case InputSizes.Large:
                    LabelSize = "-translate-y-6 top-4 peer-focus:top-4 peer-focus:-translate-y-6 md:text-md";
                    InputSize = "pb-4 pt-6 md:text-md";
                    break;
            }
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
    /// Gets the color for the input based on validation state
    /// </summary>
    internal string GetColorClass()
    {
        if (EditContext != default!)
        {
            if(ShowError && EditContext.GetValidationMessages(FieldIdentifier).Any()) return "fl-input-error";
            if(Success()) return "fl-input-success";
        }
        return "fl-input-normal";
    }
    
    /// <summary>
    /// Gets the color for the label based on validation state
    /// </summary>
    internal string GetLabelClass()
    {
        if (EditContext != default!)
        {
            if(ShowError && EditContext.GetValidationMessages(FieldIdentifier).Any()) return "label-red";
            if(Success()) return "label-green";
        }
        return "floating-label";
    }
    
}