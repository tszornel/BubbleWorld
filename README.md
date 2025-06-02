# BubbleWorld

BubbleWorld is an educational bubble popping game built with Unity. Bubbles
float upward with letters inside. Players try to form words from the letters
before the bubbles disappear. The movement speed increases over time to make
things challenging. This repository contains only the Unity project files and
scripts.

## Features

- Bubbles rise from the bottom of the screen affected by a simulated wind.
- Letters are assigned randomly with higher probability for vowels.
- Target word display for players to match.
- Placeholder network manager for multiplayer support.
- Example scripts for spawning and controlling bubbles.

## Getting Started

1. Open the project in a recent version of Unity (2020 or later).
2. Create a new scene and add a `BubbleSpawner` to an empty GameObject.
3. Create a bubble prefab with a `Bubble` script, `Rigidbody2D`, and
   `CircleCollider2D`. Add a TextMeshPro element inside to show the letter.
4. Add particle systems and UI as desired. The provided scripts are minimal
   and meant to be extended.
5. For multiplayer, integrate a networking solution such as
   [Mirror](https://mirror-networking.com/) and replace `SimpleNetworkManager`
   with the appropriate components.

## License

This project is provided as a starting point. Feel free to modify and extend
it for your own educational games.
