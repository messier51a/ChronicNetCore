# ChronicNetCore
# Introduction
This is a .NET Core version of the natural language date/time parser originally ported from Ruby by Robert Wilczynski
# Usage
DateTime.Now;   //Sat May 13 23:18:25 PDT 2017
var dateTime = ChronicNetCore.Parse('tomorrow').ToTime(); //Sun May 14 12:00:00 PDT 2017
dateTime = ChronicNetCore.Parse('monday', new Options() { Context = Pointer.Type.Future }).ToTime(); // Mon May 15 12:00:00 PDT 2017
dateTime = ChronicNetCore.Parse('this tuesday 5:00').ToTime(); //Tue May 16 17:00:00 PDT 2017
For more information and examples visit https://github.com/mojombo/chronic
# Credits
This is a port of https://github.com/robertwilczynski/nChronic. Please see this project for further credits.
Icon made by Madebyoliver from www.flaticon.com 
# License
Unless specified otherwise all is licensed under the MIT license.
