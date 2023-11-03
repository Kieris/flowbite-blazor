using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Flowbite.Blazor.Forms.Base;

public class BaseFloatingLabel<TValue> : BaseValidationComponent<TValue>
{
    string _stdInput = "bg-transparent border-2 std-border";
    string _stdLabel = "top-3 -z-10 peer-focus:left-0 peer-placeholder-shown:translate-y-0 peer-focus:scale-75";
    string _bgInput = "px-2.5 bg-transparent rounded-lg border-1";
    string _bgLabel = "z-10 bg-white dark:bg-neutral-900 px-2 peer-focus:px-2 peer-placeholder-shown:-translate-y-1/2 peer-placeholder-shown:top-1/2 peer-focus:scale-75 left-1";
    string _filledInput = "rounded-t-lg px-2.5 bg-neutral-50 dark:bg-neutral-700 border-2 std-border";
    string _filledLabel = "z-10 left-2.5 peer-placeholder-shown:translate-y-0 peer-focus:scale-75";
    internal string BaseClass = "absolute duration-300 transform scale-75 origin-[0] peer-placeholder-shown:scale-100";
    internal string BaseInputClasses = "block w-full appearance-none focus:outline-none focus:ring-0 peer";
    internal string LabelSize = "";
    internal string InputSize = "";
    internal string LabelClass = "";
    internal string InputClass = "";
    
    /// <summary>
    /// Defines the size of the input. The default is Medium.
    /// </summary>
    [Parameter] public InputSizes Size { get; set; } = InputSizes.Medium;
    
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