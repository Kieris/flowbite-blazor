## Blazor Checkbox - Flowbite Tailwind
Get started with the checkbox component to allow the user to select one or more options in the form of a square box available in multiple sizes and colors

The checkbox component can be used to receive one or more selected options from the user in the form of a square box available in multiple styles, sizes, colors, and variants coded with the utility classes from Tailwind CSS and with support for dark mode.

### Setup
Import the form components from Flowbite.Blazor.Forms

```razor
@using Flowbite.Blazor.Forms
```

### Checkbox example
Use this default example of a checkbox element in a checked and unchecked state. The label will be the DisplayAtttribute Name if LabelText is not defined.

```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Checkbox @bind-Value="_form.Checked1" LabelText="Default checkbox"></Checkbox>
    <div>Default: @_form.Checked1</div>
    <Checkbox @bind-Value="_form.Checked2"></Checkbox>
    <div>Checked: @_form.Checked2</div>
</div>
```

### With validation
Wrap the form controls in an EditForm and use the DataAnnotationsValidator component to validate the form.

```razor
<EditForm Model="@_form">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <Checkbox @bind-Value="_form.Checked1" LabelText="Default checkbox"></Checkbox>
        <div>Default: @_form.Checked1</div>
        <Checkbox @bind-Value="_form.Checked2" SuccessMessage="Value is correct!"></Checkbox>
        <div>Checked: @_form.Checked2</div>
    </div>
</EditForm>

@code {
    TestFormCheckboxModel _form = new();
}
```

```csharp
public class TestFormCheckboxModel
{
    public bool Checked1 { get; set; }

    [Display(Name="Checked state")]
    [Range(typeof(bool), "true", "true", ErrorMessage = "This checkbox must be true.")]
    public bool Checked2 { get; set; } = true;
}
```
    
### Disabled state
This example can be used for the disabled state of the checkbox component by applying the disabled attribute to the input element.

```razor
<Checkbox Class="mb-2" @bind-Value="_form2.Checked1" LabelText="Disabled checkbox" Disabled></Checkbox>
<Checkbox @bind-Value="_form2.Checked2" LabelText="Disabled checked" Disabled></Checkbox>
```

### Checkbox link
Use this example if you want to add an anchor link inside the label of the checkbox component.

```razor
<Checkbox @bind-Value="_form.Checked1">
    <Label>
        <span class="text-sm font-medium text-neutral-900 dark:text-neutral-300">I agree with the <Anchor href="#">terms and conditions</Anchor>.</span>
    </Label>
</Checkbox>
```

### Helper text
Get started with this example if you want to add a secondary helper text for the checkbox component.

```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <!-- Default -->
    <Checkbox @bind-Value="_form.Checked1" DescriptionText="For orders shipped from $25 in books or $29 in other categories"
                LabelText="Free shipping via Flowbite">
    </Checkbox>
    <!--Using fragments -->
    <Checkbox @bind-Value="_form.Checked1">
        <Label>
            <span class="text-sm font-medium text-neutral-900 dark:text-neutral-300">Custom label and helper text</span>
        </Label>
        <Description>
            <div class="text-xs font-normal text-neutral-500 dark:text-neutral-300 pl-7">For orders shipped from $25 in books or $29 in other categories</div>
        </Description>
    </Checkbox>
</div>
```
    
### Bordered
Use this example of a checkbox inside a card element to enable a larger area of clicking activation.

```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Checkbox @bind-Value="_form3.Checked1" LabelText="Default checkbox" Bordered></Checkbox>
    <Checkbox @bind-Value="_form3.Checked2" LabelText="Checked state" Bordered RoundedClass="rounded-lg"></Checkbox>
</div>
<Checkbox @bind-Value="_form2.Checked1" Bordered DescriptionText="For orders shipped from $25 in books or $29 in other categories"
            LabelText="Free shipping via Flowbite">
</Checkbox>
```

### Checkbox list group
This example can be used to show a list of checkboxes inside a grouped list.

```razor
<ListGroup Class="w-48">
    @foreach (CheckboxLabelModel item in _listBoxes)
    {
        <ListGroupItem Class="py-3">
            <Checkbox @bind-Value="@item.Checked" LabelText="@item.Label"></Checkbox>
        </ListGroupItem>
    }
</ListGroup>

@code {
    List<FormCheckboxLabelModel> listBoxes = new();

    protected override void OnInitialized()
    {
        listBoxes.Add(new FormCheckboxLabelModel() { Label = "Blazor" });
        listBoxes.Add(new FormCheckboxLabelModel() { Label = "Vue JS" });
        listBoxes.Add(new FormCheckboxLabelModel() { Label = "React" });
        listBoxes.Add(new FormCheckboxLabelModel() { Label = "Angular" });
    }

}
```
```csharp
public class FormCheckboxLabelModel
{
    public string Label { get; set; } = "Label";
    
    public bool Checked { get; set; }
}
```
    
### Horizontal list group
Use this example to show a list of checkbox items inside a card horizontally.

```razor
<ListGroup Horizontal>
    @foreach (CheckboxLabelModel item in _listBoxes)
    {
        <ListGroupItem Class="py-3">
            <Checkbox @bind-Value="@item.Checked" LabelText="@item.Label"></Checkbox>
        </ListGroupItem>
    }
</ListGroup>
```

### Checkbox dropdown
Use this example to show a list of checkbox items inside a dropdown menu. Importing popper.js and Flowbite.Blazor.Components.Dropdown is required for the dropdown.

```razor
<div class="flex justify-center">
    <Dropdown Class="w-64" Placement="Positions.Bottom">
        <DropdownTrigger>
            <Button>
                Dropdown search
                <ChevronDownSolid class="ml-3 w-3 h-3 text-white"></ChevronDownSolid>
            </Button>
        </DropdownTrigger>
        <Header>
            <div class="p-3">
                <label for="input-group-search" class="sr-only">Search</label>
                <div class="relative">
                    <div class="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
                        <SearchOutline class="w-4 h-4 text-gray-500 dark:text-gray-400"></SearchOutline>
                    </div>
                    <input type="text" id="input-group-search" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-600 dark:border-gray-500 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Search user">
                </div>
            </div>
        </Header>
        <DropdownItems>
            @foreach (CheckboxLabelModel item in _listBoxes)
            {
                <DropdownItem>
                    <Checkbox @bind-Value="@item.Checked" LabelText="@item.Label"></Checkbox>
                </DropdownItem>
            }
        </DropdownItems>
        <Footer>
            <a href="#" class="flex items-center pt-3 px-3 text-sm font-medium text-red-600 border-t border-gray-200 rounded-b-lg bg-gray-50 dark:border-gray-600 dark:bg-gray-700 dark:text-red-500 hover:underline">
                <UserSolid class="w-4 h-4 mr-2"></UserSolid>
                Delete user
            </a>
        </Footer>
    </Dropdown>
</div>
```

### Inline layout
Use this example of a checkbox inside a card element to enable a larger area of clicking activation.

```razor
<List class="flex flex-wrap items-center">
    @foreach (CheckboxLabelModel item in _listBoxes)
    {
        <ListItem>
            <Checkbox Class="px-4" @bind-Value="@item.Checked" LabelText="@item.Label"></Checkbox>
        </ListItem>
    }
</List>
```
    
### Colors
Use the Color parameter to change the color of the checkbox component.

```razor
<List class="flex flex-wrap items-center">
    @foreach (CheckboxLabelColorModel item in _colors)
    {
        <ListItem>
            <Checkbox Class="px-4" Color="@item.Color" @bind-Value="@item.Checked" LabelText="@item.Label"></Checkbox>
        </ListItem>
    }
</List>

@code {
    List<FormCheckboxLabelColorModel> _colors = new();

    protected override void OnInitialized()
    {
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Primary", Color = "primary", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Danger", Color = "danger", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Warning", Color = "warning", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Accent", Color = "accent", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Supporting", Color = "supporting", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Success", Color = "success", Checked = true });
    }

}
```

```csharp
public class FormCheckboxLabelColorModel
{
    public string Label { get; set; } = "Label";

    public string Color { get; set; } = "primary";
    
    public bool Checked { get; set; }
}
```


### Advanced layout
Use this example of an advanced layout of checkbox elements where the label parent element can be styled when the checkbox is checked.

```razor
<List class="flex flex-wrap items-center">
    <ListItem>
        <!-- Default -->
        <Checkbox Class="px-4" @bind-Value="@_form.Checked1" Advanced="true">
            <Label>
                <div class="block w-48">
                    <svg class="mb-2 w-7 h-7 text-sky-500" fill="currentColor" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 512 512"><path d="M418.2 177.2c-5.4-1.8-10.8-3.5-16.2-5.1.9-3.7 1.7-7.4 2.5-11.1 12.3-59.6 4.2-107.5-23.1-123.3-26.3-15.1-69.2.6-112.6 38.4-4.3 3.7-8.5 7.6-12.5 11.5-2.7-2.6-5.5-5.2-8.3-7.7-45.5-40.4-91.1-57.4-118.4-41.5-26.2 15.2-34 60.3-23 116.7 1.1 5.6 2.3 11.1 3.7 16.7-6.4 1.8-12.7 3.8-18.6 5.9C38.3 196.2 0 225.4 0 255.6c0 31.2 40.8 62.5 96.3 81.5 4.5 1.5 9 3 13.6 4.3-1.5 6-2.8 11.9-4 18-10.5 55.5-2.3 99.5 23.9 114.6 27 15.6 72.4-.4 116.6-39.1 3.5-3.1 7-6.3 10.5-9.7 4.4 4.3 9 8.4 13.6 12.4 42.8 36.8 85.1 51.7 111.2 36.6 27-15.6 35.8-62.9 24.4-120.5-.9-4.4-1.9-8.9-3-13.5 3.2-.9 6.3-1.9 9.4-2.9 57.7-19.1 99.5-50 99.5-81.7 0-30.3-39.4-59.7-93.8-78.4zM282.9 92.3c37.2-32.4 71.9-45.1 87.7-36 16.9 9.7 23.4 48.9 12.8 100.4-.7 3.4-1.4 6.7-2.3 10-22.2-5-44.7-8.6-67.3-10.6-13-18.6-27.2-36.4-42.6-53.1 3.9-3.7 7.7-7.2 11.7-10.7zM167.2 307.5c5.1 8.7 10.3 17.4 15.8 25.9-15.6-1.7-31.1-4.2-46.4-7.5 4.4-14.4 9.9-29.3 16.3-44.5 4.6 8.8 9.3 17.5 14.3 26.1zm-30.3-120.3c14.4-3.2 29.7-5.8 45.6-7.8-5.3 8.3-10.5 16.8-15.4 25.4-4.9 8.5-9.7 17.2-14.2 26-6.3-14.9-11.6-29.5-16-43.6zm27.4 68.9c6.6-13.8 13.8-27.3 21.4-40.6s15.8-26.2 24.4-38.9c15-1.1 30.3-1.7 45.9-1.7s31 .6 45.9 1.7c8.5 12.6 16.6 25.5 24.3 38.7s14.9 26.7 21.7 40.4c-6.7 13.8-13.9 27.4-21.6 40.8-7.6 13.3-15.7 26.2-24.2 39-14.9 1.1-30.4 1.6-46.1 1.6s-30.9-.5-45.6-1.4c-8.7-12.7-16.9-25.7-24.6-39s-14.8-26.8-21.5-40.6zm180.6 51.2c5.1-8.8 9.9-17.7 14.6-26.7 6.4 14.5 12 29.2 16.9 44.3-15.5 3.5-31.2 6.2-47 8 5.4-8.4 10.5-17 15.5-25.6zm14.4-76.5c-4.7-8.8-9.5-17.6-14.5-26.2-4.9-8.5-10-16.9-15.3-25.2 16.1 2 31.5 4.7 45.9 8-4.6 14.8-10 29.2-16.1 43.4zM256.2 118.3c10.5 11.4 20.4 23.4 29.6 35.8-19.8-.9-39.7-.9-59.5 0 9.8-12.9 19.9-24.9 29.9-35.8zM140.2 57c16.8-9.8 54.1 4.2 93.4 39 2.5 2.2 5 4.6 7.6 7-15.5 16.7-29.8 34.5-42.9 53.1-22.6 2-45 5.5-67.2 10.4-1.3-5.1-2.4-10.3-3.5-15.5-9.4-48.4-3.2-84.9 12.6-94zm-24.5 263.6c-4.2-1.2-8.3-2.5-12.4-3.9-21.3-6.7-45.5-17.3-63-31.2-10.1-7-16.9-17.8-18.8-29.9 0-18.3 31.6-41.7 77.2-57.6 5.7-2 11.5-3.8 17.3-5.5 6.8 21.7 15 43 24.5 63.6-9.6 20.9-17.9 42.5-24.8 64.5zm116.6 98c-16.5 15.1-35.6 27.1-56.4 35.3-11.1 5.3-23.9 5.8-35.3 1.3-15.9-9.2-22.5-44.5-13.5-92 1.1-5.6 2.3-11.2 3.7-16.7 22.4 4.8 45 8.1 67.9 9.8 13.2 18.7 27.7 36.6 43.2 53.4-3.2 3.1-6.4 6.1-9.6 8.9zm24.5-24.3c-10.2-11-20.4-23.2-30.3-36.3 9.6.4 19.5.6 29.5.6 10.3 0 20.4-.2 30.4-.7-9.2 12.7-19.1 24.8-29.6 36.4zm130.7 30c-.9 12.2-6.9 23.6-16.5 31.3-15.9 9.2-49.8-2.8-86.4-34.2-4.2-3.6-8.4-7.5-12.7-11.5 15.3-16.9 29.4-34.8 42.2-53.6 22.9-1.9 45.7-5.4 68.2-10.5 1 4.1 1.9 8.2 2.7 12.2 4.9 21.6 5.7 44.1 2.5 66.3zm18.2-107.5c-2.8.9-5.6 1.8-8.5 2.6-7-21.8-15.6-43.1-25.5-63.8 9.6-20.4 17.7-41.4 24.5-62.9 5.2 1.5 10.2 3.1 15 4.7 46.6 16 79.3 39.8 79.3 58 0 19.6-34.9 44.9-84.8 61.4zm-149.7-15c25.3 0 45.8-20.5 45.8-45.8s-20.5-45.8-45.8-45.8c-25.3 0-45.8 20.5-45.8 45.8s20.5 45.8 45.8 45.8z"/></svg>
                    <div class="w-full text-lg font-semibold">React Js</div>
                    <div class="w-full text-sm">A JavaScript library for building user interfaces.</div>
                </div>
            </Label>
        </Checkbox>
    </ListItem>
    <ListItem>
        <!-- Setting advanced class -->
        <Checkbox Class="px-4" @bind-Value="@_form.Checked2" Advanced="true"
                    AdvancedClass="@($"inline-flex items-center justify-between w-full p-5 text-neutral-500 bg-white border-2 border-neutral-200 rounded-lg cursor-pointer dark:hover:text-neutral-300 dark:border-neutral-700 peer-checked:border-indigo-600 hover:text-neutral-600 dark:peer-checked:text-neutral-300 peer-checked:text-neutral-600 hover:bg-neutral-50 dark:text-neutral-400 dark:bg-neutral-800 dark:hover:bg-neutral-700")">
            <Label>
                <div class="block w-48">
                    <svg fill="none" class="mb-2 w-7 h-7" viewBox="-10.12021875 -53.60951036 339.95397529 343.02235093" width="2500" xmlns="http://www.w3.org/2000/svg"><path d="m303.935 88.479c-6.598 41.362-27.653 79.041-59.42 106.335s-72.185 42.433-114.064 42.723c-8.483.326-16.977-.19-25.358-1.539a77.723 77.723 0 0 1 -64.63-73.266 75.479 75.479 0 0 1 22.14-52.762 75.46 75.46 0 0 1 105.885-.748 75.478 75.478 0 0 1 22.884 52.443c.317 12.51-5.102 23.483-16.239 23.8-11.899 0-17.477-8.491-17.477-19.934v-31.797a19.478 19.478 0 0 0 -19.323-19.494h-26.653a46.386 46.386 0 0 0 -39.119 20.961 46.399 46.399 0 0 0 31.587 71.268 46.392 46.392 0 0 0 41.8-14.911l.932-1.39.933 1.543a32.82 32.82 0 0 0 27.986 13.328 36.992 36.992 0 0 0 34.268-38.671 100.64 100.64 0 0 0 -2.761-24.577c-4.943-22.734-18.126-42.834-37.008-56.423a94.153 94.153 0 0 0 -125.236 13.718 94.175 94.175 0 0 0 -23.92 63.097 95.352 95.352 0 0 0 27.473 65.824 95.331 95.331 0 0 0 65.448 28.344s6.98.635 14.849.454a200.94 200.94 0 0 0 107.769-32.155c.457-.318.914.317.61.78a158.177 158.177 0 0 1 -123.225 50.396 111.185 111.185 0 0 1 -80.961-32.871 111.215 111.215 0 0 1 -32.215-81.232 115.099 115.099 0 0 1 46.223-92.17 112.704 112.704 0 0 1 66.497-21.953h35.772a100.637 100.637 0 0 0 74.247-32.784 1.39 1.39 0 0 1 .755-.431 1.418 1.418 0 0 1 1.52.663c.153.257.222.555.197.854a100.93 100.93 0 0 1 -15.608 45.14 1.386 1.386 0 0 0 .115 1.511 1.387 1.387 0 0 0 1.424.507 108.158 108.158 0 0 0 75.198-62.013c.173-.277.411-.507.695-.67a1.902 1.902 0 0 1 1.869 0c.284.162.523.392.694.67a137.098 137.098 0 0 1 13.447 87.432zm-189.964 44.858a27.823 27.823 0 0 0 -27.293 33.255 27.83 27.83 0 0 0 21.862 21.865 27.824 27.824 0 0 0 33.251-27.296v-25.977a2.007 2.007 0 0 0 -1.904-1.904z" fill="#702af7"/></svg>
                    <div class="w-full text-lg font-semibold">Blazor</div>
                    <div class="w-full text-sm">Web development with C# AND Javascript.</div>
                </div>
            </Label>
        </Checkbox>
    </ListItem>
</List>
```

### OnChanged callback
The OnChanged callback is triggered whenever the checked value of the checkbox changes as shown in the example below.

```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Checkbox @bind-Value="_form.Checked1" LabelText="Callback checkbox" OnChanged="@((val) => _callVal = val)" ></Checkbox>
    <div class="text-sm">Callback value: @_callVal</div>
</div>
```