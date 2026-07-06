# Smartshooter

A solo VR laser-gun shooting range game built in Unity and deployed to the Meta Quest 3, designed to train a player's accuracy, speed, and decision-making across two escalating levels.

## Gameplay

- **Level One** — targets randomly appear and disappear down range. Hitting enough targets opens the door to level two, building reflexive accuracy under time pressure.
- **Level Two** — the player faces a grid of targets but can only see the starting and goal targets at first. Targets adjacent to a hit target become visible as the player clears a path, so the player has to shoot their way from the start target to the goal target through a hidden layout — turning the level into a real-time pathfinding puzzle rather than a simple reflex test.

## Technical highlights

- The standout feature is the **grid data structure behind level two**: target adjacency and visibility state are tracked and updated live as the player hits each target, revealing the local neighborhood instead of the whole grid.
- Built entirely in Unity (C#) and deployed to the Meta Quest 3, using Unity's XR Interaction Toolkit to handle VR controller input, hand tracking, and object/weapon interactions.

## Tech

Unity, C#, Unity XR Interaction Toolkit, Meta Quest 3 (Meta XR SDK).
