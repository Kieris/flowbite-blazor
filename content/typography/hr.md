## Blazor Horizontal Rule (HR) - Flowbite

Create a horizontal line using the `HorizontalRule` component to separate content such as paragraphs, blockquotes, and other elements

The HorizontalRule component can be used to separate content using a horizontal line by adding space between elements based on multiple styles, variants, and layouts.


### Setup

Import the HorizontalRule and other Typography components from Flowbite.Blazor.Typography
```razor
@using Flowbite.Blazor.Typography
```

### Default HR
Here is an example using the default HorizontalRule.

```razor
<Paragraph>Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.</Paragraph>
<HorizontalRule Class="my-8" />
<Paragraph>Deliver great service experiences fast - without the complexity of traditional ITSM solutions.Accelerate critical development work, eliminate toil, and deploy changes with ease, with a complete audit trail for every change.</Paragraph>
```


### Trimmed
Use this example to show a shorter version of the horizontal line.

```razor
<Paragraph>Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.</Paragraph>
<HorizontalRule Class="w-48 h-1 mx-auto my-4 rounded md:my-10" />
<Paragraph>Deliver great service experiences fast - without the complexity of traditional ITSM solutions.Accelerate critical development work, eliminate toil, and deploy changes with ease, with a complete audit trail for every change.</Paragraph>
```

### Icon HR
This example can be used to set a custom SVG icon in the middle of the HR element.

```razor
<Paragraph>Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.</Paragraph>
<HorizontalRule Class="my-8 w-64 h-1" Icon>
    <QuoteSolid class="w-4 h-4 text-gray-700 dark:text-gray-300" />
</HorizontalRule>
<Paragraph>Deliver great service experiences fast - without the complexity of traditional ITSM solutions.Accelerate critical development work, eliminate toil, and deploy changes with ease, with a complete audit trail for every change.</Paragraph>
```

### HR with text
Use this example to add a text in the middle of the HR component.

```razor
<Paragraph>Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.</Paragraph>
<HorizontalRule Class="my-8 w-64">or</HorizontalRule>
<Paragraph>Deliver great service experiences fast - without the complexity of traditional ITSM solutions.Accelerate critical development work, eliminate toil, and deploy changes with ease, with a complete audit trail for every change.</Paragraph>
```

### HR with shape

This example can be used to separate content with a HR tag as a shape instead of a line.

```razor
<Paragraph>Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.</Paragraph>
<HorizontalRule Class="my-8 mx-auto w-8 h-8" />
<Blockquote Align="Aligns.Center" Italic="true">
    <p>"Flowbite is just awesome. It contains tons of predesigned components and pages starting from login screen to complex dashboard. Perfect choice for your next SaaS application."</p>
</Blockquote>
```