# rock-of-ages
An optional project for the More C# Programming and Unity course of the C# Programming for Unity Game Development Specialization by the University of Colorado via Coursera

## Description

Project Description

You've decided that it's better to burn out than fade away, so you're going to build a game with rock(s). If you don't speak German, you might even mumble some German-sounding gibberish (Gunter glieben glauchen globen) as you code ....

In this project, you'll spawn a random rock with a random velocity every second, making sure there are never more than 3 rocks in the game window. When a rock leaves the game window, that rock gets destroyed.

Learning Objectives

The learning objectives for this assignment are:

● Use the Unity Editor to add sprites and game objects to a game.  

● Create scripts and attach them to game objects to implement game object behavior.

● Use the Physics 2D system from within scripts to move game objects.

● Build and use prefabs in a Unity game.

● Develop C# code that makes decisions using the if statement.

mplementation Steps

Now that you've made it to the second course in the Specialization, these aren't really implementation steps. Instead, they're functional requirements; you have to figure out how to implement them on your own. Here's what your solution has to do:

● Start with an empty window. Don't worry, your first rock should appear after about a second

● Every second, if there are fewer than 3 rocks in the window, spawn a new rock, centered in the window, with a random sprite. You should use the random velocity code I provided to get the new rock moving, though you might need to change the MinImpulseForce and MaxImpulseForce values to make sure your rocks don't move too fast. In other words, make sure the resulting speed is slow enough that you get to see all 3 rocks in the window before any of them disappear

● When a rock leaves the window, it should destroy itself. It will be replaced by the functionality in the previous bullet within a second

Helpful Hints

You'll obviously need to write Rock and RockSpawner scripts to implement the required functionality and attach them to your Rock prefab  (yes, you should use a prefab) and the Main Camera, respectively. You'll probably find the Spawning Teddies lecture helpful as you implement RockSpawner the script.

To count the rocks that are currently in the game, you might find it useful to tag your Rock prefab so you can use the GameObject FindGameObjectsWithTag method to get all the rocks. If you just access the Length property of the array object returned by that method, you can find out how many rocks are currently in the game.

You should add an OnBecameInvisible method to your Rock script; this method will get called when the game object the script is attached to is no longer visible to the camera (at which point you can destroy the game object). Reference the documentation in the Unity Scripting Reference as necessary to learn more about that method.

You can confirm that the rocks are being destroyed by watching the Hierarchy window as the game runs. Game Objects are added when they're spawned and removed when they're destroyed.

Caution: Even if your code is working properly, so a player could play the built game and everything would work perfectly, it may not seem to be working in the Unity Editor. Specifically, the rocks may not be destroyed immediately when they leave the Game window. That's because, in the Unity Editor, the Scene window is rendered using a camera as well, so OnBecameInvisible isn't called until the rock the leaves the views of BOTH the game camera and the Scene window camera. The best thing to do is to build the game and play the built game. If, however, you want to just stay in the editor, double click the Main Camera in the Hierarchy window, then use Ctrl + Middle Mouse Wheel to zoom in on the Scene view until the box that shows the edges of the camera view just disappears from view.

Testing Your Game

Here are the rubrics we used in previous versions of the course to confirm that the game functioned correctly:

1. New rocks spawned in the center of the window with a random rock sprite (randomness can result in multiple rocks with the same sprite in a row. As long as all 3 rock sprites eventually appear, the solution is behaving correctly)

2. New rocks immediately start moving with a random velocity

3. A new rock is spawned approximately every second until there are 3 rocks

4. There are never more than 3 rocks in the window

5. Rocks that leave the window are replaced with a new rock spawned in the center of the window with random rock sprite and random velocity after no more than 1 second

## Getting Started

n/a

### Dependencies

* Windows 10
+ Microsoft Visual Studio
+ .NET
+ Unity

### Installing

* Download link: [Github Repository](https://github.com/lyndonpanton/rock-of-ages)

### Executing program

n/a

## Help

n/a

## Authors

Lyndon Mykal Panton
[lyndonpanton](https://github.com/lyndonpanton/)

## Version History

* 0.1
    * Initial Release

## License

n/a

## Acknowledgments

Problem provided by the _University of Colorado_ and _Coursera_
