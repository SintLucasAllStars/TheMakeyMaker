# TheMakeyMaker
Unity tools to experiment, create and visualize with Makey Makey for 1st year students.

# Installation
There are 2 ways to work with this project. It can be cloned from this repository or a release can be downloaded as a Unity Package from the [releases page](https://github.com/SintLucasAllStars/TheMakeyMaker/releases).
This package is built and tested on Unity version 2020.2.0b13 but should work on any relatively recent Unity release.

### Dependencies
This package depends on Unity's Post-processing package. If you clone this repository, You don't need to install anything, but if you import the package into your own project then you might have to open Window -> Package Manager, select "Unity Registry" or "all" (depends on the Unity version) and search for "PostProcessing" and install it.

### Cloning this repository
You can clone this repository and open the project through your Unity Hub.

### Using the release
Just download the latest release from the [releases page](https://github.com/SintLucasAllStars/TheMakeyMaker/releases), open a Unity project and double-click the package file. It will open the Unity import window as if you had downloaded it from the Asset Store.

This will create a `TheMakeyMaker` folder on your `Assets` folder and all the content will be there, ready for you to use.

# Contents
This package contains a few ready to use prefabs and tools to create small visualizations that react to MakeyMakey key events.
There are also a few ready to use scenes that use these tools so you can directly have some fun with and modify to your liking. These scenes are a great place to get started.

## Scenes
### The Basics scene
This is a very simple scene to test your MakeyMakey and/or your setup and see if all is working as expected. This scene just draws a MakeyMakey to the screen and highlights the contacts being made.

### The Particles scene
This is a scene that allows you to create simple unoptimized but very easy to modify and control particle systems. with force fields (attract / repel / destroy) That can react to contacts on the MakeyMakey.
You can easily attach a MakeyMakey key to activate each ForceField and make interesting games and installation experiences out of modifying this scene. The scene is configured to react to the arrow keys.
All the tools you need to create a scene like this are in the folder `__ReadyToUse__/Particles/`.

## The "Ready to Use" folder
### Debug overlay Prefab
The prefab is called MakeyMakeyDebugOverlay. If you drag this to any of your scenes, it will add a canvas overlay with an image of the MakeyMakey and highlight the keys being pressed (contacts active) at the moment. This overlay will be invisible by default and you can open it by pressing the **Tab** key.
You can check the inspector to set the key to show/hide the overlay and the default (initial) value.

### Particle prefabs
On the `Particles` folder you can find the following prefabs that help you to create particle based installations/games/experiences:

#### ParticleEmmiter
This is a GameObject you can place on your scene and it will release particles. You can configure it on the inspector after you added it to your scene:
* **Num Particles**: How many particles to release.
* **Release Mode**:
  - At Once: Release all particles at once on start.
  - Timed: Release a set number of particles at a time in a fixed interval.
* **Release Pulse In Seconds**: This works only when Timed release mode is selected. It configures the interval at which particles are released.
* **Particles Per Pulse**: This works only when Timed release mode is selected. It configures the amount of particles to release on each interval.
* **Particle Prefab**: This is the GameObject that will be used as a particle. You can use the examples provided or make your own. Keep in mind that this emmiter will control the `transform.position` and `transform.rotation` of the instantiated particles.
* **Speed**: The speed of the particles that will be emitted by this emitter.
* **Gravity**: This is to avoid particles from getting lost in the scene or to organize them. The particles will be constantly attracted to their own emmiter. You can disable this by setting this value to 0.
* **Keep Emitting**: Should this emitter create new particles when the initial ones die or get destroyed.

#### Attractor Prefab
The Attractor prefab is a `ForceField` configured to attract particles when you press a key/contact on the MakeyMakey. If you look at the inspector, on the `ForceField` component you will be able to configure:
* **Mode**:
  - Attract: Attract the particles when active.
  - Repel: Repel the particles when active.
  - Destroy: Destroy the particles if active and they get within range.
* **Respond To**: Which MakeyMakey key/contact to activate this force field.
* **Responsive**: If this is set, the force field will only be active when the key configured in "Respond To" is pressed. If this is not set, then the force field will be always active.
* **Strength**: The maximum attract/repel strength of this forcefield (it fades with distance up to range).
* **Range**: The range within which particles will be affected by this force field.

**Note:** You can create and configure your own force field by adding the `ForceField` component to any GameObject.

#### Destroyer Prefab
A variant of the Attractor prefab but configured to destroy particles that get too close (that get within range).

#### Example particles
There are a few particle prefabs you can use with `ParticleEmmiter`. But you can create any GameObject you like, make it into a prefab and drag it into the `ParticleEmmiter` and it will instantiate and control them. You just need to keep in mind 3 things:
1. The `transform.position` and `transform.rotation` will be controlled by the emitter so don't try to change it yourself in your scripts.
2. Keep in mind that the more complex your particle is, the more performance impact you will have. Lots of these will be instanciated.
3. Particle prefabs don't need `RigidBody` or `Collider` components and they will not work properly with Unity's physics because their `transform.position` is being set every frame.

## Scripting tools
### The MakeyManager
The MakeyManager holds the MakeyMakey key mapping information and offers a simple API to check for contacts. There is no need to put this on any scene or GameObject. It basically takes care of itself.

You can use it by directly calling one of the following functions on `MakeyManager.Instance` in any of your scripts:
#### RemapKey(Key key, KeyCode keycode)
If you have remapped or have a pre-remapped MakeyMakey and you don't want to reset it to factory default you can call this function to remap your keys

example:
```C#
//In any of your script's Start() function
//If you, for example, remapped the makeymakey's Up Arrow key to the letter P
MakeyManager.Instance.RemapKey(MakeyManager.Key.UpArrow, KeyCode.P);
```

#### GetKey(Key key)
Check if a contact is active (key is being pressed) right now. returns `true` every frame while the key is pressed.

```C#
if(MakeyManager.Instance.GetKey(MakeyManager.Key.UpArrow)){
  //Do something
}
```


#### GetKeyDown(Key key)
Check if a contact was made (key was pressed) on this frame. returns `true` only on the frame that the key is pushed down (contact was made).

```C#
if(MakeyManager.Instance.GetKeyDown(MakeyManager.Key.Space)){
  //Do something
}
```

#### GetKeyUp(Key key)
Check if a contact was broken (key was released) on this frame. returns `true` only on the frame that the key is released.

```C#
if(MakeyManager.Instance.GetKeyUp(MakeyManager.Key.Space)){
  //Do something
}
```


## Folder structure
**[Out of date]**
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

#### Particle pressure
Make some pressure plates, stomping pads (see below) or other contacts.

Beam the particle scene into an interesting surface.

Position the Attractors and the ParticleManagers in interesting locations on the projection. Keep in mind that you can set both permanent (always on) and reactive (to a MakeyMakey key) attractors and you can set each attractor to either attract or repel the particles and set their range and strength. Also you can create multiple Particle managers that can spawn different color particles in different locations.

Place the pressure plates (or other contacts) on top of the reactive attractors, set up the keys they react to match.

Now you can push the pressure plates to attract/repel the particles from that location.

You can create mechanics with 2 or more players where you need to either co-operate or compete to get the particles to reach a certain spot or behave in a certain way.

Or just make them look nice.

## Physical inputs and tools

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
Three layers of material (cardboard, wood, etc...), two layers are contacts (ground and key) made with aluminum foil and the middle layer is an isolation layer with hole(s). Cover this isolation layer with tape in one side because contacts sometimes pass through cardboard.

![Step 1](/DocImages/20201203_123026.jpg)

![Step 1](/DocImages/20201203_124036.jpg)

![Step 1](/DocImages/20201203_125852.jpg)

![Step 1](/DocImages/20201203_130804.jpg)

[![IMAGE ALT TEXT HERE](http://img.youtube.com/vi/18AUZHwnVkE/0.jpg)](http://www.youtube.com/watch?v=18AUZHwnVkE) 

#### Stomping pads
Same as the pressure plates but for your feet. Same construction, the only difference would be size of the pad itself and size of the holes in the middle layer.

#### The twister
(At least) two key contacts and a ground contact positioned in a way that you can only activate one at a time and to switch you need to swap hands or get extra creative with your body.

# Contributing to this project
Contributions are welcome, you can fork this repository, add tools, example scenes or fix bugs and then send me Pull Requests and I will happily review and merge them.
