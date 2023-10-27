## Blazor Checkbox - Flowbite Tailwind
Get started with the checkbox component to allow the user to select one or more options in the form of a square box available in multiple sizes and colors

The checkbox component can be used to receive one or more selected options from the user in the form of a square box available in multiple styles, sizes, colors, and variants coded with the utility classes from Tailwind CSS and with support for dark mode.

The FormCheckbox version of the checkbox can only be used inside an EditForm, and it includes validation. The version for outside EditForm is in Flowbite.Blazor.Inputs.

### Setup
Import the form components from Flowbite.Blazor.Forms
```razor
@using Flowbite.Blazor.Forms
```

### Checkbox example
Use this default example of a checkbox element in a checked and unchecked state. The label will be the DisplayAtttribute Name if LabelText is not defined.

#### With validation
```razor
<EditForm Model="@_form">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <FormCheckbox @bind-Value="_form.Checked1" LabelText="Default checkbox"></FormCheckbox>
        <div>Default: @_form.Checked1</div>
        <FormCheckbox @bind-Value="_form.Checked2"></FormCheckbox>
        <div>Checked: @_form.Checked2</div>
    </div>
</EditForm>
```
#### Without validation
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Checkbox Checked="@_form.Checked1" OnChanged="@((val) => _form.Checked1 = val)"
                LabelText="Default checkbox"/>
    <div>Default: @_form.Checked1</div>
    <!-- With label, description, or placeholder from attribute -->
    <Checkbox Checked="@_form.Checked2" OnChanged="@((val) => _form.Checked2 = val)"
                AttributeField="Checked2" AttributeModel="@_form"/>
    <div>Checked: @_form.Checked2</div>
</div>
```

```csharp
@code {
    TestFormCheckboxModel _form = new();
} 

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

#### With validation
```razor
<EditForm Model="@_form2" >
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <FormCheckbox Class="mb-2" @bind-Value="_form2.Checked1" LabelText="Disabled checkbox" Disabled></FormCheckbox>
    <FormCheckbox @bind-Value="_form2.Checked2" LabelText="Disabled checked" Disabled></FormCheckbox>
</EditForm>
```
#### Without validation
```razor
<Checkbox Class="mb-2" Checked="_form2.Checked1" LabelText="Disabled checkbox" Disabled></Checkbox>
<Checkbox Checked="_form2.Checked2" LabelText="Disabled checked" Disabled></Checkbox>
```

### Checkbox link
Use this example if you want to add an anchor link inside the label of the checkbox component.

#### With validation
```razor
<EditForm Model="@_form" >
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <FormCheckbox @bind-Value="_form.Checked1">
        <Label>
            <span class="text-sm font-medium text-neutral-900 dark:text-neutral-300">I agree with the <Anchor href="#">terms and conditions</Anchor>.</span>
        </Label>
    </FormCheckbox>
</EditForm>
```
#### Without validation
```razor
<Checkbox Checked="_form.Checked1" OnChanged="@((val) => _form.Checked1 = val)">
    <Label>
        <span class="text-sm font-medium text-neutral-900 dark:text-neutral-300">I agree with the <Anchor href="#">terms and conditions</Anchor>.</span>
    </Label>
</Checkbox>
```
    
    
### Helper text
Get started with this example if you want to add a secondary helper text for the checkbox component.

#### With validation
```razor
<EditForm Model="@_form" >
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <!-- Default -->
        <FormCheckbox @bind-Value="_form.Checked1" DescriptionText="For orders shipped from $25 in books or $29 in other categories"
                    LabelText="Free shipping via Flowbite">
        </FormCheckbox>
        <!--Using fragments -->
        <FormCheckbox @bind-Value="_form.Checked1">
            <Label>
                <span class="text-sm font-medium text-neutral-900 dark:text-neutral-300">Custom label and helper text</span>
            </Label>
            <Description>
                <div class="text-xs font-normal text-neutral-500 dark:text-neutral-300 pl-7">For orders shipped from $25 in books or $29 in other categories</div>
            </Description>
        </FormCheckbox>
    </div>
</EditForm>
```
#### Without validation
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <!-- Default -->
    <Checkbox Checked="_form.Checked1" OnChanged="@((val) => _form.Checked1 = val)" LabelText="Free shipping via Flowbite"
                DescriptionText="For orders shipped from $25 in books or $29 in other categories">
    </Checkbox>
    <!--Using fragments -->
    <Checkbox Checked="_form.Checked2" OnChanged="@((val) => _form.Checked2 = val)">
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

#### With validation        
```razor
<EditForm Model="@_form3" >
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <FormCheckbox @bind-Value="_form3.Checked1" LabelText="Default checkbox" Bordered></FormCheckbox>
        <FormCheckbox @bind-Value="_form3.Checked2" LabelText="Checked state" Bordered RoundedClass="rounded-lg"></FormCheckbox>
    </div>
    <FormCheckbox @bind-Value="_form2.Checked1" Bordered DescriptionText="For orders shipped from $25 in books or $29 in other categories"
                LabelText="Free shipping via Flowbite">
    </FormCheckbox>
</EditForm>
```
#### Without validation
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Checkbox Checked="_form3.Checked1" OnChanged="@((val) => _form3.Checked1 = val)" LabelText="Default checkbox" Bordered></Checkbox>
    <Checkbox Checked="_form3.Checked2" OnChanged="@((val) => _form3.Checked2 = val)" LabelText="Checked state" Bordered RoundedClass="rounded-lg"></Checkbox>
</div>
<Checkbox Checked="_form2.Checked1" OnChanged="@((val) => _form2.Checked1 = val)" Bordered DescriptionText="For orders shipped from $25 in books or $29 in other categories"
            LabelText="Free shipping via Flowbite">
</Checkbox>
```
    
### Checkbox list group
This example can be used to show a list of checkboxes inside a grouped list.
#### With validation
```razor
<EditForm Model="@listBoxes">
    <ListGroup Class="w-48">
        @foreach (CheckboxLabelModel item in listBoxes)
        {
            <ListGroupItem Class="py-3">
                <FormCheckbox @bind-Value="@item.Checked" LabelText="@item.Label"></FormCheckbox>
            </ListGroupItem>
        }
    </ListGroup>
</EditForm>
```
#### Without validation
```razor
<ListGroup Class="w-48">
    @foreach (CheckboxLabelModel item in listBoxes)
    {
        <ListGroupItem Class="py-3">
            <Checkbox Checked="@item.Checked" LabelText="@item.Label" OnChanged="@((val) => item.Checked = val)" />
        </ListGroupItem>
    }
</ListGroup>
```

```razor
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

#### With validation
```razor
<EditForm Model="@listBoxes">
    <ListGroup Horizontal>
        @foreach (CheckboxLabelModel item in listBoxes)
        {
            <ListGroupItem Class="py-3">
                <FormCheckbox @bind-Value="@item.Checked" LabelText="@item.Label"></FormCheckbox>
            </ListGroupItem>
        }
    </ListGroup>
</EditForm>
```

#### Without validation
```razor
<ListGroup Horizontal>
    @foreach (CheckboxLabelModel item in listBoxes)
    {
        <ListGroupItem Class="py-3">
            <Checkbox Checked="@item.Checked" LabelText="@item.Label" OnChanged="@((val) => item.Checked = val)"/>
        </ListGroupItem>
    }
</ListGroup>
```

### Checkbox dropdown
Use this example to show a list of checkbox items inside a dropdown menu. Importing popper.js and Flowbite.Blazor.Components.Dropdown is required for the dropdown.

#### With validation            
```razor
<div class="flex justify-center">
    <EditForm Model="@listBoxes">
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
                @foreach (CheckboxLabelModel item in listBoxes)
                {
                    <DropdownItem>
                        <FormCheckbox @bind-Value="@item.Checked" LabelText="@item.Label"></FormCheckbox>
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
    </EditForm>
</div>
```

#### Without validation
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
                    <input type="text" id="input-group-search2" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-600 dark:border-gray-500 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Search user">
                </div>
            </div>
        </Header>
        <DropdownItems>
            @foreach (CheckboxLabelModel item in listBoxes)
            {
                <DropdownItem>
                    <Checkbox Checked="@item.Checked" LabelText="@item.Label" OnChanged="@((val) => item.Checked = val)"/>
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

#### With validation
```razor
<EditForm Model="@listBoxes">
    <List class="flex flex-wrap items-center">
        @foreach (CheckboxLabelModel item in listBoxes)
        {
            <ListItem>
                <FormCheckbox Class="px-4" @bind-Value="@item.Checked" LabelText="@item.Label"></FormCheckbox>
            </ListItem>
        }
    </List>
</EditForm>
```

#### Without validation
```razor
<List class="flex flex-wrap items-center">
    @foreach (CheckboxLabelModel item in listBoxes)
    {
        <ListItem>
            <Checkbox Class="px-4" Checked="@item.Checked" LabelText="@item.Label" OnChanged="@((val) => item.Checked = val)" />
        </ListItem>
    }
</List>
```
    
### Colors
                            
Use the Color parameter to change the color of the checkbox component.
        
#### With validation
```razor
<EditForm Model="@listBoxes">
    <List class="flex flex-wrap items-center">
        @foreach (CheckboxLabelColorModel item in _colors)
        {
            <ListItem>
                <FormCheckbox Class="px-4" Color="@item.Color" @bind-Value="@item.Checked" LabelText="@item.Label"></FormCheckbox>
            </ListItem>
        }
    </List>
</EditForm>
```

#### Without validation
```razor
<List class="flex flex-wrap items-center">
    @foreach (CheckboxLabelColorModel item in _colors)
    {
        <ListItem>
            <Checkbox Class="px-4" Color="@item.Color" Checked="@item.Checked" LabelText="@item.Label" 
                        OnChanged="@((val) => item.Checked = val)" />
        </ListItem>
    }
</List>
```
```razor
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

#### With Validation
```razor
<EditForm Model="@_form">
    <List class="flex flex-wrap items-center">
        <ListItem>
            <!-- Default -->
            <FormCheckbox Class="px-4" @bind-Value="@_form.Checked1" Advanced="true">
                <Label>
                    <div class="block w-48">
                        <!--React Icon -->
                        <svg class="mb-2 w-7 h-7 text-sky-500"</svg>
                        <div class="w-full text-lg font-semibold">React Js</div>
                        <div class="w-full text-sm">A JavaScript library for building user interfaces.</div>
                    </div>
                </Label>
            </FormCheckbox>
        </ListItem>
        <ListItem>
            <!-- Setting advanced class -->
            <FormCheckbox Class="px-4" @bind-Value="@_form.Checked2" Advanced="true"
                            AdvancedClass="@($"inline-flex items-center justify-between w-full p-5 text-neutral-500 bg-white border-2 border-neutral-200 rounded-lg cursor-pointer dark:hover:text-neutral-300 dark:border-neutral-700 peer-checked:border-indigo-600 hover:text-neutral-600 dark:peer-checked:text-neutral-300 peer-checked:text-neutral-600 hover:bg-neutral-50 dark:text-neutral-400 dark:bg-neutral-800 dark:hover:bg-neutral-700")">
                <Label>
                    <div class="block w-48">
                        <!--Blazor Icon -->
                        <svg fill="none" class="mb-2 w-7 h-7" </svg>
                        <div class="w-full text-lg font-semibold">Blazor</div>
                        <div class="w-full text-sm">Web development with C# AND Javascript.</div>
                    </div>
                </Label>
            </FormCheckbox>
        </ListItem>
    </List>
</EditForm>
```

#### Without Validation 
```razor
<List class="flex flex-wrap items-center">
    <ListItem>
        <!-- Default -->
        <Checkbox Class="px-4" Checked="@_form.Checked1" Advanced="true"
                    OnChanged="@((val) => _form.Checked1= val)">
            <Label>
                <div class="block w-48">
                     <!--React icon-->
                    <svg fill="none" class="mb-2 w-7 h-7">
                    <svg class="mb-2 w-7 h-7 text-sky-500" </svg>
                    <div class="w-full text-lg font-semibold">React Js</div>
                    <div class="w-full text-sm">A JavaScript library for building user interfaces.</div>
                </div>
            </Label>
        </Checkbox>
    </ListItem>
    <ListItem>
        <!-- Setting advanced class -->
        <Checkbox Class="px-4" Checked="@_form.Checked2" Advanced="true"
                        OnChanged="@((val) => _form.Checked2 = val)" AdvancedClass="@($"inline-flex items-center justify-between w-full p-5 text-neutral-500 bg-white border-2 border-neutral-200 rounded-lg cursor-pointer dark:hover:text-neutral-300 dark:border-neutral-700 peer-checked:border-indigo-600 hover:text-neutral-600 dark:peer-checked:text-neutral-300 peer-checked:text-neutral-600 hover:bg-neutral-50 dark:text-neutral-400 dark:bg-neutral-800 dark:hover:bg-neutral-700")">
            <Label>
                <div class="block w-48">
                    <!--Blazor icon-->
                    <svg fill="none" class="mb-2 w-7 h-7">
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
<EditForm Model="@_form" >
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <FormCheckbox @bind-Value="_form.Checked1" LabelText="Callback checkbox" OnChanged="@((val) => _callVal = val)" ></FormCheckbox>
        <div class="text-sm">Callback value: @_callVal</div>
    </div>
</EditForm>
```
