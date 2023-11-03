using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Flowbite.Blazor.Forms.Base;


/// <summary>
/// An input component for editing numeric values.
/// Supported numeric types are <see cref="int"/>, <see cref="long"/>, <see cref="short"/>, <see cref="float"/>, <see cref="double"/>, <see cref="decimal"/>.
/// </summary>
public class BaseRange<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TValue> : InputBase<TValue>
{
    private static readonly string _stepAttributeValue = GetStepAttributeValue();

    /// <summary>
    /// Gets or sets the error message used when displaying an a parsing error.
    /// </summary>
    [Parameter] public string ParsingErrorMessage { get; set; } = "The {0} field must be a number.";
    
    /// <summary>
    /// The Min value for the range
    /// </summary>
    [Parameter]
    public double Min { get; set; }

    /// <summary>
    /// The max value for the range
    /// </summary>
    [Parameter]
    public double Max { get; set; } = 100;
    
    /// <summary>
    /// The style classes for the top level div of the element.
    /// </summary>
    [Parameter] public string? Class { get; set; }
    
    /// <summary>
    /// Defines the text, if any, shown for the label. This will use Name from the DisplayAttribute if defined.
    /// </summary>
    [Parameter] public string? LabelText { get; set; }
    
    /// <summary>
    /// Defines the size of the input. The default is Medium.
    /// </summary>
    [Parameter] public InputSizes Size { get; set; } = InputSizes.Medium;
    
    /// <summary>
    /// Defines whether the input is disabled
    /// </summary>
    [Parameter] public bool Disabled { get; set; }
    
    /// <summary>
    /// The id of the input which is used to connect label and input. The default is Guid.NewGuid().
    /// </summary>
    [Parameter]
    public string? Id { get; set; } = Guid.NewGuid().ToString();

    
    internal Type TargetType  = Nullable.GetUnderlyingType(typeof(TValue)) ?? typeof(TValue);
    
    protected override void OnInitialized()
    {
        base.OnInitialized();
        if (this.FieldIdentifier.Model.GetType()
                .GetProperty(this.FieldIdentifier.FieldName)?
                .GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute displayAttribute)
        {
            LabelText = displayAttribute.Name;
        }
    }

    private static string GetStepAttributeValue()
    {
        // Unwrap Nullable<T>, because InputBase already deals with the Nullable aspect
        // of it for us. We will only get asked to parse the T for nonempty inputs.
        var targetType = Nullable.GetUnderlyingType(typeof(TValue)) ?? typeof(TValue);
        if (targetType == typeof(int) ||
            targetType == typeof(long) ||
            targetType == typeof(short) ||
            targetType == typeof(float) ||
            targetType == typeof(double) ||
            targetType == typeof(decimal))
        {
            return "any";
        }
        else
        {
            throw new InvalidOperationException($"The type '{targetType}' is not a supported numeric type.");
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
            validationErrorMessage = string.Format(CultureInfo.InvariantCulture, ParsingErrorMessage, DisplayName ?? FieldIdentifier.FieldName);
            return false;
        }
    }

    /// <summary>
    /// Formats the value as a string. Derived classes can override this to determine the formatting used for <c>CurrentValueAsString</c>.
    /// </summary>
    /// <param name="value">The value to format.</param>
    /// <returns>A string representation of the value.</returns>
    protected override string? FormatValueAsString(TValue? value)
    {
        // Avoiding a cast to IFormattable to avoid boxing.
        switch (value)
        {
            case null:
                return null;

            case int @int:
                return BindConverter.FormatValue(@int, CultureInfo.InvariantCulture);

            case long @long:
                return BindConverter.FormatValue(@long, CultureInfo.InvariantCulture);

            case short @short:
                return BindConverter.FormatValue(@short, CultureInfo.InvariantCulture);

            case float @float:
                return BindConverter.FormatValue(@float, CultureInfo.InvariantCulture);

            case double @double:
                return BindConverter.FormatValue(@double, CultureInfo.InvariantCulture);

            case decimal @decimal:
                return BindConverter.FormatValue(@decimal, CultureInfo.InvariantCulture);

            default:
                throw new InvalidOperationException($"Unsupported type {value.GetType()}");
        }
    }
}