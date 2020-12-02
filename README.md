# TheMakeyMaker
Unity tools to experiment, create and visualize with Makey Makey for 1st year students.

# Installation
This project can be cloned from this repository or a release can be downloaded as a Unity Package from the [releases page](https://github.com/SintLucasAllStars/TheMakeyMaker/releases).
This package is built and tested on Unity version 2020.2.0b13 but should work on any relatively recent Unity release.

### Cloning
You can clone this repository and add the project to your Unity Hub.

### Using the release
Just download the latest release from the [releases page](https://github.com/SintLucasAllStars/TheMakeyMaker/releases), open a Unity project and double-click the package file. It will open the Unity import window as if you had downloaded it from the Asset Store.

This will create a `TheMakeyMaker` folder on your `Assets` folder and all the content will be there, ready for you to use.

# Contents
This package contains a few ready to use prefabs and tools to create small visualizations that react to MakeyMakey key events.
There are also a few ready to use scenes that use these tools so you can directly have some fun with and modify to your liking. These scenes are a great place to get started.

### The debug overlay
On the `__ReadyToUse__` folder you can find a prefab called MakeyMakeyDebugOverlay. If you drag this to any scene, it will add an overlay with an image of the MakeyMakey and highlight the keys being pressed (contacts active) at the moment. This overlay will be invisible by default and you can open it by pressing the **Tab** key.
You can check the inspector

### The MakeyManager
The MakeyManager holds key mapping information and offers an API to check for contacts.

### Folder structure
[WIP]
```
TheMakeyMaker
├── Classes
│   ├── MakeyManager.cs   //The MakeyManager holds key mapping information and offers a simple API.
│   ├── Singleton.cs      //Utility class
│   ├── Utils.cs          //Utility class
├── Images
├── Material
├── Models
├── PostProcessing
├── Prefabs               //Prefabs used on the example scenes (You can use these on your scenes as well).
├── Prefabs.meta
├── __ReadyToUse__        //Prefabs ready to use directly on your own scenes.
│   ├── MakeyMakeyDebugOverlay.prefab //The debug overlay, just drag it to any scene and it should work.
├── _Scenes
│   ├── Basics.unity      // A very simple scene that shows the MakeyMakey and highlights the current contacts.
│   ├── Particles.unity   // A configurable visualization of particles and attractors that react to MakeyMakey contacts.
├── Scripts
│   ├── Attractor.cs      //Used on the Particles scene
│   ├── DebugOverlay.cs   //Used on DebugOverlay
│   ├── LedIndicator.cs   //Used for the debug overlay
│   ├── Particle.cs       //Used on the Particles scene
│   ├── ParticleManager.cs //Used on the Particles scene

```

# Ideas for projects using the tools
[WIP]

# Contributing
[WIP]
