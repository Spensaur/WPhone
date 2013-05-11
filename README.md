git for SJSU WinPhoneMoPhoneWin7Phone8 to port Cinequest app

We started from scratch so it's probably a little rough. Our original plan had us using the deserialization feature
of Windows Phone to populate a Festival object without a parser but no dice, a parser was written instead. It's very
slow as it recreates an XmlReader rather than read top-to-bottom or restart to the head each time; instead it jumps
to each major section (films, schedules, venue locations, program items) and populates from there.

Bonus points if you get the joke at the top of this file.

The books included in this git were free books on Windows Phone development (as paid by Msoft, so take that with
a grain of salt). Since you'll be working with a Windows Phone 8 device you may have better success with the
latest and greatest APIs and such. Be warned though, whoever gets the device is going to spend quite some time on
updates and you MUST lock the device to your live/outlook/hotmail account so you MUST unlock it before handing it
back. Dr. Horstmann should have all the details you need, otherwise email me and I'll tell you the rest of what I
found out on our two month journey into Windows Phone development.

I imagine you'll be forking (heh, forking) this from Dr. Horstmann. Good luck.
-Kurt
