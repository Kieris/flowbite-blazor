## Drawer
The Drawer component can be used as a hidden off-canvas sidebar for navigation and to show other information based on multiple styles and placements

Use the Drawer component (or “off-canvas”) to show a fixed element relative to the document page from any side for navigation, contact forms, informational purposes or other user actions.

  

### Setup
Import the Drawer namespace from Flowbite.Blazor.Components.Drawer
```razor
@using Flowbite.Blazor.Components.Drawer
```

### Default drawer
To initiate the drawer component you need to set a component reference and use it to Show() and Hide() the drawer.

```razor
<Button OnClick="@(() => _drawer.Show())">Open Drawer</Button>
<Drawer @ref=@_drawer>
    <DrawerHeader CloseClicked="(() => _drawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
```
```csharp
Drawer _drawer = new();
```
    
### Drawer navigation
Use this example to show a navigational sidebar inside the drawer component.

```razor
<Button OnClick="@(() => _drawerNav.Show())">Open Drawer</Button>
<Drawer @ref=@_drawerNav Class="bg-gray-100">
    <DrawerHeader CloseClicked="(() => _drawerNav.Hide())" Title="MENU">
        <!--No icon-->
        <Icon></Icon>
    </DrawerHeader>
    <Sidebar>
        <SidebarWrapper Class="bg-transparent">
            <SidebarGroup>
                <SidebarItem Label="Dashboard">
                    <Icon>
                        <ChartPieSolid class="w-5 h-5 text-gray-500 transition duration-75 dark:text-gray-400 group-hover:text-gray-900 dark:group-hover:text-white" />
                    </Icon>
                </SidebarItem>
                <SidebarDropdownWrapper Label="E-commerce">
                    <Icon>
                        <ShoppingCartSolid class="w-5 h-5 text-gray-500 transition duration-75 dark:text-gray-400 group-hover:text-gray-900 dark:group-hover:text-white" />
                    </Icon>
                    <Items>
                    <SidebarDropdownItem Label="Products" />
                    <SidebarDropdownItem Label="Billing" />
                    <SidebarDropdownItem Label="Invoice" />
                    </Items>
                </SidebarDropdownWrapper>
                <SidebarItem label="Kanban" Class="flex-1 whitespace-nowrap">
                    <Icon>
                        <GridSolid class="w-5 h-5 text-gray-500 transition duration-75 dark:text-gray-400 group-hover:text-gray-900 dark:group-hover:text-white" />
                    </Icon>
                    <Subtext>
                        <span class="inline-flex justify-center items-center px-2 ml-3 text-sm font-medium text-gray-800 bg-gray-200 rounded-full dark:bg-gray-700 dark:text-gray-300"> Pro </span>
                    </Subtext>
                </SidebarItem>
                <SidebarItem Label="Inbox" Class="flex-1 whitespace-nowrap">
                    <Icon>
                        <MailBoxSolid class="w-5 h-5 text-gray-500 transition duration-75 dark:text-gray-400 group-hover:text-gray-900 dark:group-hover:text-white" />
                    </Icon>
                    <Subtext>
                        <span class="inline-flex justify-center items-center p-3 ml-3 w-3 h-3 text-sm font-medium text-primary-600 bg-primary-200 rounded-full dark:bg-primary-900 dark:text-primary-200"> 3 </span>
                    </Subtext>
                </SidebarItem>
                <SidebarItem Label="Users">
                    <Icon>
                        <UsersSolid class="w-5 h-5 text-gray-500 transition duration-75 dark:text-gray-400 group-hover:text-gray-900 dark:group-hover:text-white" />
                    </Icon>
                </SidebarItem>
                <SidebarItem Label="Products">
                    <Icon>
                        <BagSolid class="w-5 h-5 text-gray-500 transition duration-75 dark:text-gray-400 group-hover:text-gray-900 dark:group-hover:text-white" />
                    </Icon>
                </SidebarItem>
                <SidebarItem Label="Sign In">
                    <Icon>
                        <ArrowRightToBracketSolid class="w-5 h-5 text-gray-500 transition duration-75 dark:text-gray-400 group-hover:text-gray-900 dark:group-hover:text-white" />
                    </Icon>
                </SidebarItem>
                <SidebarItem Label="Sign Up">
                    <Icon>
                        <FileEditSolid class="w-5 h-5 text-gray-500 transition duration-75 dark:text-gray-400 group-hover:text-gray-900 dark:group-hover:text-white" />
                    </Icon>
                </SidebarItem>
            </SidebarGroup>
        </SidebarWrapper>
    </Sidebar>
</Drawer>
```
```csharp
    Drawer _drawerNav = new();
```

### Contact form
Use this example to show a contact form inside the drawer component.

```razor
<Button OnClick="@(() => _ctdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_ctdrawer>
    <DrawerHeader CloseClicked="(() => _ctdrawer.Hide())" Title="CONTACT US">
        <Icon>
            <EnvelopeSolid class="w-4 h-4 mr-2.5"></EnvelopeSolid>
        </Icon>
    </DrawerHeader>
    <form action="#" class="mb-6">
        <div class="mb-6">
            <label for="email" class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Your email</label>
            <input type="email" id="email" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="name@company.com" required>
        </div>
        <div class="mb-6">
            <label for="subject" class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Subject</label>
            <input type="text" id="subject" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Let us know how we can help you" required>
        </div>
        <div class="mb-6">
            <label for="message" class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Your message</label>
            <textarea id="message" rows="4" class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Your message..."></textarea>
        </div>
        <button type="submit" class="text-white bg-blue-700 hover:bg-blue-800 w-full focus:ring-4 focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 mr-2 mb-2 dark:bg-blue-600 dark:hover:bg-blue-700 focus:outline-none dark:focus:ring-blue-800 block">Send message</button>
    </form>
    <p class="mb-2 text-sm text-gray-500 dark:text-gray-400">
        <a href="#" class="hover:underline">info@company.com</a>
    </p>
    <p class="text-sm text-gray-500 dark:text-gray-400">
        <a href="#" class="hover:underline">212-456-7890</a>
    </p>
</Drawer>
```
```csharp
Drawer _ctdrawer = new();
```
    
Form elements
Use this example if you want to add form elements inside the drawer component including datepickers.        
            
```razor
<Button OnClick="@(() => _evdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_evdrawer>
    <DrawerHeader CloseClicked="(() => _evdrawer.Hide())" Title="NEW EVENT">
        <Icon>
            <CalendarMonthSolid class="w-4 h-4 mr-2.5"></CalendarMonthSolid>
        </Icon>
    </DrawerHeader>
    <form action="#" class="mb-6">
        <div class="mb-6">
            <label for="title" class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Title</label>
            <input type="text" id="title" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Apple Keynote" required>
        </div>
        <div class="mb-6">
            <label for="description" class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Description</label>
            <textarea id="description" rows="4" class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Write event description..."></textarea>
        </div>
        <div class="relative mb-6">
            <div class="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
                <svg class="w-4 h-4 text-gray-500 dark:text-gray-400" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 20">
                    <path d="M20 4a2 2 0 0 0-2-2h-2V1a1 1 0 0 0-2 0v1h-3V1a1 1 0 0 0-2 0v1H6V1a1 1 0 0 0-2 0v1H2a2 2 0 0 0-2 2v2h20V4ZM0 18a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V8H0v10Zm5-8h10a1 1 0 0 1 0 2H5a1 1 0 0 1 0-2Z"/>
                </svg>
            </div>
            <input datepicker="" datepicker-autohide datepicker-buttons="" type="text" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500 datepicker-input" placeholder="Select date">
        </div>
        <div class="mb-4">
            <label for="guests" class="mb-2 text-sm font-medium text-gray-900 sr-only dark:text-white">Invite guests</label>
            <div class="relative">
                <input type="search" id="guests" class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Add guest email" required>
                <button type="button" class="absolute inline-flex items-center px-3 py-1 text-sm font-medium text-white bg-blue-700 rounded-lg right-2 bottom-2 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800"><svg class="w-3 h-3 mr-1.5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 18">
                    <path d="M6.5 9a4.5 4.5 0 1 0 0-9 4.5 4.5 0 0 0 0 9ZM8 10H5a5.006 5.006 0 0 0-5 5v2a1 1 0 0 0 1 1h11a1 1 0 0 0 1-1v-2a5.006 5.006 0 0 0-5-5Zm11-3h-2V5a1 1 0 0 0-2 0v2h-2a1 1 0 1 0 0 2h2v2a1 1 0 0 0 2 0V9h2a1 1 0 1 0 0-2Z"/>
                </svg>Add</button>
            </div>
        </div>
        <div class="flex mb-4 -space-x-4">
            <img class="w-8 h-8 border-2 border-white rounded-full dark:border-gray-800" src="images/people/profile-picture-5.webp" alt="">
            <img class="w-8 h-8 border-2 border-white rounded-full dark:border-gray-800" src="images/people/profile-picture-2.webp" alt="">
            <img class="w-8 h-8 border-2 border-white rounded-full dark:border-gray-800" src="images/people/profile-picture-3.webp" alt="">
            <img class="w-8 h-8 border-2 border-white rounded-full dark:border-gray-800" src="images/people/profile-picture-4.webp" alt="">
        </div>
        <button type="submit" class="text-white justify-center flex items-center bg-blue-700 hover:bg-blue-800 w-full focus:ring-4 focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 mr-2 mb-2 dark:bg-blue-600 dark:hover:bg-blue-700 focus:outline-none dark:focus:ring-blue-800"><svg class="w-3.5 h-3.5 mr-2.5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 20">
            <path d="M18 2h-2V1a1 1 0 0 0-2 0v1h-3V1a1 1 0 0 0-2 0v1H6V1a1 1 0 0 0-2 0v1H2a2 2 0 0 0-2 2v14a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V4a2 2 0 0 0-2-2ZM2 18V7h6.7l.4-.409A4.309 4.309 0 0 1 15.753 7H18v11H2Z"/>
            <path d="M8.139 10.411 5.289 13.3A1 1 0 0 0 5 14v2a1 1 0 0 0 1 1h2a1 1 0 0 0 .7-.288l2.886-2.851-3.447-3.45ZM14 8a2.463 2.463 0 0 0-3.484 0l-.971.983 3.468 3.468.987-.971A2.463 2.463 0 0 0 14 8Z"/>
        </svg> Create event</button>
    </form>
</Drawer>
```
```csharp
    Drawer _evdrawer = new();
```

### Placement
    
Use the Placement parameter to position the drawer component either on the top, right, bottom, or left side of the document page. The default placement is left.

### Left
    
```razor
<Button OnClick="@(() => _ldrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_ldrawer Placement="Placement.Left">
    <DrawerHeader CloseClicked="(() => _ldrawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
```
```csharp
Drawer _ldrawer = new();
```

### Right

```razor
<Button OnClick="@(() => _rdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_rdrawer Placement="Placement.Right">
    <DrawerHeader CloseClicked="(() => _rdrawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
```
```csharp
    Drawer _rdrawer = new();
```
### Top

```razor
<Button OnClick="@(() => _tdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_tdrawer Placement="Placement.Top">
    <DrawerHeader CloseClicked="(() => _tdrawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
```

```csharp
Drawer _tdrawer = new();
```

### Bottom

```razor
<Button OnClick="@(() => _bdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_bdrawer Placement="Placement.Bottom">
    <DrawerHeader CloseClicked="(() => _bdrawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
```
```csharp
Drawer _bdrawer = new();
```

### Offset Position
Use LeftOffset, RightOffset, TopOffset, or BottomOffset parameter to change the position and size of the drawer.

```razor
<Button OnClick="@(() => _offdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_offdrawer Placement="Placement.Left" LeftOffset="top-16 h-screen left-0 w-80">
    <DrawerHeader CloseClicked="(() => _offdrawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
```
```csharp
Drawer _offdrawer = new();
```

### Backdrop
The backdrop element can be used to dim out the background elements when the drawer is visible and also automatically hide the component when clicking outside of it.

Use Backdrop="false" to disable. The backdrop is enabled by default.

```razor
<Button OnClick="@(() => _nobdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_nobdrawer Backdrop="false">
    <DrawerHeader CloseClicked="(() => _nobdrawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
```
```csharp
Drawer _nobdrawer = new();
```

### No click outside to close
As the default, the drawer closes when you click the outside of the drawer, but sometimes you don’t want that. Set ClickOutsideClose to false to disable it.

```razor
<Button OnClick="@(() => _nocdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_nocdrawer ClickOutsideClose="false">
    <DrawerHeader CloseClicked="(() => _nocdrawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
```
```csharp
Drawer _nocdrawer = new();
```

### Absolute positioning
Use this example to set positioning to absolute and keep the drawer inside an element.
```razor
<div class="h-96 relative">
<Button OnClick="@(() => _abdrawer.Show())">Open Drawer</Button>
<Drawer @ref=@_abdrawer Backdrop="false" Absolute="true">
    <DrawerHeader CloseClicked="(() => _abdrawer.Hide())"></DrawerHeader>
    <p class="mb-6 text-sm text-gray-500 dark:text-gray-400">
        Supercharge your hiring by taking advantage of our <a href="/" class="text-primary-600 underline dark:text-primary-500 hover:no-underline"> limited-time sale </a>
        for Flowbite Docs + Job Board. Unlimited access to over 190K top-ranked candidates and the #1 design job board.
    </p>
    <div class="grid grid-cols-2 gap-4">
        <Button Color="Colors.Light">Learn more</Button>
        <Button Class="px-4 flex items-center">Get access <ArrowRightOutline class="w-3.5 h-3.5 ml-2"/></Button>
    </div>
</Drawer>
</div>
```
```csharp
Drawer _abdrawer = new();
```