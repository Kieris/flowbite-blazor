## Blazor Blockquote - Flowbite
The blockquote component can be used to quote text content from an external source that can be used for testimonials, reviews, and quotes inside an article
    
Get started with Blockquote component when quoting external sources such as quotes inside an article, user reviews, and testimonials based on multiple examples of layouts, styles, and contexts.
### Setup
Import the Blockquote and other Typography components from Flowbite.Blazor.Typography

```razor
@using Flowbite.Blazor.Typography
```

### Default blockquote
Use this example to quote an external source inside a blockquote element.

```razor
<Blockquote Size="TextSizes.XL">"Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."</Blockquote>
```

### Solid background
This example can be used as an alternative style to the default one by applying a solid background color.

```razor
<Paragraph Color="text-gray-500 dark:text-gray-400">Does your user know how to exit out of screens? Can they follow your intended user journey and buy something from the site you’ve designed? By running a usability test, you’ll be able to see how users will interact with your design once it’s live.</Paragraph>
<Blockquote Border="true" Bg="true" class="p-4 my-4">
    <Paragraph Size="TextSizes.XL" Height="Heights.Relaxed">"Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."</Paragraph>
</Blockquote>
<Paragraph Color="text-gray-500 dark:text-gray-400">First of all you need to understand how Flowbite works. This library is not another framework. Rather, it is a set of components based on Tailwind CSS that you can just copy-paste from the documentation.</Paragraph>
```
    
### Blockquote icon
Use this example to show an icon above the blockquote text content.

```razor
<Blockquote Size="TextSizes.XL">
    <QuoteSolid class="w-10 h-10 text-gray-400 dark:text-gray-600" />
    "Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."
</Blockquote>
```
    
### Paragraph context
Use this example to show a blockquote component between multiple paragraph elements.

```razor
<Paragraph class="mb-3" Color="text-gray-500 dark:text-gray-400">Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.</Paragraph>
<div class="grid grid-cols-1 md:gap-6 md:grid-cols-2">
    <Paragraph class="mb-3" Color="text-gray-500 dark:text-gray-400">Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.</Paragraph>
    <Blockquote class="mb-3" Size="TextSizes.XL">" Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application. "</Blockquote>
</div>
<Paragraph class="mb-3" color="text-gray-500 dark:text-gray-400">Deliver great service experiences fast - without the complexity of traditional ITSM solutions.Accelerate critical development work, eliminate toil, and deploy changes with ease, with a complete audit trail for every change.</Paragraph>
```
    
### User testimonial
This example can be used for user testimonials by mentioning the author and occupation of the author.

```razor
<figure class="mx-auto max-w-screen-md text-center">
    <QuoteSolid class="mx-auto mb-3 w-12 h-12 text-gray-400 dark:text-gray-600" />
    <Blockquote Align="Aligns.Center" Size="TextSizes.XL2">"Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."</Blockquote>
    <figcaption class="flex justify-center items-center mt-6 space-x-3">
        <Avatar Src="/images/people/profile-picture-2.webp" Alt="Micheal Gough profile" />
        <div class="flex items-center divide-x-2 divide-gray-500 dark:divide-gray-700">
            <cite class="pr-3 font-medium text-gray-900 dark:text-white">Micheal Gough</cite>
            <cite class="pl-3 text-sm font-light text-gray-500 dark:text-gray-400">CEO at Google</cite>
        </div>
    </figcaption>
</figure>
```
    
### User review
Use this example to show a user review with rating stars and the name and occupation of the author.

```razor
<figure class="max-w-screen-md">
    <div class="flex items-center mb-4 text-yellow-300">
        <svg class="w-5 h-5 mr-1" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 22 20">
            <path d="M20.924 7.625a1.523 1.523 0 0 0-1.238-1.044l-5.051-.734-2.259-4.577a1.534 1.534 0 0 0-2.752 0L7.365 5.847l-5.051.734A1.535 1.535 0 0 0 1.463 9.2l3.656 3.563-.863 5.031a1.532 1.532 0 0 0 2.226 1.616L11 17.033l4.518 2.375a1.534 1.534 0 0 0 2.226-1.617l-.863-5.03L20.537 9.2a1.523 1.523 0 0 0 .387-1.575Z"/>
        </svg>
        <svg class="w-5 h-5 mr-1" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 22 20">
            <path d="M20.924 7.625a1.523 1.523 0 0 0-1.238-1.044l-5.051-.734-2.259-4.577a1.534 1.534 0 0 0-2.752 0L7.365 5.847l-5.051.734A1.535 1.535 0 0 0 1.463 9.2l3.656 3.563-.863 5.031a1.532 1.532 0 0 0 2.226 1.616L11 17.033l4.518 2.375a1.534 1.534 0 0 0 2.226-1.617l-.863-5.03L20.537 9.2a1.523 1.523 0 0 0 .387-1.575Z"/>
        </svg>
        <svg class="w-5 h-5 mr-1" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 22 20">
            <path d="M20.924 7.625a1.523 1.523 0 0 0-1.238-1.044l-5.051-.734-2.259-4.577a1.534 1.534 0 0 0-2.752 0L7.365 5.847l-5.051.734A1.535 1.535 0 0 0 1.463 9.2l3.656 3.563-.863 5.031a1.532 1.532 0 0 0 2.226 1.616L11 17.033l4.518 2.375a1.534 1.534 0 0 0 2.226-1.617l-.863-5.03L20.537 9.2a1.523 1.523 0 0 0 .387-1.575Z"/>
        </svg>
        <svg class="w-5 h-5 mr-1" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 22 20">
            <path d="M20.924 7.625a1.523 1.523 0 0 0-1.238-1.044l-5.051-.734-2.259-4.577a1.534 1.534 0 0 0-2.752 0L7.365 5.847l-5.051.734A1.535 1.535 0 0 0 1.463 9.2l3.656 3.563-.863 5.031a1.532 1.532 0 0 0 2.226 1.616L11 17.033l4.518 2.375a1.534 1.534 0 0 0 2.226-1.617l-.863-5.03L20.537 9.2a1.523 1.523 0 0 0 .387-1.575Z"/>
        </svg>
        <svg class="w-5 h-5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 22 20">
            <path d="M20.924 7.625a1.523 1.523 0 0 0-1.238-1.044l-5.051-.734-2.259-4.577a1.534 1.534 0 0 0-2.752 0L7.365 5.847l-5.051.734A1.535 1.535 0 0 0 1.463 9.2l3.656 3.563-.863 5.031a1.532 1.532 0 0 0 2.226 1.616L11 17.033l4.518 2.375a1.534 1.534 0 0 0 2.226-1.617l-.863-5.03L20.537 9.2a1.523 1.523 0 0 0 .387-1.575Z"/>
        </svg>
    </div>
    <Blockquote Italic="false" Size="TextSizes.XL2">"Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."</Blockquote>
    <figcaption class="flex items-center mt-6 space-x-3">
        <Avatar Src="/images/people/profile-picture-3.webp" Alt="Bonnie Green profile" />
        <div class="flex items-center divide-x-2 divide-gray-300 dark:divide-gray-700">
            <cite class="pr-3 font-medium text-gray-900 dark:text-white">Bonnie Green</cite>
            <cite class="pl-3 text-sm font-light text-gray-500 dark:text-gray-400">CTO at Flowbite</cite>
        </div>
    </figcaption>
</figure>
```
    
### Alignment
Choose from the following examples the blockquote text alignment from starting from left, center to right based on the utility classes from Tailwind CSS.

#### Left
The default alignment of the blockquote text content is the left side of the document.
```razor
<Blockquote Size="TextSizes.XL">"Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."</Blockquote>
```

#### Center
Use Align="Aligns.Center" to align the text content inside the blockquote to the center.
```razor
<Blockquote Align="Aligns.Center" Size="TextSizes.XL">"Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."</Blockquote>
```

## Right
Use Align="Aligns.Right" to align the text content inside the blockquote to the right.
                        
```razor
<Blockquote Align="Aligns.Right" Size="TextSizes.XL">"Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."</Blockquote>
```

### Sizes
There are many sizes for the blockquote component that can be set by using the Size parameter. Below are some of the available sizes.
                        
```razor
<Blockquote Size="TextSizes.XS">"Flowbite is just awesome."</Blockquote>
<Blockquote Size="TextSizes.SM">"Flowbite is just awesome."</Blockquote>
<Blockquote Size="TextSizes.Base">"Flowbite is just awesome."</Blockquote>
<Blockquote Size="TextSizes.XL">"Flowbite is just awesome."</Blockquote>
<Blockquote Size="TextSizes.XL2">"Flowbite is just awesome."</Blockquote>
```
    