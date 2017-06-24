OpenCV Plugin
=============

[<img align="right" src="https://raw.github.com/Brandon-Wilson/OpenCV-Plugin/master/Plugins/OpenCV/Resources/Icon128.png" width="128" height="128"/>](https://raw.github.com/Brandon-Wilson/OpenCV-Plugin/master/Plugins/OpenCV/Resources/Icon128.png)
A simple OpenCV plugin that integrates the OpenCV library into UE4. The plugin includes some blueprint classes that demonstrate how OpenCV can interact with the engine.

Installing
----------

You have a couple options for installation:

* Copy and merge all folders into an existing project's root directory.  This project will need source code so that it looks in the binaries folder for the OpenCV libraries. If you don't have any source code, open the editor and add c++ source in the file menu.

* Alternatively, you could add the binaries to the system's path variable, or add them directly to the engine's binaries folder. (this isn't recommended)

Afterwards, be sure to regenerate project files. For visual studios, right click your project (.uasset) file and select 'generate visual studio project files' after deleting your previous visual studios file.
 
Usage
-----

Add the "OpenCV" public module dependency to your project's Build.CS file to write custom OpenCV code in your project.

Enable the Computer Vision > OpenCV plugin in the editor's Edit > Plguins menu to gain access to the blueprint classes in-editor.

For an in-depth description of the plugin, please see the [tutorial.](https://wiki.unrealengine.com/Integrating_OpenCV_Into_Unreal_Engine_4)

License
=======

Licensed under the BSD License. Please see the LICENSE file included with the plugin's source code.