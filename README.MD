## What is this?
Small home project with automatic deployment for GitHub through .github/workflow

## Tech stack
It is running on a Blazor WebAssembly Front End since GitHub pages only takes static web applications

## Noteworthy things during the setup
GitHub Actions Pipeline set up pushes to gh-pages branch. - Remember to actually set it up in settings to host the page from said branch :-)


## Debugging is a nightmare..
So debugging broke for browsers - and I am currently awaiting a new .Net 9 release before real debugging with break points can happen :)


### TailwindCSS Reminder
npx @tailwindcss/cli -i ./styles/input.css -o ./wwwroot/output.css --watch