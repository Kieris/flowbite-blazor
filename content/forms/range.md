## Blazor Range Slider - Flowbite Tailwind
Get started with the range component to receive a number from the user anywhere from 1 to 100 by sliding form control horizontally based on multiple options

The range component can be used as an input field to get a number from the user based on your custom selection (ie. from 1 to 100) by using a sliding animation.

### Setup
Import the form components from Flowbite.Blazor.Forms

```razor
@using Flowbite.Blazor.Forms
```

### Range slider example
Get started with this default example with values from 1 to 100 and the default value of 50.

```razor
<RangeSlider @bind-Value="@_value1" LabelText="Default range"></RangeSlider>
<div class="text-sm">
    Value: @_value1
</div>
```

### Disabled state
Apply the Disabled parameter to disallow the users from further selecting values

```razor
<RangeSlider @bind-Value="@_value2" LabelText="Disabled range" Disabled></RangeSlider>
```

### Min and max
The min and max values of the range can be set with the Min and Max parameters. The example below has a Min of 0 and Max of 10.

```razor
<RangeSlider @bind-Value="@_value3" LabelText="Min max range" Min="0" Max="10"></RangeSlider>
<div class="text-sm">
    Value: @_value3
</div>
```

### Steps
Use the Step parameter on the range component to set the increment with which the values will change. The data type of the step value should match that of the value property.

```razor
<RangeSlider @bind-Value="@_value4" LabelText="Step range" Min="0" Max="5" Step="0.5"></RangeSlider>
<div class="text-sm">
    Value: @_value4
</div>
```

### Range sizes
Use the Size parameter to change the size of the range component to small, medium (default), or large.

```razor
<RangeSlider Class="mt-3" @bind-Value="@_value4" LabelText="Small range" Min="0" Max="5" Step="0.5" Size="InputSizes.Small"></RangeSlider>
<RangeSlider Class="mt-3" @bind-Value="@_value3" LabelText="Default range" Min="0" Max="10"></RangeSlider>
<RangeSlider Class="mt-3" @bind-Value="@_value1" LabelText="Large range" Size="InputSizes.Large"></RangeSlider>
```

### OnChanged callback
The OnChanged callback is triggered whenever the value of the range slider changes as shown in the example below.

```razor
<RangeSlider @bind-Value="@_value3" LabelText="Callback" Min="0" Max="10" OnChanged="@((val) => _callVal = val)"></RangeSlider>
<div class="text-sm">
    Value: @_value3
</div>
<div class="text-sm">
    Callback Value: @_callVal
</div>
```
