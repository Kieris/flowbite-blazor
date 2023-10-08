## Tabs

Use these responsive tabs components to create a secondary navigational hierarchy for your website or toggle content inside a container

The tabs component can be used either as an extra navigational hierarchy complementing the main navbar or you can also use it to change content inside a container just below the tabs.


### Setup
Import the Tabs namespaces from Flowbite.Blazor.Components.Tabs
```razor
    @using Flowbite.Blazor.Components.Tabs
```

### Default tabs
Use the following default tabs component example to show a list of content to show or use for navigation.

```razor
<TabControl>
    <TabItem Title="Profile">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Profile:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Settings">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Settings:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Users">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Users:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Dashboard">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Dashboard:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Disabled="true" Title="Disabled">
        <span slot="title" class="text-gray-400 dark:text-gray-500">Disabled</span>
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Disabled:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
</TabControl>
```


### Tabs with underline
Use this alternative tabs component style with an underline instead of a background when hovering and being active on a certain page or TabItem.

```razor
<TabControl TabStyle="TabStyles.Underline">
    <TabItem Title="Profile">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Profile:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Settings">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Settings:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Users">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Users:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Dashboard">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Dashboard:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Disabled="true" Title="Disabled">
        <span slot="title" class="text-gray-400 dark:text-gray-500">Disabled</span>
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Disabled:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
</TabControl>
```

    
### Pill tabs
If you want to use pills as a style for the tabs component you can do so by using this example.

```razor
<TabControl TabStyle="TabStyles.Pill">
    <TabItem Title="Profile">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Profile:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Settings">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Settings:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Users">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Users:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Dashboard">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Dashboard:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Disabled="true" Title="Disabled">
        <span slot="title" class="text-gray-400 dark:text-gray-500">Disabled</span>
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Disabled:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
</TabControl>
```
    
### Full width tabs
If you want to show the tabs on the full width relative to the parent element you can do so by using the full width tabs component example.

```razor
<TabControl TabStyle="TabStyles.Full">
    <TabItem Title="Profile">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Profile:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Settings">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Settings:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Users">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Users:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
    <TabItem Title="Dashboard">
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Dashboard:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
</TabControl>
```

    
### Tabs with icons
This is an example of the tabs component where you can also use a SVG powered icon to complement the text within the navigational tabs. Use the IconTitle fragment to define the content for the tab button and then put the content for the TabItem in the ChildContent fragment.

```razor
<TabControl TabStyle="TabStyles.Underline">
    <TabItem Title="Profile">
        <IconTitle>
            <div class="flex items-center gap-2">
                <UserCircleSolid class="h-4 w-4"/>
                Profile
            </div>
        </IconTitle>
        <ChildContent>
            <p class="text-sm text-gray-500 dark:text-gray-400">
                <b>Profile:</b>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
            </p>
        </ChildContent>
    </TabItem>
    <TabItem Title="Settings">
        <IconTitle>
            <div class="flex items-center gap-2">
                <AdjustmentsVerticalSolid class="h-4 w-4"/>
                Settings
            </div>
        </IconTitle>
        <ChildContent>
            <p class="text-sm text-gray-500 dark:text-gray-400">
                <b>Settings:</b>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
            </p>
        </ChildContent>
    </TabItem>
    <TabItem Title="Contacts">
        <IconTitle>
            <div class="flex items-center gap-2">
                <ClipboardSolid class="h-4 w-4"/>
                Contacts
            </div>
        </IconTitle>
        <ChildContent>
            <p class="text-sm text-gray-500 dark:text-gray-400">
                <b>Contacts:</b>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
            </p>
        </ChildContent>
    </TabItem>
    <TabItem Title="Dashboard">
        <IconTitle>
            <div class="flex items-center gap-2">
                <GridSolid class="h-4 w-4"/>
                Dashboard
            </div>
        </IconTitle>
        <ChildContent>
            <p class="text-sm text-gray-500 dark:text-gray-400">
                <b>Dashboard:</b>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
            </p>
        </ChildContent>
    </TabItem>
    <TabItem Disabled="true" Title="Disabled">
        <span slot="title" class="text-gray-400 dark:text-gray-500">Disabled</span>
        <p class="text-sm text-gray-500 dark:text-gray-400">
            <b>Disabled:</b>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        </p>
    </TabItem>
</TabControl>
```
   
### Tab button sizes
The size of the tab buttons can be modifed by setting the BtnSizeClass as shown below.

```razor
<TabControl BtnSizeClass="p-1 text-xs sm:p-2 sm:text-sm md:p-3 md:text-base" TabsToSelectOnSmall="false">
    <TabItem Title="Profile" />
    <TabItem Title="Settings" />
    <TabItem Title="Users" />
    <TabItem Title="Dashboard"/>
</TabControl>
<TabControl BtnSizeClass="p-1 text-xs" TabsToSelectOnSmall="false">
    <TabItem Title="Profile" />
    <TabItem Title="Settings" />
    <TabItem Title="Users" />
    <TabItem Title="Dashboard"/>
</TabControl>
<TabControl BtnSizeClass="py-1 px-3 text-xs" TabsToSelectOnSmall="false">
    <TabItem Title="Profile" />
    <TabItem Title="Settings" />
    <TabItem Title="Users" />
    <TabItem Title="Dashboard"/>
</TabControl>
```

### Tab navigation
Tabs can be used for navigation like for a Blazor layout. Simply add the url to each TabItem and give it no content. The body of the layout could be under the tabs.

```razor
<TabControl>
    <TabItem Title="Tabs" href="/docs/components/tabs"/>
    <TabItem Title="Alerts" href="/docs/components/alert"/>
    <TabItem Title="Home" href="/"/>
    <TabItem Title="Flowbite" href="https://flowbite.com"/>
</TabControl>
<!--Layout @@Body goes here -->
```

### Sample programmatic interaction

Tab can be activated by using title or index. Tabs can be added dynamically. The currently active page is accessible and when a tab changes, an event passing the title of the active tab is triggered.

```razor
<TabControl @ref=@_tabs TabChanged="@IncrementCount">
    <TabItem Title="Contacts" />
    <TabItem Title="Dashboard" />
    <TabItem Title="Home" />
</TabControl>
<div class="flex flex-wrap items-center justify-center gap-2">
    <Button OnClick=@(() => _tabs.ActivateByTitle("Contacts"))>Activate Contacts</Button>
    <Button OnClick=@(() => _tabs.ActivateByTitle("Dashboard"))>Activate Dashboard</Button>
    <Button OnClick=@(() => _tabs.ActivateByTitle("Home"))>Activate Home</Button>
    <Button OnClick=@(() => _tabs.ActivateByIndex(1))>Activate Tab 2</Button>
    <Button OnClick=@(() => _tabs.AddPage(_item))>Add New Tab</Button>
</div>
<div class="my-2">
    @_tabs?.ActivePage?.Title
</div>
<div class="my-2">
    Active page changed @_count times
</div>
```

```csharp
    private TabControl _tabs = new();
    private TabItem _item = new TabItem() { Title = "New Tab", Href = "https://flowbite.com" };
    private int _count;

    private void IncrementCount(string title)
    {
        _count++;
    }
```