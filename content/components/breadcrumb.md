## Breadcrumbs
    
#### The breadcrumb component is an important part of any website or application that can be used to show the current location of a page in a hierarchical structure of pages.
#### Flowbite includes two styles of breadcrumb elements, one that has a transparent background and a few more that come with a background in different colors.
    

### Setup
#### Import the Breadcrumb namespace from Flowbite.Blazor.Breadcrumbs.

```razor
   @using Flowbite.Blazor.Components.Breadcrumbs
```

### Default breadcrumb
#### Use the following breadcrumb example to show the hierarchical structure of pages.

```razor
<Breadcrumb>
    <BreadcrumbItem Href="/">Home</BreadcrumbItem>
    <BreadcrumbItem Href="#">Projects</BreadcrumbItem>
    <BreadcrumbItem>Flowbite</BreadcrumbItem>
</Breadcrumb>
```

### Solid breadcrumb
#### You can alternatively also use the breadcrumb components with a solid background. This example also shows that href does not need to be capitalized to work.

```razor
<Breadcrumb Solid="true">
    <BreadcrumbItem href="/">Home</BreadcrumbItem>
    <BreadcrumbItem href="#">Projects</BreadcrumbItem>
    <BreadcrumbItem>Flowbite</BreadcrumbItem>
</Breadcrumb>
```
### Custom icons
#### Use the Icon fragment to change icons. When this is used, the content like the label must be placed inside ChildContent.

```razor
<Breadcrumb Solid="true">
    <BreadcrumbItem Href="/">
        <Icon>
            <HomeOutline class="w-3 h-3"></HomeOutline>
        </Icon>
        <ChildContent>
            Home
        </ChildContent>
    </BreadcrumbItem>
    <BreadcrumbItem Href="#">
        <Icon>
            <ChevronDoubleRightSolid class="w-3 h-3 text-gray-400"></ChevronDoubleRightSolid>
        </Icon>
        <ChildContent>
            Projects
        </ChildContent>
    </BreadcrumbItem>
    <BreadcrumbItem>
        <Icon>
            <ChevronDoubleRightSolid class="w-3 h-3 text-gray-400"></ChevronDoubleRightSolid>
        </Icon>
        <ChildContent>
            Flowbite
        </ChildContent>
    </BreadcrumbItem>
</Breadcrumb>
```