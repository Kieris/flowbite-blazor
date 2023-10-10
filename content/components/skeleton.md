## Skeleton

### The skeleton component can be used as an alternative loading indicator to the spinner by mimicking the content that will be loaded such as text, images, or video

Use the skeleton component to indicate a loading status with placeholder elements that look very similar to the type of content that is being loaded such as paragraphs, heading, images, videos, and more.

You can set the width and height of these skeleton components based on the size of the content and element that it is being loaded in, such as a card or an article page.
    

### Setup
Import the Skeleton namespace from Flowbite.Blazor.Components.Skeleton

```razor    
@using Flowbite.Blazor.Components.Skeleton
```
### Default skeleton
Use this example to show a placeholder when loading text content. Setting the Animate parameter to false will turn off animation.

```razor
<Skeleton Class="my-8"></Skeleton>
<Skeleton Size="SkSize.Md" Class="my-8"></Skeleton>
<Skeleton Size="SkSize.Lg" Class="my-8"></Skeleton>
<Skeleton Size="SkSize.Xl" Class="my-8"></Skeleton>
<Skeleton Size="SkSize.Xxl" Class="my-8"></Skeleton>
```
    
### Image placeholder
This example can be used to show a placeholder when loading an image and text content.

```razor
<ImagePlaceholder />
<ImagePlaceholder ImgHeight="h-64" Class="mt-8" />
```

### Video placeholder
Use this example to show a skeleton placeholder when loading video content.

```razor
<VideoPlaceholder Class="my-8"></VideoPlaceholder>
<VideoPlaceholder Size="SkSize.Md" Class="my-8"></VideoPlaceholder>
<VideoPlaceholder Size="SkSize.Lg" Class="my-8"></VideoPlaceholder>
<VideoPlaceholder Size="SkSize.Xl" Class="my-8"></VideoPlaceholder>
<VideoPlaceholder Size="SkSize.Xxl" Class="my-8"></VideoPlaceholder>
```
    
### Text placeholder
Use this example to show a placeholder when loading longer paragraphs and headings.

```razor
<TextPlaceholder Class="my-8"></TextPlaceholder>
<TextPlaceholder Size="SkSize.Md" Class="my-8"></TextPlaceholder>
<TextPlaceholder Size="SkSize.Lg" Class="my-8"></TextPlaceholder>
<TextPlaceholder Size="SkSize.Xl" Class="my-8"></TextPlaceholder>
<TextPlaceholder Size="SkSize.Xxl" Class="my-8"></TextPlaceholder>
```
    
### Card placeholder
Use this example to show a placeholder when loading content inside a card.

```razor
<CardPlaceholder Class="my-8"></CardPlaceholder>
<CardPlaceholder Size="SkSize.Md" Class="my-8"></CardPlaceholder>
<CardPlaceholder Size="SkSize.Lg" Class="my-8"></CardPlaceholder>
<CardPlaceholder Size="SkSize.Xl" Class="my-8"></CardPlaceholder>
<CardPlaceholder Size="SkSize.Xxl" Class="my-8"></CardPlaceholder>
```
    
### Widget placeholder
This example can be used to show a placeholder of skeleton when fetching data for widgets and cards inside an application.

```razor
<WidgetPlaceholder Class="my-8"></WidgetPlaceholder>
```
### List placeholder
Use this example to show a placeholder when loading a list of items.

```razor
<ListPlaceholder Class="my-8"></ListPlaceholder>
```
### Testimonial placeholder
This example can be used to show a skeleton placeholder when loading data for a testimonial section.
```razor
<TestimonialPlaceholder Class="my-8"></TestimonialPlaceholder>
```