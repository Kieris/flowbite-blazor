
## Dropdown

#### Get started with the dropdown component to show a list of menu items when clicking on the trigger element based on multiple layouts, styles, and placements

#### The dropdown component can be used to show a list of menu items when clicking on an element such as a button and hiding it when focusing outside of the triggering element.
    
### Setup
#### Import the dropdown namespace from Flowbite.Blazor.Components.Dropdown. Dropdowns also require popper.js, so you need to either import the packaged    version or another version of popper into the _Layout.cshtml (.NET 7.0 Blazor Server) or index.html (.NET 7.0 Blazor WASM).

    
```razor
@using Flowbite.Blazor.Components.Dropdown
```
```html    
<script type=\"text/javascript\" src=\"_content/Flowbite.Blazor/js/popper.js\"></script>
```

### Default dropdown
#### Dropdowns will show under the trigger or above the trigger depending on how far it is from the top or bottom of the page.

```razor
<Dropdown>
    <DropdownTrigger>
        <Button>
            <div class="flex items-center font-semibold">
                Dropdown button
                <ChevronDownSolid class="w-3 h-3 ml-2"></ChevronDownSolid>
            </div>
        </Button>
    </DropdownTrigger>
    <DropdownItems>
        <DropdownItem href="#">Dashboard</DropdownItem>
        <DropdownItem href="#">Settings</DropdownItem>
        <DropdownItem href="#">Earnings</DropdownItem>
        <DropdownItem href="#">Sign out</DropdownItem>
    </DropdownItems>
</Dropdown>
```

### Hover dropdown
#### Set the Trigger="hover" on the Dropdown to make it open on hover instead of click. There’s a 300ms default delay when showing or hiding the dropdown due to UI/UX reasons and how it may affect the interaction with other components on the page. Generally, we recommend using the click method.

```razor
<Dropdown Trigger="hover">
    <DropdownTrigger>
        <Button>
            <div class="flex items-center font-semibold">
                Dropdown hover
                <ChevronDownSolid class="w-3 h-3 ml-2"></ChevronDownSolid>
            </div>
        </Button>
    </DropdownTrigger>
    <DropdownItems>
        <DropdownItem href="#">Dashboard</DropdownItem>
        <DropdownItem href="#">Settings</DropdownItem>
        <DropdownItem href="#">Earnings</DropdownItem>
        <DropdownItem href="#">Sign out</DropdownItem>
    </DropdownItems>
</Dropdown>
```


### Dropdown divider
#### Dividers can be added to the dropdown simply by defining multiple DropdownItems inside the DropdownWrapper.

```razor
<Dropdown>
    <DropdownTrigger>
        <Button>
            <div class="flex items-center font-semibold">
                Dropdown button
                <ChevronDownSolid class="w-3 h-3 ml-2"></ChevronDownSolid>
            </div>
        </Button>
    </DropdownTrigger>
    <DropdownItems>
        <DropdownItem href="#">Dashboard</DropdownItem>
        <DropdownDivider></DropdownDivider>
        <DropdownItem href="#">Settings</DropdownItem>
        <DropdownDivider></DropdownDivider>
        <DropdownItem href="#">Earnings</DropdownItem>
        <DropdownItem href="#">Sign out</DropdownItem>
    </DropdownItems>
</Dropdown>
```


    
### Dropdown header
#### Use this example to show extra information in a header and/or footer outside of the list of menu items inside the dropdown.
    
```razor
<Dropdown>
    <DropdownTrigger>
        <Button>
            <div class="flex items-center font-semibold">
                Dropdown button
                <ChevronDownSolid class="w-3 h-3 ml-2"></ChevronDownSolid>
            </div>
        </Button>
    </DropdownTrigger>
    <Header>
        <div class="block px-4 font-semibold">Dropdown Header</div>
    </Header>
    <DropdownItems>
        <DropdownItem href="#">Dashboard</DropdownItem>
        <DropdownItem href="#">Settings</DropdownItem>
        <DropdownItem href="#">Earnings</DropdownItem>
        <DropdownItem href="#">Sign out</DropdownItem>
    </DropdownItems>
    <Footer>
        <div class="block px-4 font-semibold">help@flowbite.com</div>
    </Footer>
</Dropdown>
```
    
### Multilevel dropdown
#### Use this example to enable multi-level dropdown menus by adding stacked elements inside of each other. Take notice of the MatchWidth and Nested     parameters of Dropdown and DropdownItem. These help with the placement of nested dropdowns. MatchWidth by default is true, and it makes the dropdown the same width as it's trigger.

```razor
<Dropdown MatchWidth="false">
    <DropdownTrigger>
        <Button>
            <div class="flex items-center font-semibold">
                Dropdown button
                <ChevronDownSolid class="w-3 h-3 ml-2"></ChevronDownSolid>
            </div>
        </Button>
    </DropdownTrigger>
    <DropdownItems>
        <DropdownItem href="#">Dashboard</DropdownItem>
        <DropdownItem href="#">Settings</DropdownItem>
        <DropdownItem Nested="true">
            <Dropdown Placement="Positions.RightStart" Class="w-full">
                <DropdownTrigger>
                    <button type="button" class="flex items-center justify-between w-full">
                        Dropdown on click
                        <ChevronRightSolid class="w-3 h-3 mx-2"></ChevronRightSolid>
                    </button>
                </DropdownTrigger>
                <DropdownItems>
                    <DropdownItem href="#">Dashboard</DropdownItem>
                    <DropdownItem href="#">Settings</DropdownItem>
                    <DropdownItem href="#">Earnings</DropdownItem>
                    <DropdownItem href="#">Sign out</DropdownItem>
                </DropdownItems>
            </Dropdown>
        </DropdownItem>
        <DropdownItem Nested="true">
            <Dropdown Placement="Positions.RightStart" Trigger="hover" Class="w-full">
                <DropdownTrigger >
                    <button type="button" class="flex items-center justify-between w-full">
                        Dropdown on hover
                        <ChevronRightSolid class="w-3 h-3 mx-2"></ChevronRightSolid>
                    </button>
                </DropdownTrigger>
                <DropdownItems>
                    <DropdownItem href="#">Dashboard</DropdownItem>
                    <DropdownItem href="#">Settings</DropdownItem>
                    <DropdownItem href="#">Earnings</DropdownItem>
                    <DropdownItem href="#">Sign out</DropdownItem>
                </DropdownItems>
            </Dropdown>
        </DropdownItem>
        <DropdownItem href="#">Sign out</DropdownItem>
    </DropdownItems>
</Dropdown>
```      
