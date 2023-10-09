## List Group
Use the list group component to display a series of items, buttons or links inside a single element
        
The list group component can be used to display a series of elements, buttons or links inside a single card component similar to a sidebar.


### Setup
Import the ListGroup namespaces from Flowbite.Blazor.Components.ListGroup

```razor
@using Flowbite.Blazor.Components.ListGroup
```
### Default list group
Here’s an example of a list group that you can use right away.

 ```razor
<ListGroup Items="@_items1" Class="w-48"></ListGroup>
<ListGroup Class="w-48">
    <ListGroupItem>Profile</ListGroupItem>
    <ListGroupItem>Settings</ListGroupItem>
    <ListGroupItem>Messages</ListGroupItem>
    <ListGroupItem>Downloads</ListGroupItem>
</ListGroup>
```
```csharp
List<ListGroupItemModel> _items1 = new()
{
    new ListGroupItemModel()
    {
        Name = "Profile"
    },
    new ListGroupItemModel()
    {
        Name = "Settings"
    },
    new ListGroupItemModel()
    {
        Name = "Messages"
    },
    new ListGroupItemModel()
    {
        Name = "Download"
    }
};
```
### List group with links
You can also display a series of links inside the list group element.

You need to set the list to active mode to enable hovering, focus and links. If list is active and data items contain href field entries are presented as links.
```razor
<ListGroup Active="true" Items="@_items2" Class="w-48"></ListGroup>
```
```csharp
List<ListGroupItemModel> _items2 = new()
{
    new ListGroupItemModel()
    {
        Name = "Profile",
        Href = "#"
    },
    new ListGroupItemModel()
    {
        Name = "Settings",
        Href = "#"
    },
    new ListGroupItemModel()
    {
        Name = "Messages",
        Href = "#"
    },
    new ListGroupItemModel()
    {
        Name = "Download",
        Href = "#"
    }
};
```
    
### List group with buttons
It is also possible to display a list of button element inside the list group component. The following example includes an active and disabled item as well. 

Individual ListGroupItem components also have a OnClick callback, but they then you must define a value with it.

```razor
<div class="flex justify-center">
    <ListGroup Items="@_items3" Active="true" Class="w-48" OnClick="@BtnClick"></ListGroup>
</div>
<h4>Item clicked: @_btnClick</h4>
```

```csharp
List<ListGroupItemModel> _items3 = new()
{
    new ListGroupItemModel()
    {
        Name = "Profile"
    },
    new ListGroupItemModel()
    {
        Name = "Settings"
    },
    new ListGroupItemModel()
    {
        Name = "Messages"
    },
    new ListGroupItemModel()
    {
        Name = "Download",
        Disabled = true
    }
};
```
### List group with icons
Use the following example to create a list of buttons as a menu together with SVG icons
```razor
<ListGroup Class="w-48">
    <ListGroupItem Class="flex justify-start items-center">
        <UserSolid class="w-3 h-3 mr-2.5" />
        Profile
    </ListGroupItem>
    <ListGroupItem Class="flex justify-start items-center">
        <AdjustmentsHorizontalSolid class="w-3 h-3 mr-2.5" />
        Settings
    </ListGroupItem>
    <ListGroupItem Class="flex justify-start items-center">
        <MessagesSolid class="w-3 h-3 mr-2.5" />
        Messages
    </ListGroupItem>
    <ListGroupItem Class="flex justify-start items-center">
        <DownloadSolid class="w-3 h-3 mr-2.5" />
        Download
    </ListGroupItem>
</ListGroup>
```