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
[WIP]
The MakeyManager holds key mapping information and offers an API to check for contacts. There is no need to put this on any scene or GameObject. It basically takes care of itself.

### The particles scene
[WIP]
This is a scene in the folder `_Scenes` that allows you to create simple unoptimized but very easy to modify particle systems. with attractors and repelents.
You can easily attach a MakeyMakey key to activate each attractor and make interesting games and installation experiences out of modifying this scene.

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

## Example projects
[WIP]

#### Particle pressure
Make some pressure plates, stomping pads (see below) or other contacts.

Beam the particle scene into an interesting surface.

Position the Attractors and the ParticleManagers in interesting locations on the projection. Keep in mind that you can set both permanent (always on) and reactive (to a MakeyMakey key) attractors and you can set each attractor to either attract or repel the particles and set their range and strength. Also you can create multiple Particle managers that can spawn different color particles in different locations.

Place the pressure plates (or other contacts) on top of the reactive attractors, set up the keys they react to match.

Now you can push the pressure plates to attract/repel the particles from that location.

You can create mechanics with 2 or more players where you need to either co-operate or compete to get the particles to reach a certain spot or behave in a certain way.

Or just make them look nice.

## Physical inputs and tools
[WIP]

#### Interesting materials/tools to have at hand (Besides the MakeyMakey and the alligator clips)
* Cardboard
* Aluminum foil
* Long conductive wire (The more the better)
* Scissors or/and cutter
* Glue
* Gaffer/Duct tape
* Beamer with support/tripod
* Switches (Can be scavenged from retired electrics/electronics)
* PushButtons (Can be scavenged from retired electrics/electronics)
* LEDs
* 5V DC motors
* Computer cooling fans
* 5V input, 220V output Relay (Careful!!!)

#### Pressure plate
[WIP] Three layers of material (cardboard, wood, etc...), two layers are contacts (ground and key) made with aluminum foil and the middle layer is an isolation layer with hole(s).

#### Stomping pads
Same as the pressure plates but for your feet. Same construction, the only difference would be size of the pad itself and size of the holes in the middle layer.

#### The twister
[WIP] (At least) two key contacts and a ground contact positioned in a way that you can only activate one at a time and to switch you need to swap hands or get extra creative with your body.

#### Arcade machine as a button
[WIP]

# Contributing to this project
[WIP]
