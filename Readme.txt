Name: Junze Liu
Assignment Name: Programming Assignment 1, Part I
 
------------------------------------------------------------------------
A. Required elements
 Part I:
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
 - The maximum tilting angle of the board is 20 degrees
 - Each gameobject is associated with a color and the ball has a metallic appearance
 - Ball will bounce off the walls in contact

 Part II:
 - The ball has ability to jump and the jump height is high enough for the ball to hop
 	over the wall
 - The inner walls are generated randomly with fixed hinge position and there is no wall
 	at the location where the ball initally falls.
 - The wall randomly swings clockwise or counterclockwise for 90 degrees
 - 6 Pick-ups (stars) are randomly generated on the board and they are constantly rotating.
 	The pick-up is the same pick-ups that I used in Part I.
 - The player needs to pick up 2 stars before he/she can proceed to the finish point.
 - 2 UI Text element are placed on upper left and right corner of the game window. The left
 	upper corner will show number of remaining pick-ups that the player needs to get before
 	he/she can go to the end and the right upper corner indicates if the player win or lose 
 	the game.
 
------------------------------------------------------------------------
B. Additional elements

 Part I: 
 - Collecting Stars
  -- The player can collect the stars that are lying around on the platform. The number of stars that collected has no affect on the completion of the game
  -- The stars are scripted with self-rotation and halo "blinking" affect
  -- The 3D model of the star is created by myself in blender and imported to Unity
  -- The blender file of the 3D model can be found under \Assets\Resourcces\Models\starSpin.blender

 - Text UI
  -- A text UI is located at the upper left corner of the game
  -- The UI keeps track the number of stars that is collected by the player
  -- It display game completion message with the total number stars collected by the player when the player reaches the goal.
 
 Part II:
  - Inner Wall
   -- Made a 3D barrier model myself and the file is inside \Assets\Resources\Models\barrier.blender

------------------------------------------------------------------------
C. Known issues
 Part I:
 - When it stuck between two walls near the end point, user needs some move-arounds to
 	get the ball out from the gap

 Part II:
 - The barrier will swing more than 90 degrees, so I reset it to nearest 90 degrees when the swing finished. Therefore, there is always a little giggling affect when the walls finished swing.

------------------------------------------------------------------------
D. External resources
 - No external resource is involved in this project except the 3D model that made by myself which
 	I mentioned in "Additional Elements" section.
