Ninja model from Mixamo.
Repository Link: https://github.com/Superworld95/Gone_Running

Shaders on:
Player - Occasional
Wall - Yellow overlay
Enemies - Red pentagon
Moon

Particles on:
Moon
Player - running, jump, teleport

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
Pause at any time to take a break.

The light rotates, creating a time-of-day effect. The Moon object follows this rotation.