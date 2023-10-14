## Blazor Navbar - Flowbite
    
The navbar component can be used to show a list of navigation links positioned on the top side of your page based on multiple layouts, sizes, and dropdowns

Get started with the responsive navbar component from Flowbite to quickly set up a navigation menu for your website and set up the logo, list of pages, CTA button, search input, user profile options with a dropdown, and more.
  

### Setup
Import the Navbar namespace from Flowbite.Blazor.Components.Navbar
```razor
@using Flowbite.Blazor.Components.Drawer
```

### Default navbar
Use this example of a navigation bar built with the utility classes from Tailwind CSS to enable users to navigate across the pages of your website.

    
```razor
<Navbar>
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <NavHamburger  />
    <NavUl >
        <NavLi href="/">Home</NavLi>
        <NavLi href="/about">About</NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```

### Active class
Use this example of a navigation bar built with the utility classes from Tailwind CSS to enable users to navigate across the pages of your website.

```razor
<Navbar>
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <NavHamburger  />
    <NavUl ActiveClass="text-white bg-green-700 md:bg-transparent md:text-green-700 md:dark:text-white dark:bg-green-600 md:dark:bg-transparent"
            InactiveClass="text-gray-700 hover:bg-gray-100 md:hover:bg-transparent md:border-0 md:hover:text-green-700 dark:text-gray-400 md:dark:hover:text-white dark:hover:bg-gray-700 dark:hover:text-white md:dark:hover:bg-transparent">
        <NavLi href="/">Home</NavLi>
        <NavLi href="/about">About</NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```

### Navbar container
If you need more control of navbar content, style it with Class and ContainerClass parameters.

```razor
<Navbar Class="bg-primary-100 dark:bg-primary-800" ContainerClass="border px-5 py-2 rounded-lg bg-white dark:bg-gray-600">
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <NavHamburger  />
    <NavUl >
        <NavLi href="/">Home</NavLi>
        <NavLi href="/about">About</NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```
    
### Navbar with dropdown
This example can be used to show a secondary dropdown menu when clicking on one of the navigation links.

```razor
<Navbar>
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <NavHamburger  />
    <NavUl >
        <NavLi href="/">Home</NavLi>
        <NavLi Class="cursor-pointer">
            <Dropdown Placement="Positions.Bottom" ItemsClass="text-neutral-700 dark:text-neutral-200">
                <DropdownTrigger>
                    <div class="flex items-center">
                        Dropdown
                        <ChevronDownSolid class="w-3 h-3 ml-2"></ChevronDownSolid>
                    </div>
                </DropdownTrigger>
                <DropdownItems>
                    <DropdownItem href="#">Dashboard</DropdownItem>
                    <DropdownItem href="#">Settings</DropdownItem>
                    <DropdownItem href="#">Earnings</DropdownItem>
                    <DropdownItem href="#">Sign out</DropdownItem>
                </DropdownItems>
            </Dropdown>
        </NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```

### Multi-level dropdown
Use this example to show multiple layers of dropdown menu by stacking them inside of each other.

```razor
<Navbar>
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <NavHamburger  />
    <NavUl >
        <NavLi href="/">Home</NavLi>
        <NavLi Class="cursor-pointer">
            <Dropdown Placement="Positions.Bottom" ItemsClass="text-neutral-700 dark:text-neutral-200">
                <DropdownTrigger>
                    <div class="flex items-center">
                        Dropdown
                        <ChevronDownSolid class="w-3 h-3 ml-2"></ChevronDownSolid>
                    </div>
                </DropdownTrigger>
                <DropdownItems>
                    <DropdownItem href="#">Dashboard</DropdownItem>
                    <DropdownItem href="#">Settings</DropdownItem>
                    <DropdownItem Nested="true">
                        <Dropdown Placement="Positions.RightStart" Class="w-full">
                            <DropdownTrigger>
                                <button type="button" class="flex items-center justify-between w-full">
                                    Dropdown
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
                    <DropdownItem href="#">Earnings</DropdownItem>
                    <DropdownItem href="#">Sign out</DropdownItem>
                </DropdownItems>
            </Dropdown>
        </NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```


### Navbar with search
Use this example of a navbar element to also show a search input element that you can integrate for a site-wide search.

```razor
<Navbar>
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <div class="flex md:order-2">
        <button type="button" class="md:hidden text-gray-500 dark:text-gray-400 hover:bg-gray-100 dark:hover:bg-gray-700 focus:outline-none focus:ring-4 focus:ring-gray-200 dark:focus:ring-gray-700 rounded-lg text-sm p-2.5 mr-1" >
            <SearchOutline class="w-5 h-5" />
            <span class="sr-only">Search</span>
        </button>
        <div class="relative hidden md:block">
            <div class="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
                <SearchOutline class="w-4 h-4 text-gray-500 dark:text-gray-400" />
                <span class="sr-only">Search icon</span>
            </div>
            <input type="text" id="search-navbar" class="block w-full p-2 pl-10 text-sm text-gray-900 border border-gray-300 rounded-lg bg-gray-50 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Search...">
        </div>
        <NavHamburger />
    </div>
    <NavUl >
        <NavLi href="/">Home</NavLi>
        <NavLi href="/about">About</NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```


### Navbar with CTA button
Use the following navbar element to show a call to action button alongside the logo and page links.
    
```razor
<Navbar>
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <div class="flex md:order-2">
        <Button Size="Sizes.Small" Class="mr-3 md:mr-0">Get started</Button>
        <NavHamburger />
    </div>
    <NavUl >
        <NavLi href="/">Home</NavLi>
        <NavLi href="/about">About</NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```

    
### User menu dropdown
Use this example to create a navigation bar with a user profile or button to toggle a dropdown menu.
    
```razor
<Navbar>
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <div class="flex md:order-2">
        <Dropdown Placement="Positions.BottomEnd" ItemsClass="text-neutral-700 dark:text-neutral-200">
            <DropdownTrigger>
                <button type="button" class="flex mr-3 text-sm bg-gray-800 rounded-full md:mr-0 focus:ring-4 focus:ring-gray-300 dark:focus:ring-gray-600" id="user-menu-button" aria-expanded="false" data-dropdown-toggle="user-dropdown" data-dropdown-placement="bottom">
                    <span class="sr-only">Open user menu</span>
                    <img class="w-8 h-8 rounded-full" src="images/people/profile-picture-3.webp" alt="user photo">
                </button>
            </DropdownTrigger>
            <Header>
                <div class="px-4">
                    <span class="block text-sm">Bonnie Green</span>
                    <span class="block truncate text-sm font-medium">name@flowbite.com</span>
                </div>
            </Header>
            <DropdownItems>
                <DropdownDivider></DropdownDivider>
                <DropdownItem href="#">Dashboard</DropdownItem>
                <DropdownItem href="#">Settings</DropdownItem>
                <DropdownItem href="#">Earnings</DropdownItem>
                <DropdownItem href="#">Sign out</DropdownItem>
            </DropdownItems>
        </Dropdown>
            
        <NavHamburger />
    </div>
    <NavUl >
        <NavLi href="/">Home</NavLi>
        <NavLi href="/about">About</NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```



### Solid background
Use this example to show a solid background for the navbar component instead of being transparent.
   
```razor
<Navbar Class="border-gray-200 bg-gray-50 dark:bg-gray-800 dark:border-gray-700">
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <NavHamburger />
    <NavUl >
        <NavLi href="/">Home</NavLi>
        <NavLi href="/about">About</NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```
    
### Sticky navbar
Use this example to keep the navbar positioned fixed to the top side as you scroll down the document page.

```razor
<div class="relative px-4">
    <Navbar Class="px-2 sm:px-4 py-2.5 absolute bg-white dark:bg-neutral-900 w-full z-20 top-0 left-0 border-b border-gray-200 dark:border-gray-700">
        <NavBrand href="/">
            <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
            <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
        </NavBrand>
        <NavHamburger />
        <NavUl>
            <NavLi href="/">Home</NavLi>
            <NavLi href="/about">About</NavLi>
            <NavLi href="/docs/components/navbar">Navbar</NavLi>
            <NavLi href="/pricing">Pricing</NavLi>
            <NavLi href="/contact">Contact</NavLi>
        </NavUl>
    </Navbar>
    <div style="height:300px;" class="overflow-scroll pb-16">
        <Skeleton Class="mt-16 mb-8" />
        <ImagePlaceholder Class="my-8" />
        <TextPlaceholder Class="my-8" />
    </div>
</div>
```

### Always collapse menu
Use this example to keep the nav menu collapsible all the time.

```razor
<Navbar AlwaysCollapseMenu="true">
    <NavBrand href="/">
        <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
        <span class="self-center whitespace-nowrap text-xl font-semibold dark:text-white">Flowbite</span>
    </NavBrand>
    <NavHamburger />
    <NavUl>
        <NavLi href="/">Home</NavLi>
        <NavLi href="/about">About</NavLi>
        <NavLi href="/docs/components/navbar">Navbar</NavLi>
        <NavLi href="/pricing">Pricing</NavLi>
        <NavLi href="/contact">Contact</NavLi>
    </NavUl>
</Navbar>
```

### Flowbite Blazor customization
This example shows how you can customize the navbar.

```razor
<div class="relative px-4">
    <Navbar Fluid="true" Class="px-2 sm:px-4 py-2.5 absolute w-full bg-blazor z-50 top-0 left-0 border-b border-purple-400">
        <NavBrand href="/">
            <img src="/images/flowbite-icon-logo.svg" class="mr-3 h-6 sm:h-9" alt="Flowbite Logo" />
            <span class="self-center whitespace-nowrap text-xl font-semibold text-white">Flowbite Blazor</span>
        </NavBrand>
        <div class="flex md:order-2">
            <Button Size="Sizes.Icon" Color="Colors.None" Class="dark:hover:ring-1 rounded-lg dark:hover:ring-neutral-600">
                <SunSolid class="w-5 h-5 text-purple-300"></SunSolid>
            </Button>
            <NavHamburger BtnClass="hover:bg-purple-800" SvgClass="text-purple-300"/>
        </div>
        <NavUl ActiveClass="text-white bg-purple-500 md:bg-transparent md:text-purple-400"
                InactiveClass="text-purple-100 hover:bg-purple-400 md:hover:bg-transparent md:border-0 md:hover:text-purple-200"
                UlClass="font-medium flex flex-col p-4 mt-4 border border-purple-400 text-purple-200 rounded-lg md:flex-row md:space-x-8 md:mt-0 md:p-0 md:border-0">
            <NavLi href="/">Home</NavLi>
            <NavLi href="/docs/components/navbar">Navbar</NavLi>
            <NavLi href="/pricing">Pricing</NavLi>
            <NavLi href="/contact">Contact</NavLi>
        </NavUl>
    </Navbar>
    <div style="height:300px;" class="overflow-scroll pb-16">
        <Skeleton Class="mt-16 mb-8" />
        <ImagePlaceholder Class="my-8" />
        <TextPlaceholder Class="my-8" />
    </div>
</div>
```