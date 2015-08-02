# htpclauncher
Simple Launcher for HTPC Systems 

This is a simple Launcher that I've created for my HTPC.

I only use Windows for my HTPC tasks, and I need something to choose what to do, after the system start.
My HTPC uses a combination of three softwares:

- Kodi (Formelly XBMC) for playing media
- Steam for playing modern games (Using Big Picture mode)
- RetroFE for playing emulators (Retroarch is in the background!)

This launcher was built using Visual Studio 2008, but I think that you can build it, using the Express versions from Microsoft.
One thing that you have to take a look, the images to "skin" it, are compiled within the software.
I didn't do a skinning system. I'm not a programmer, I just made this little software watching videos on YouTube ! :D

So, feel free to improve it as your need! Just drop me a message, saying that you did better with it! ;)
I really need an improved version of it.

The compiled version, is a very simple executable, wich always runs on top of other windows.
There is also a XML file, that you need to configure, just to point the executables that you want to run.

The XML auto explains itself, but if in doubt, please contact me at vsilvalopes(AT)gmail(DOT)com

Right after you chose wich application to run, the software closes itself.

I recomend using Eventghost for managing the oppening and clossing of the three softwares (Kodi, Steam and RetroFE).
In my setup, I did a little routine on Eventghost to watch the three softwares, and everytime that one of those softwares process is closed, Eventghost Launches the HTPC launcher.



