Selenium WebDriver Page Recorder XWT UI
=======================================
This is skeleton project to port the [Selenium WebDriver Page Recorder](https://github.com/sergueik/swd-recorder) UI 
to [XWT](https://github.com/mono/xwt)


Note 
====
Install  Gtk# [does not](http://stackoverflow.com/questions/16417342/mono-gtk-hello-world-deploy-to-windows) seem to configure the dependencies accurately. 
Build XwF from source first, place dlls into `../vendor/xwt` directory.

Copy the contents of the `"c:\Program Files\GtkSharp\2.12\lib\gtk-sharp-2.0"` folder into `../vendor/xwt` directory. 
Copy C:\Program Files\GtkSharp\2.12\lib\Mono.Cairo\Mono.Cairo.dll to into `../vendor/xwt` directory. 
Note you do not need to install Mono on the box.
There is a [packaged solution](https://github.com/mono/xwt/issues/444)



Author
------
[Serguei Kouzmine](kouzmine_serguei@yahoo.com)