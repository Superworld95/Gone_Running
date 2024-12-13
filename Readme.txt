Ninja model from Mixamo.
Repository Link: https://github.com/Superworld95/Gone_Running

Shaders on:
Player - Occasional
Wall - Yellow overlay
Enemies - Red pentagon
Moon

Particle trails on:
Moon
Player - running, jump, teleport
Enemies

Object Pooling:
In the Pooler object, there are walls and enemies. In respective scripts, they are called when the player gets close.

Controls:
A/D - Move
Space - Jump
Jump mid-air above horizon - Teleport Dash
Move + Teleport-Dash - Side Teleport Dash

Objective:
Endless runner. Run endlessly until being defeated. Enemies do minor damage, while walls reset the game.
At a certain point, a new round starts. The player is slightly faster.
Can manually speed up or slow down to control the pace of the game.
Pause at any time to take a break.

After a few rounds, the camera angle changes.

The light rotates, creating a time-of-day effect. The Moon object follows this rotation.