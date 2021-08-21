# Classkicker
ClassKicker for SchoolGroup

Hello.
This was made for SchoolGroup.
~~This was made in python with the most comments to show you the code and what each line does, this way you can edit it to your own needs.
The bot flooder is meant to reach till 100. I dont recommend going up to 200 or further unless you have 16GBs of RAM.
Rickroll should work on any device.~~

~~If you have just done a rickroll and you want to switch to botting, then click Flood and Resubmit Data.
If you just botted and you want to rickroll, then click Rickroll and Resubmit Data.~~


Old Python interface. Looked old-fashioned, so I switched to C# to get a more modern GUI. 
The part about the 16GB RAM isn't true on the C# version but you'll definitely need it if you decided you want the old python version for some reason


The reason of why the Python version was a memory hog was because i was too dumb to use requests (Even though I built a whole app based on Webscraping (I'll upload it some other day))


### THIS PROJECT IS STILL UNDER DEVELOPMENT. The Python version is complete but I'd only recommend using it if you want JoinAs functionality instantly. The C# has no limit and can get an infinite amount of bots sent with just under 20MB of RAM Usage.

## TODO: 
Add a `Button Of Death` which will completely stop the teacher from seeing any work (The page wont load after it). This has been done with 0 Limit, but the pc has to remain online for the duration of the flood.
Add a better auto-shortening system that can shorten more than just 40 characters

## TODO (In terms of a complete rewrite)
Use GTK instead of WinForms so that it would have a cross-platform GUI instead of being limited to just Windows


### BUILD NOTES: Please keep in mind you have to move the config files to the build path! I included a simple Batch script that should do it for you, just be sure to run it as soon as you build it!

If you want to use JoinAs, you're gonna have to manually get a persons name (As Of Now) and enter it as command line arguments on the WebPanel executable. I'd Probably make some version later on for JoinAs, might involve Py and C# combined...
