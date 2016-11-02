# Add To Cal

## Elevator Pitch

> Finding calendar events from structured web content

## Why?

Have you ever noticed on your device when dates or times are automatically identified and change to a link? When you click those links, you're asked about creating an event in your calendar. We want this to work across all platforms on all websites.

Over 10 years ago, the Web Standards community recommended a way of marking up web content (HTML) with additional structure, be it contact details, news items, product details or events. These were called [Microformats](http://microformats.org/). Off the back of these formats, [tools were created](http://h2vx.com/) to extract content as usable formats such as VCF files for contacts or ICS files for events.

Since then, these patterns have been extended with other purposes (such as social sharing) into other formats such as Google's preffered [Structured Data](http://schema.org) which allows them to present richer search results.

These formats are all well and good for machines to recognise but people still aren't getting the full benefit. ADD TO CAL aims to address this by focusing on calendar events. 

ADD TO CAL parses structured content for recognisable event patterns into calendar-friendly formats in a number of ways:

* ADDTOCAL Javascript SDK for your website to present any events
* Self-link reference to ADDTOCAL API to automatically output calendar data
* Browser extensions to automatically identify events across all web content 
 
## How It Works

1. Events in your web content are marked up with [Microformats](http://microformats.org) or [Structured Data](http://schema.org).
2. Include the [Add To Cal SDK](https://addtoc.al/scripts/highlight.js) (`https://addtoc.al/scripts/highlight.js`) on your site.
3. Any detected events are highlighted with a contextual or dedicated component.
4. Users can choose to download events as calendar files for their preferred personal organiser.

## Get Started

Download the latest build from the [Add To Cal Github repository](https://github.com/si/addtocal) or install via NPM / Yarn.

### NPM

    npm install addtocal

### Yarn

    yarn addtocal

## Sitemap

 * Homepage
   * Elevator Pitch
   * How It Works
   * Get Started
 * API
   * Get Events
     * Parse Microformats
     * Parse Structured Data
     * Parse natural language (TBC)
   * Get Events as ICS
   * Get Events as JSON
 * Widgets
   * Contextual widget
   * Dedicated widget

