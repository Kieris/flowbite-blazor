## Blazor Heading - Flowbite
The heading component defines six levels of title elements from H1 to H6 that are used as titles and subtitles on a web page based on multiple styles and layouts

Get started with the heading component to define titles and subtitles on a web page and also improve the on-page SEO metrics of your website by targeting high-traffic keywords on Google.

At least one unique H1 tag should be available for each page on your website with the next tags starting from H2 to H6 for each section. Choose from a collection of custom heading components based on multiple styles and layouts built with the utility classes from Tailwind CSS.


### Setup
Import the Heading and other Typography components from Flowbite.Blazor.Typography

```razor
@using Flowbite.Blazor.Typography
```

### Default heading
Use this example of a H1 heading in the context of a paragraph and CTA button for landing pages.

```razor
<div class="flex flex-col items-center justify-center text-center">
    <Heading Tag="h1" class="mb-4" Size="text-4xl font-extrabold md:text-5xl lg:text-6xl">We invest in the world’s potential</Heading>
    <Paragraph class="mb-6 text-lg lg:text-xl sm:px-16 xl:px-48 dark:text-gray-400">Here at Flowbite we focus on markets where technology, innovation, and capital can unlock long-term value and drive economic growth.</Paragraph>
    <Button>
        Learn more
        <ArrowRightOutline class="w-3.5 h-3.5 ml-2" />
    </Button>
</div>
```

### Second-level heading
Use this example of a second-level H2 heading as the main subtitle for each section of your web page.

```razor
<Heading tag="h2" Size="text-4xl font-extrabold ">Payments tool for companies</Heading>
<Paragraph class="my-4 text-gray-500">Start developing with an open-source library of over 450+ UI components, sections, and pages built with the utility classes from Tailwind CSS and designed in Figma.</Paragraph>
<Paragraph class="mb-4">Deliver great service experiences fast - without the complexity of traditional ITSM solutions. Accelerate critical development work, eliminate toil, and deploy changes with ease.</Paragraph>
<Link>
    Read more
    <ChevronRightSolid class="w-3.5 h-3.5 ml-2" />
</Link>
```

### Highlighted heading
Use this example to highlight a certain portion of the heading text with a different color.

```razor
<Heading tag="h1" class="mb-4">Get back to growth with <Span Highlight="true">the world's #1</Span> CRM.</Heading>
<Paragraph>Here at Flowbite we focus on markets where technology, innovation, and capital can unlock long-term value and drive economic growth.</Paragraph>
```

### Heading mark
This example can be used to mark one part of the heading text with a solid background for highlighting.

```razor
<Heading Tag="h1" class="mb-4">Regain <Mark>control</Mark> over your days</Heading>
<Paragraph>Here at Flowbite we focus on markets where technology, innovation, and capital can unlock long-term value and drive economic growth.</Paragraph>
```

### Heading gradient

Use this example to highlight a portion of the heading text by using a gradient style.

```razor
<Heading tag="h1" class="mb-4" Size="text-3xl font-extrabold md:text-5xl lg:text-6xl">
    <Span Gradient="true">Better Data</Span> Scalable AI.
</Heading>
<Paragraph>Here at Flowbite we focus on markets where technology, innovation, and capital can unlock long-term value and drive economic growth.</Paragraph>
```

### Heading underline

Get started with this example to underline an important part of the heading component using the underline prop in the Span component.

```razor
<Heading Tag="h1" class="mb-4">
    We invest in the <Span Underline="true" DecorationClass="decoration-8 decoration-blue-400 dark:decoration-blue-600">world’s potential</Span>
</Heading>
<Paragraph>Here at Flowbite we focus on markets where technology, innovation, and capital can unlock long-term value and drive economic growth.</Paragraph>
```

### Badge context
Use this example to show a badge component inside the heading text element as a secondary indicator.

```razor
<Heading Tag="h1" class="flex items-center" Size="text-5xl">
    Flowbite <Badge class="text-2xl font-semibold ml-2">PRO</Badge>
</Heading>
```

### Secondary text
This example can be used to add a secondary text inside the main heading component.

```razor
<Heading Tag="h1" Size="text-5xl font-extrabold">
    Flowbite <Secondary class="ml-2">This is secondary text</Secondary>
</Heading>
```

### Default Sizes
The heading component has six levels of importance starting from H1 which has to be unique on the page and has the greatest weight of importance all the way to H6.

#### Heading 1
```razor
<Heading Tag="h1">Heading 1</Heading>
```

#### Heading 2
```razor
<Heading Tag="h2">Heading 2</Heading>
```

#### Heading 3
```razor
<Heading Tag="h3">Heading 3</Heading>
```

#### Heading 4
```razor
<Heading Tag="h4">Heading 4</Heading>
```

#### Heading 5
```razor
<Heading Tag="h5">Heading 5</Heading>
```

#### Heading 6
```razor
<Heading Tag="h6">Heading 6</Heading>
```
