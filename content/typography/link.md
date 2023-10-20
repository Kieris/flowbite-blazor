## Blazor Links - Flowbite
The link component can be used to set hyperlinks from one page to another or to an external website when clicking on an inline text item, button, or card

Get started with the link component to enable hyperlinks across pages and external websites applied to elements such as inline text, buttons, cards, inside paragraphs, and more.

Hyperlinks are a great way to reduce bounce rate of the current page and encourage visitors to browse your website and become a returning user.

### Setup
Import the Link and other Typography components from Flowbite.Blazor.Typography
```razor
@using Flowbite.Blazor.Typography
```

### Default link
Use this example to set default styles to an inline link element.

```razor
<Link class="font-medium">Read more</Link>
```

### Paragraph
Use this example to set a link inside a paragraph with an underline style. Override the default link classes with the LinkClass parameter.

```razor
<Paragraph>
    The free updates that will be provided is based on the <Link href="/" LinkClass="underline hover:no-underline">roadmap</Link> that we have laid out for this project. It is also possible that we will provide extra updates outside of the roadmap as well.
</Paragraph>
```

### Icon link
This example can be used to set a custom SVG icon inside the hyperlink element.
```razor
<Paragraph>
    500,000 people have made over a million apps with Glide.
    <Link href="/" Color="text-primary-600 dark:text-primary-500" LinkClass="inline-flex items-center font-medium  hover:underline">
        Read their stories
        <ArrowRightOutline class="w-4 h-4 ml-2" />
    </Link>
</Paragraph>
```
    
### CTA link
Use this example to set a hyperlink on a CTA element with text and a custom icon.

```razor
<Link Color="text-gray-500 dark:text-gray-400 dark:hover:text-white" LinkClass="inline-flex justify-center items-center p-5 text-base font-medium bg-gray-50 rounded-lg hover:text-gray-900 hover:bg-gray-100 dark:bg-gray-800 dark:hover:bg-gray-700">
    <svg aria-hidden="true" class="w-5 h-5 mr-3" viewBox="0 0 22 31" fill="none" xmlns="http://www.w3.org/2000/svg"><g clip-path="url(#clip0_4151_63004)"><path d="M5.50085 30.1242C8.53625 30.1242 10.9998 27.8749 10.9998 25.1035V20.0828H5.50085C2.46546 20.0828 0.00195312 22.332 0.00195312 25.1035C0.00195312 27.8749 2.46546 30.1242 5.50085 30.1242Z" fill="#0ACF83"/><path d="M0.00195312 15.062C0.00195312 12.2905 2.46546 10.0413 5.50085 10.0413H10.9998V20.0827H5.50085C2.46546 20.0827 0.00195312 17.8334 0.00195312 15.062Z" fill="#A259FF"/><path d="M0.00195312 5.02048C0.00195312 2.24904 2.46546 -0.000244141 5.50085 -0.000244141H10.9998V10.0412H5.50085C2.46546 10.0412 0.00195312 7.79193 0.00195312 5.02048Z" fill="#F24E1E"/><path d="M11 -0.000244141H16.4989C19.5343 -0.000244141 21.9978 2.24904 21.9978 5.02048C21.9978 7.79193 19.5343 10.0412 16.4989 10.0412H11V-0.000244141Z" fill="#FF7262"/><path d="M21.9978 15.062C21.9978 17.8334 19.5343 20.0827 16.4989 20.0827C13.4635 20.0827 11 17.8334 11 15.062C11 12.2905 13.4635 10.0413 16.4989 10.0413C19.5343 10.0413 21.9978 12.2905 21.9978 15.062Z" fill="#1ABCFE"/></g><defs><clipPath id="clip0_4151_63004"><rect width="22" height="30.1244" fill="white" transform="translate(0 -0.000244141)"/></clipPath></defs></svg>                                              
    <span class="w-full ml-3">Get started with our Figma Design System</span>
    <ArrowRightOutline class="w-4 h-4 ml-2" />
</Link>
```
    
### Card link
Use this example to set a hyperlink on a card component.
```razor
<Link href="#" LinkClass="block max-w-sm p-6 bg-white border border-gray-200 rounded-lg shadow-md hover:bg-gray-100 dark:bg-gray-800 dark:border-gray-700 dark:hover:bg-gray-700">
    <Heading Tag="h5" class="mb-2 text-2xl font-bold tracking-tight">Noteworthy technology acquisitions 2021</Heading>
    <Paragraph Color="text-gray-700 dark:text-gray-400">Here are the biggest enterprise technology acquisitions of 2021 so far, in reverse chronological order.</Paragraph>
</Link>
```
    
### Active class
The ActiveClass parameter can be used to set a class for when the href of the Link is the current location.

```razor
<Link class="font-medium rounded-lg p-2 mx-2" href="/docs/typography/link" ActiveClass="text-white bg-accent-600 hover:no-underline">Active</Link>
<Link class="font-medium rounded-lg p-2 mx-2" href="/docs/typography/hr" ActiveClass="text-white bg-accent-600 hover:no-underline">Not active</Link>
```