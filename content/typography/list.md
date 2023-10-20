## Blazor Lists - Flowbite
Use the list component to show an unordered or ordered list of items based on multiple styles, layouts, and variants built with Tailwind CSS and Flowbite

Get started with a collection of list components built with Tailwind CSS for ordered and unordered lists with bullets, numbers, or icons and other styles and layouts to show a list of items inside an article or throughout your web page.

### Setup
Import the List and other Typography components from Flowbite.Blazor.Typography

```razor
@using Flowbite.Blazor.Typography
```

### Unordered list
Use this example to create a default unordered list of items.

```razor
<Heading Tag="h2" Size="text-lg font-semibold" class="mb-2 text-lg font-semibold text-gray-900 dark:text-white">Password requirements</Heading>
<List Type="ListType.Unordered" class="space-y-1 text-gray-500 dark:text-gray-400">
    <ListItem>At least 10 characters (and up to 100 characters)</ListItem>
    <ListItem>At least one lowercase character</ListItem>
    <ListItem>Inclusion of at least one special character, e.g., ! @@ # ?</ListItem>
</List>
```

### Icons
This example can be used to apply custom icons instead of the default bullets for the list items.

```razor
<Heading Tag="h2" Size="text-lg font-semibold" class="mb-2 text-lg font-semibold text-gray-900 dark:text-white">Password requirements</Heading>
<List class="space-y-1 text-gray-500 dark:text-gray-400">
    <ListItem icon>
        <CheckCircleSolid class="w-3.5 h-3.5 mr-2 text-green-500 dark:text-green-400" />
        At least 10 characters (and up to 100 characters)
    </ListItem>
    <ListItem icon>
        <CheckCircleSolid class="w-3.5 h-3.5 mr-2 text-green-500 dark:text-green-400" />
        At least one lowercase character
    </ListItem>
    <ListItem icon>
        <CloseCircleSolid class="w-3.5 h-3.5 mr-2 text-gray-500 dark:text-gray-400" />
        Inclusion of at least one special character, e.g., ! @@ # ?
    </ListItem>
</List>
```
    
### Nested
Use this example to nested another list of items inside the parent list element.

```razor
<List Type="ListType.Unordered" class="space-y-4 text-gray-500 dark:text-gray-400">
<ListItem>
    List item one
    <List Type="ListType.Ordered" class="pl-5 mt-2 space-y-1">
        <ListItem>You might feel like you are being really "organized" o</ListItem>
        <ListItem>Nested navigation in UIs is a bad idea too, keep things as flat as possible.</ListItem>
        <ListItem>Nesting tons of folders in your source code is also not helpful.</ListItem>
    </List>
</ListItem>
<ListItem>
    List item two
    <List Type="ListType.Ordered" class="pl-5 mt-2 space-y-1">
        <ListItem>I'm not sure if we'll bother styling more than two levels deep.</ListItem>
        <ListItem>Two is already too much, three is guaranteed to be a bad idea.</ListItem>
        <ListItem>If you nest four levels deep you belong in prison.</ListItem>
    </List>
</ListItem>
<ListItem>
    List item three
    <List Type="ListType.Ordered" class="pl-5 mt-2 space-y-1">
        <ListItem>Again please don't nest lists if you want</ListItem>
        <ListItem>Nobody wants to look at this.</ListItem>
        <ListItem>I'm upset that we even have to bother styling this.</ListItem>
    </List>
</ListItem>
</List>
```
    
### Unstyled list
Use ListType.Unstyled on the Type parameter to disable the list style bullets or numbers. This is the default style.

```razor
<Heading Tag="h2" Size="text-lg font-semibold" class="mb-2 text-lg font-semibold text-gray-900 dark:text-white">Password requirements</Heading>
<List Type="ListType.Unstyled" class="space-y-1 text-gray-500 dark:text-gray-400">
    <ListItem>At least 10 characters (and up to 100 characters)</ListItem>
    <ListItem>At least one lowercase character</ListItem>
    <ListItem>Inclusion of at least one special character, e.g., ! @@ # ?</ListItem>
</List>
```

### Ordered list
Use ListType.Ordered to create an ordered list of items with numbers.

```razor
<Heading Tag="h2" Size="text-lg font-semibold" class="mb-2 text-lg font-semibold  text-gray-900 dark:text-white">Top students:</Heading>
<List Type="ListType.Ordered" class="space-y-1 text-gray-500 dark:text-gray-400">
    <ListItem><Span>Bonnie Green</Span> with <Span>70</Span> points</ListItem>
    <ListItem><Span>Jese Leos</Span> with <Span>63</Span> points</ListItem>
    <ListItem><Span>Leslie Livingston</Span> with <Span>57</Span> points</ListItem>
</List>
```
    
### Description List
Create a description list and set the term and name with the following example.

```razor
<List class="text-gray-900 dark:text-white divide-y divide-gray-200  dark:divide-gray-700">
    <div class="flex flex-col pb-3">
        <DescTerm class="mb-1">Email address</DescTerm>
        <Description>yourname@flowbite.com</Description>
    </div>
    <div class="flex flex-col pb-3">
        <DescTerm class="mb-1">Home address</DescTerm>
        <Description>92 Miles Drive, Newark, NJ 07103, California, USA</Description>
    </div>
    <div class="flex flex-col pb-3">
        <DescTerm class="mb-1">Phone number</DescTerm>
        <Description>+00 123 456 789 / +12 345 678</Description>
    </div>
</List>
```

### List with icon
Use this example to create a list of items with custom SVG icons instead of the default bullets.

```razor
<List class="mb-8 space-y-4 text-gray-500 dark:text-gray-400" list="none">
    <ListItem Icon class="gap-3">
        <CheckOutline class="w-3.5 h-3.5 text-green-500 dark:text-green-400" />
        Individual configuration
    </ListItem>
    <ListItem Icon class="gap-3">
        <CheckOutline class="w-3.5 h-3.5 text-green-500 dark:text-green-400" />
        No setup, or hidden fees
    </ListItem>
    <ListItem Icon class="gap-3">
        <CheckOutline class="w-3.5 h-3.5 text-green-500 dark:text-green-400" />
        <span>Team size: <Span>1 developer</Span></span>
    </ListItem>
    <ListItem Icon class="gap-3">
        <CheckOutline class="w-3.5 h-3.5 text-green-500 dark:text-green-400" />
        <span>Premium support: <Span>6 months</Span></span>
    </ListItem>
    <ListItem Icon class="gap-3">
        <CheckOutline class="w-3.5 h-3.5 text-green-500 dark:text-green-400" />
        <span>Free updates: <Span>6 months</Span></span>
    </ListItem>
</List>
```

### Advanced layout
This example can be used to show more details for each list item such as the user’s name, email and profile picture.

```razor
<List class="max-w-md divide-y divide-gray-200 dark:divide-gray-700">
    <ListItem class="pb-3 sm:pb-4">
        <div class="flex items-center space-x-4">
            <div class="flex-shrink-0">
                <img class="w-8 h-8 rounded-full" src="/images/people/profile-picture-1.webp" alt="Neil profile" />
            </div>
            <div class="flex-1 min-w-0">
                <p class="text-sm font-medium text-gray-900 truncate dark:text-white">Neil Sims</p>
                <p class="text-sm text-gray-500 truncate dark:text-gray-400">email@flowbite.com</p>
            </div>
            <div class="inline-flex items-center text-base font-semibold text-gray-900 dark:text-white">$320</div>
        </div>
    </ListItem>
    <ListItem class="py-3 sm:py-4">
        <div class="flex items-center space-x-4">
            <div class="flex-shrink-0">
                <img class="w-8 h-8 rounded-full" src="/images/people/profile-picture-2.webp" alt="Bonnie profile" />
            </div>
            <div class="flex-1 min-w-0">
                <p class="text-sm font-medium text-gray-900 truncate dark:text-white">Bonnie Green</p>
                <p class="text-sm text-gray-500 truncate dark:text-gray-400">email@flowbite.com</p>
            </div>
            <div class="inline-flex items-center text-base font-semibold text-gray-900 dark:text-white">$3467</div>
        </div>
    </ListItem>
    <ListItem class="py-3 sm:py-4">
        <div class="flex items-center space-x-4">
            <div class="flex-shrink-0">
                <img class="w-8 h-8 rounded-full" src="/images/people/profile-picture-3.webp" alt="Michael profile" />
            </div>
            <div class="flex-1 min-w-0">
                <p class="text-sm font-medium text-gray-900 truncate dark:text-white">Michael Gough</p>
                <p class="text-sm text-gray-500 truncate dark:text-gray-400">email@flowbite.com</p>
            </div>
            <div class="inline-flex items-center text-base font-semibold text-gray-900 dark:text-white">$67</div>
        </div>
    </ListItem>
    <ListItem class="py-3 sm:py-4">
        <div class="flex items-center space-x-4">
            <div class="flex-shrink-0">
                <img class="w-8 h-8 rounded-full" src="/images/people/profile-picture-4.webp" alt="Thomas profile" />
            </div>
            <div class="flex-1 min-w-0">
                <p class="text-sm font-medium text-gray-900 truncate dark:text-white">Thomas Lean</p>
                <p class="text-sm text-gray-500 truncate dark:text-gray-400">email@flowbite.com</p>
            </div>
            <div class="inline-flex items-center text-base font-semibold text-gray-900 dark:text-white">$2367</div>
        </div>
    </ListItem>
    <ListItem class="py-3 sm:py-4">
        <div class="flex items-center space-x-4">
            <div class="flex-shrink-0">
                <img class="w-8 h-8 rounded-full" src="/images/people/profile-picture-5.webp" alt="Lana profile" />
            </div>
            <div class="flex-1 min-w-0">
                <p class="text-sm font-medium text-gray-900 truncate dark:text-white">Lana Byrd</p>
                <p class="text-sm text-gray-500 truncate dark:text-gray-400">email@flowbite.com</p>
            </div>
            <div class="inline-flex items-center text-base font-semibold text-gray-900 dark:text-white">$367</div>
        </div>
    </ListItem>
</List>
```

### Horizontal List
Use this example to create a horizontally aligned list of items.

```razor
<List class="flex flex-wrap justify-center items-center mb-6">
    <ListItem>
    <Link href="/" class="mr-4 md:mr-6" Color="text-gray-700 dark:text-white">About</Link>
    </ListItem>
    <ListItem>
    <Link href="/" class="mr-4 md:mr-6" Color="text-gray-700 dark:text-white">Premium</Link>
    </ListItem>
    <ListItem>
    <Link href="/" class="mr-4  md:mr-6" Color="text-gray-700 dark:text-white">Campaigns</Link>
    </ListItem>
    <ListItem>
    <Link href="/" class="mr-4 md:mr-6" Color="text-gray-700 dark:text-white">Blog</Link>
    </ListItem>
    <ListItem>
    <Link href="/" class="mr-4 md:mr-6" Color="text-gray-700 dark:text-white">Affiliate Program</Link>
    </ListItem>
    <ListItem>
    <Link href="/" class="mr-4 md:mr-6" Color="text-gray-700 dark:text-white">FAQs</Link>
    </ListItem>
</List>
```