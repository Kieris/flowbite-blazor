## Blazor Search Input - Flowbite Tailwind
Use the search input component as a text field to allow users to enter search queries and receive relevant page results available in multiple styles and sizes

The search input component can be used to let your users search through your website using string queries and it comes in multiple styles, variants, and sizes built with the utility classes from Tailwind CSS.

You will also find more advanced search components on this page including dropdown category selections, search buttons positioned inside the input field, voice search fields and more.
    
### Setup
Import the form components from Flowbite.Blazor.Forms

```razor
@using Flowbite.Blazor.Forms
```

### Search bar example
Get started with the default example of a search input component including and icon and submit button.
    
```razor
<SearchInput @bind-Value="@_searchText" GroupType="InputGroupTypes.Left" Placeholder="Search Markups, Logos..." CustomSize="p-4">
    <Icon>
        <SearchOutline class="w-4 h-4 text-neutral-500 dark:text-neutral-400"></SearchOutline>
    </Icon>
    <SearchButton>
        <button type="submit" class="text-white absolute right-2.5 bottom-2.5 bg-primary-700 hover:bg-primary-800 focus:ring-4 focus:outline-none focus:ring-primary-300 font-medium rounded-lg text-sm px-4 py-2 dark:bg-primary-600 dark:hover:bg-primary-700 dark:focus:ring-primary-800">Search</button>
    </SearchButton>
</SearchInput>
```

### Search with dropdown
Use this search component with a dropdown to let your users select a category in which they would like the search query to be targeted in.

```razor
<label for="dropdown-search" class="block mb-2 text-sm font-medium text-neutral-900 dark:text-white">
    With dropdown
</label>
<div class="flex w-full">
    <Dropdown>
        <DropdownTrigger>
            <button id="dropdown-button" data-dropdown-toggle="dropdown" class="flex-shrink-0 z-10 inline-flex items-center py-2.5 px-4 text-sm font-medium text-center text-neutral-900 bg-neutral-100 border border-neutral-300 rounded-l-lg hover:bg-neutral-200 focus:ring-4 focus:outline-none focus:ring-neutral-100 dark:bg-neutral-700 dark:hover:bg-neutral-600 dark:focus:ring-neutral-700 dark:text-white dark:border-neutral-600" type="button">
                All categories
                <ChevronDownSolid class="w-2.5 h-2.5 ml-2.5"></ChevronDownSolid>
            </button>
        </DropdownTrigger>
        <DropdownItems>
            <DropdownItem>
                Mockups
            </DropdownItem>
            <DropdownItem>
                Templates
            </DropdownItem>
            <DropdownItem>
                Designs
            </DropdownItem>
            <DropdownItem>
                Logos
            </DropdownItem>
        </DropdownItems>
    </Dropdown>
    <SearchInput Class="flex-1" Id="dropdown-search" @bind-Value="@_searchText" GroupType="InputGroupTypes.RightWithBg"
                    RoundedClass="w-full rounded-l-none rounded-r-none border-l-2"
                    Placeholder="Search Markups, Logos...">
        <SearchButton>
            <Button type="submit" class="rounded-l-none" Size="Sizes.Icon">
                <SearchOutline class="w-4 h-4"></SearchOutline>
            </Button>
        </SearchButton>
    </SearchInput>
</div>
```

### Simple search input
Use the simplest form of a search input component with an icon and a search button next to the text field.

```razor
<div class="flex w-full">
    <SearchInput Class="flex-1" Spacing="mb-0" @bind-Value="@_searchText" GroupType="InputGroupTypes.Left" Placeholder="Search branch name...">
        <Icon>
            <CodeBranchOutline class="w-4 h-4 text-neutral-500 dark:text-neutral-400"></CodeBranchOutline>
        </Icon>
    </SearchInput>
    <Button type="submit" Size="Sizes.Icon" Class="ml-2">
        <SearchOutline class="w-4 h-4"></SearchOutline>
    </Button>
</div>
```

### Voice search
Get started with this example if you would like to enable voice search for your website and users.
        
```razor
<div class="flex w-full">
    <SearchInput Class="flex-1" Spacing="mb-0" @bind-Value="@_searchText" GroupType="InputGroupTypes.Left" Placeholder="Search Mockups, Logos, Design Templates...">
        <Icon>
            <PaletteOutline class="w-4 h-4 text-neutral-500 dark:text-neutral-400"></PaletteOutline>
        </Icon>
        <SearchButton>
            <button type="button" class="absolute inset-y-0 right-0 flex items-center pr-3">
                <MicrophoneOutline class="w-4 h-4 text-gray-500 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white"></MicrophoneOutline>
            </button>
        </SearchButton>
    </SearchInput>
    <Button type="submit" Class="ml-2">
        <SearchOutline class="w-4 h-4 mr-2"></SearchOutline>
        Search
    </Button>
</div>
```
    
### OnChanged callback
Get started with the default example of a search input component including and icon and submit button.

```razor
<SearchInput @bind-Value="@_searchText" OnChanged="((val) => _callVal = val)" GroupType="InputGroupTypes.Left" Placeholder="Search Markups, Logos..." CustomSize="p-4">
    <Icon>
        <SearchOutline class="w-4 h-4 text-neutral-500 dark:text-neutral-400"></SearchOutline>
    </Icon>
    <SearchButton>
        <button type="submit" class="text-white absolute right-2.5 bottom-2.5 bg-primary-700 hover:bg-primary-800 focus:ring-4 focus:outline-none focus:ring-primary-300 font-medium rounded-lg text-sm px-4 py-2 dark:bg-primary-600 dark:hover:bg-primary-700 dark:focus:ring-primary-800">Search</button>
    </SearchButton>
</SearchInput>
<Paragraph>Value: @_searchText</Paragraph>
<Paragraph>Callback return: @_callVal</Paragraph>
```