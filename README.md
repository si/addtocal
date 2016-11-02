# Brain Dump

## Sitemap

 * Homepage
   * Elevator Pitch
   * How It Works
   * Get Started
 * API
   * Get Events
     * Parse Microformats
     * Parse Structured Data
     * Parse natural language 
   * Get ICS
   * Get JSON
 * Contextual Widget

## Homepage

### Elevator Pitch

> Finding calendar events from structured web content
 
### How It Works

1. Events in your web content are marked up with [Microformats](http://microformats.org) or [Structured Data](http://schema.org).
2. You include the [ADDTOC.AL Parser JavaScript](https://addtoc.al/scripts/highlight.js) (`https://addtoc.al/scripts/highlight.js`) on your webpage
3. Any detected events are highlighted as a contextual button€
4. Users can click events to download a calendar file for their preferred personal organiser

### Get Started

Download the latest build from the [ADDTOCAL Github repository](https://github.com/si/addtocal) or install via NPM / Yarn.

#### NPM

    npm install addtocal

#### Yarn

    yarn addtocal

    