Selenium WebDriver Page Recorder XWT UI
=======================================
This is skeleton project to port the [Selenium WebDriver Page Recorder](https://github.com/sergueik/swd-recorder) UI 
to [XWT](https://github.com/mono/xwt)


Build Note 
==========
On Windows, If Mono is not installed properly to GAC, and Gtk# [does not](http://stackoverflow.com/questions/16417342/mono-gtk-hello-world-deploy-to-windows) seem to somehow misconfigure the dependencies accurately, still can build:
- build xwt-master from source, place Xwt*dllfrom into `../vendor/xwt` directory.

 - copy the contents of the `"c:\Program Files\GtkSharp\2.12\lib\gtk-sharp-2.0"` and C:\Program Files\GtkSharp\2.12\lib\Mono.Cairo\Mono.Cairo.dll to into `../vendor/xwt` directory. 
Note you do not need to install Mono on the box.
There is a [packaged solution](https://github.com/mono/xwt/issues/444)

To build on OSX 10.7 or Linux Ubuntu 12.04

- for Linix install mono-devel with dependencies as listed in http://packages.ubuntu.com/search?keywords=monodevelop
- for OSX install mono mdk from http://www.mono-project.com/docs/about-mono/supported-platforms/osx/
- failed to find a working past bild of xamarin for 10.7 ML. Candidates are builds 4.x
- in console as root: 
- build xwt-master (somewhat patched xwt project - removed all native project from solution)
- copy Xwt*dll from xwt-master/Testing/bin/ to xwt_swd/vendor/xwt
- on Linux change TargetFrameworkVersion v4.5 to v4.0
- build xwt_swd
- on OSX make env setting http://forums.xamarin.com/discussion/1331/fix-for-the-problem-finding-glibsharpglue-2-lib-using-mono-to-run-an-exe-app-mono-3-1-1-mac-10-8
 `export DYLD_FALLBACK_LIBRARY_PATH=/Library/Frameworks/Mono.framework/Versions/Current/lib:/lib:/usr/lib`
- run in console
 `mono UI/bin/Debug/UI.exe`

Author
------
[Serguei Kouzmine](kouzmine_serguei@yahoo.com)
