Author: Junze Liu
Date: 2/4/2017
Project: Tilt Game

- Extra features
 # Collecting Stars
  ## The player can collect the stars that are lying around on the platform. The number of stars that collected has no affect on the completion of the game
  ## The stars are scripted with self-rotation and halo "blinking" affect
  ## The 3D model of the star is created by myself in blender and imported to Unity
  ## The blender file of the 3D model can be found under \Assets\Models\starSpin.blender

 # Text UI
  ## A text UI is located at the upper left corner of the game
  ## The UI keeps track the number of stars that is collected by the player
  ## It display game completion message with the total number stars collected by the player when the player reaches the goal.

  Name: Junze Liu
Assignment Name: Programming Assignment 1, Part I
 
------------------------------------------------------------------------
A. Required elements
 - The ball's initial position is floating above the sparting point,
 	when the game is running, it will drop onto the board
 - Four Walls enclosed the board and some walls are acting as barriers within
 	the board
 - Use the arrow keys to tilt the board.
 - Maneuver the ball into the green circle to complete/win the game
 - The green circle has a particle system that emit circular particles
 - When the ball reaches the green circle, it will rise up and out of the sight of
 	the camera.
 - Press 'Q' to quit the game
 - Press 'R' to reset the game to the intial state
 - The maximum tilting angle of the board is 10 degrees
 - Each gameobject is associated with a color and the ball has a metallic appearance
 - Ball will bounce off the walls in contact
 
------------------------------------------------------------------------
B. Additional elements
 
 - Collecting Stars
  -- The player can collect the stars that are lying around on the platform. The number of stars that collected has no affect on the completion of the game
  -- The stars are scripted with self-rotation and halo "blinking" affect
  -- The 3D model of the star is created by myself in blender and imported to Unity
  -- The blender file of the 3D model can be found under \Assets\Models\starSpin.blender

 - Text UI
  -- A text UI is located at the upper left corner of the game
  -- The UI keeps track the number of stars that is collected by the player
  -- It display game completion message with the total number stars collected by the player when the player reaches the goal.
 
------------------------------------------------------------------------
C. Known issues
 - When it stuck between two walls near the end point, user needs some move-arounds to
 	get the ball out from the gap

------------------------------------------------------------------------
D. External resources
 - No external resource is involved in this project except the 3D model that made by myself which
 	I mentioned in "Additional Elements" section.
