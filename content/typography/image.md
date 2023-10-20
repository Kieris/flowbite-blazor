## Blazor Images - Flowbite

The image component can be used to embed images inside the web page in articles and sections based on multiple styles, sizes, layouts and hover animations

Get started with a collection of responsive image components coded with the utility classes from Tailwind CSS that you can use inside articles, cards, sections, and other components based on multiple styles, sizes, layouts, and hover animations.

### Setup
Import the Image and other Typography components from Flowbite.Blazor.Typography
```razor
@using Flowbite.Blazor.Typography
```

### Default image
Use this example to show a responsive image that won’t grow beyond the maximum original width.
```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1"/>
```

### Image caption
This example can be used to add a caption for the image often used inside articles.
```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Caption="This is a caption"/>
```
    
### Rounded corners
Apply rounded corners to the image by using the specific utility classes from Tailwind CSS.
        
#### Border radius
Use this example to apply rounded corners to the image by using the rounded-size class where the size can be anything from small to extra large.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Size="max-w-lg" Class="rounded-lg"/>
```
    
#### Full circle
Use this example to apply rounded corners to the image by using the rounded-size class where the size can be anything from small to extra large.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Size="w-96" ImgClass="h-96" Class="rounded-full"/>
```
    
### Image Shadow
This example can be used to show a shadow effect for the image using the shadow-size utility class.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Size="max-w-xl" ImgClass="h-96" Class="shadow-xl dark:shadow-gray-800"/>
```
    
### Retina-ready
Use the SrcSet attribute to set Retina-ready images with double resolution.

```razor
<Image SrcSet="/images/examples/image-1.jpg 1x, /images/examples/image-12x.jpg 2x" Alt="sample 1" Size="w-full max-w-xl" Class="rounded-lg"/>
```
    
### Image card
Use this example to make the image a card item with a link and a short text description.

```razor
<Image Src="/images/examples/content-gallery-3.png" Alt="sample 1" Class="rounded-lg" FigClass="relative max-w-sm transition-all duration-300 cursor-pointer filter grayscale hover:grayscale-0" CaptionClass="absolute bottom-6 px-4 text-lg text-white" Caption="Do you want to get notified when a new component is added to Flowbite?" />
```    
    
### Image effects
Use image effects such as grayscale or blur to change the appearances of the image when being hovered.
    
#### Grayscale
Use the filter option and apply a grayscale to the image element using the grayscale class.

```razor
<Image Src="/images/examples/content-gallery-3.png" Alt="sample 1" Size="max-w-lg" Class="rounded-lg transition-all duration-300 cursor-pointer filter grayscale hover:grayscale-0" />
```
    
#### Blur
Apply a blur by using the blur-size utility class from Tailwind CSS to an image component.

```razor
<Image Src="/images/examples/content-gallery-3.png" Alt="sample 1" Size="max-w-lg" Class="rounded-lg transition-all duration-300 blur-sm hover:blur-none" />
```
    
### Alignment
Align the image component to the left, center or right side of the document page using margin styles.
        
#### Left
By default, the image component will be aligned to the left side of the page.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Size="max-w-lg" />
```

#### Center
Horizontally align the image to the center of the page using the mx-auto class.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Class="mx-auto" Size="max-w-lg"  />
```

#### Right
Use the ml-auto class to align the image to the right side of the page.
```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Class="ml-auto" Size="max-w-lg"  />
```

### Sizes
Set the size of the image using the w-size and h-size or max-w-size utility classes from Tailwind CSS to set the width and height of the element.
        
#### Small
Use the max-w-xs class to set a small size of the image.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Size="max-w-xs" />
```

#### Medium

Use the max-w-md class to set a medium size of the image.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Size="max-w-md" />
```

#### Large
Use the max-w-xl class to set a large size of the image.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Size="max-w-xl" />
```

#### Full width
Use the max-w-full class to set the full width of the image as long as it doesn’t become larger than the original source.

```razor
<Image Src="/images/examples/image-12x.jpg" Alt="sample 1" Size="max-w-full" />
```