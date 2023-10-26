## Blazor Radio - Tailwind

Get started with the radio component to let the user choose a single option from multiple options in the form of a circle based on multiple styles and colors

The radio component can be used to allow the user to choose a single option from one or more available options coded with the utility classes from Tailwind CSS and available in multiple styles, variants, and colors and support dark mode.

These radio components do not have to be inside an EditForm, but they do need to be inside an InputRadioGroup.

### Setup
Import the form components from Flowbite.Blazor.Forms

```razor
@using Flowbite.Blazor.Forms
```
### Radio example
Use the default example of a radio component with the checked and unchecked state.

```razor
<InputRadioGroup @bind-Value="@_model.Value">
    @foreach (var manufacturer in _manufacturers)
    {
        <Radio class="mb-2" Value="@manufacturer" LabelText="@manufacturer" />
    }
</InputRadioGroup>
@_model.Value

@code {
    RadioTestModel _model = new();

    List<string> _manufacturers = new List<string> { "Ford", "Toyota", "Tesla", "Honda" };
}
```

```csharp
public class RadioTestModel
{
    public string Value { get; set; } = "Tesla";
}
```

### Disabled state

Use the default example of a radio component with the checked and unchecked state. Apply the disabled attribute to the radio component to disallow the selection for the user.

```razor
<InputRadioGroup @bind-Value="@_disabled.Value">
    <Radio Value="@("first")" LabelText="Disabled radio" Disabled/>
    <Radio Value="@("second")" LabelText="Disabled checked" Disabled/>
</InputRadioGroup>
```

### Radio link
Use this example if you want to add an anchor link inside the label of the radio component.

```razor
<InputRadioGroup @bind-Value="@_testModel.Value">
    <Radio Value="@("second")">
        <Label>
            <span class="text-sm font-medium text-neutral-900 dark:text-neutral-300">I agree with the <Anchor href="#">terms and conditions</Anchor>.</span>
        </Label>
    </Radio>
</InputRadioGroup>
```

### Helper text
Get started with this example if you want to add a secondary helper text for the radio component.

```razor
<InputRadioGroup @bind-Value="@_testModel.Value">
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <!-- Default -->
        <Radio Value="@("first")" DescriptionText="For orders shipped from $25 in books or $29 in other categories"
                LabelText="Free shipping via Flowbite">
        </Radio>
        <!--Using fragments -->
        <Radio Value="@("second")">
            <Label>
                <span class="text-sm font-medium text-neutral-900 dark:text-neutral-300">Custom label and helper text</span>
            </Label>
            <Description>
                <div class="text-xs font-normal text-neutral-500 dark:text-neutral-300 pl-6">For orders shipped from $25 in books or $29 in other categories</div>
            </Description>
        </Radio>
    </div>
</InputRadioGroup>
```

### Bordered
Use this example of a radio inside a card with a border.

```razor
<InputRadioGroup @bind-Value="@_testModel.Value">
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <Radio Value="@("first")" LabelText="Default checkbox" Bordered></Radio>
        <Radio Value="@("second")" LabelText="Checked state" Bordered RoundedClass="rounded-lg"></Radio>
    </div>
    <Radio Value="@("third")" Bordered DescriptionText="For orders shipped from $25 in books or $29 in other categories"
            LabelText="Free shipping via Flowbite">
    </Radio>
</InputRadioGroup>
```

### Radio list group
This example can be used to show a list of radio buttons inside a grouped list.

```razor
<InputRadioGroup @bind-Value="@_model.Value">
    <ListGroup Class="w-48">
        @foreach (string item in _manufacturers)
        {
            <ListGroupItem Class="py-3">
                <Radio Value="@item" LabelText="@item"></Radio>
            </ListGroupItem>
        }
    </ListGroup>
</InputRadioGroup>
```

### Horizontal list group
Use this example to show a list of radio buttons inside a card horizontally.

```razor
<InputRadioGroup @bind-Value="@_model.Value">
    <ListGroup Horizontal>
        @foreach (string item in _manufacturers)
        {
            <ListGroupItem Class="py-3">
                <Radio Value="@item" LabelText="@item"></Radio>
            </ListGroupItem>
        }
    </ListGroup>
</InputRadioGroup>
```

### Radio dropdown
Use this example to show a list of radio buttons inside a dropdown menu. Importing popper.js and Flowbite.Blazor.Components.Dropdown is required for the dropdown.

```razor
<div class="flex justify-center">
    <Dropdown Class="w-64" Placement="Positions.Bottom">
        <DropdownTrigger>
            <Button>
                Dropdown search
                <ChevronDownSolid class="ml-3 w-3 h-3 text-white"></ChevronDownSolid>
            </Button>
        </DropdownTrigger>
        <DropdownItems>
            <InputRadioGroup @bind-Value="@_model.Value">
                <DropdownItem>
                    <Radio Value="@("individual")" LabelText="Individual" DescriptionText="Some helpful instruction goes over here."/>
                </DropdownItem>
                <DropdownItem>
                    <Radio Value="@("company")" LabelText="Company" DescriptionText="Some helpful instruction goes over here." />
                </DropdownItem>
                <DropdownItem>
                    <Radio Value="@("nonprofit")" LabelText="Non profit" DescriptionText="Some helpful instruction goes over here." />
                </DropdownItem>
            </InputRadioGroup>
        </DropdownItems>
    </Dropdown>
</div>
```

### Inline layout
Using flex on a List component, the radio buttons can be aligned horizontally.

```razor
<InputRadioGroup @bind-Value="@_model.Value">
    <List class="flex flex-wrap items-center">
        @foreach (string item in _manufacturers)
        {
            <ListItem>
                <Radio Class="px-4" Value="@item" LabelText="@item"></Radio>
            </ListItem>
        }
    </List>
</InputRadioGroup>
```
    
    
### Colors
Use the CheckColor parameter to change the color of the radio component.

```razor
<InputRadioGroup @bind-Value="@_colorModel.Value">
    <List class="flex flex-wrap items-center">
        @foreach (string item in _colors)
        {
            <ListItem>
                <Radio Class="px-4" CheckColor="@item" Value="@item" LabelText="@item"></Radio>
            </ListItem>
        }
    </List>
</InputRadioGroup>
```
```razor
@code {
    RadioTestModel _colorModel = new() { Value = "Supporting" };
    List<string> _colors = new List<string> { "Primary", "Supporting", "Accent", "Danger", "Warning", "Success" };
}
```

### Advanced layout
Use this example of an advanced layout of radio buttons where the label parent element can be styled when the radio is checked.

```razor
<Heading Tag="h3" Class="mb-5 text-lg">How much do you expect to use each month?</Heading>
<InputRadioGroup @bind-Value="@_model.Value">
    <List class="grid w-full gap-6 md:grid-cols-2">
        <ListItem>
            <!-- Default -->
            <Radio Class="px-4" Value="@("first")" Advanced="true">
                <Label>
                    <div class="block">
                        <div class="w-full text-lg font-semibold">0-50 MB</div>
                        <div class="w-full">Good for small websites</div>
                    </div>
                    <ArrowRightSolid class="w-5 h-5 ml-3"></ArrowRightSolid>
                </Label>
            </Radio>
        </ListItem>
        <ListItem>
            <!-- Setting advanced class -->
            <Radio Class="px-4" Value="@("second")" Advanced="true"
                    AdvancedClass="@($"inline-flex items-center justify-between w-full p-5 text-neutral-500 bg-white border-2 border-neutral-200 rounded-lg cursor-pointer dark:hover:text-neutral-300 dark:border-neutral-700 peer-checked:border-primary-600 hover:text-neutral-600 dark:peer-checked:text-neutral-300 peer-checked:text-neutral-600 hover:bg-neutral-50 dark:text-neutral-400 dark:bg-neutral-800 dark:hover:bg-neutral-700")">
                <Label>   
                    <div class="block">
                        <div class="w-full text-lg font-semibold">500-1000 MB</div>
                        <div class="w-full">Good for large websites</div>
                    </div>
                    <ArrowRightSolid class="w-5 h-5 ml-3"></ArrowRightSolid>
                </Label>
            </Radio>
        </ListItem>
    </List>
</InputRadioGroup>
```

### OnClicked callback
The OnClicked callback is triggered whenever the radio is clicked as shown in the example below.

```razor
<InputRadioGroup @bind-Value="@_model.Value">
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <Radio Value="@("first")" LabelText="First radio" OnClicked="@((val) => _callVal = val.ToString())" />
        <Radio Value="@("second")" LabelText="Second radio" OnClicked="@((val) => _callVal = val.ToString())" />
        <Radio Value="@("third")" LabelText="Third radio" OnClicked="@((val) => _callVal = val.ToString())" />
        <div class="text-sm">Callback value: @_callVal</div>
    </div>
</InputRadioGroup>
```