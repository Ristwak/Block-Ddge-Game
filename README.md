# Block Dodge Game

A 2D endless survival game developed in Unity, where the player must avoid falling obstacles by moving horizontally between lanes. The objective is to survive as long as possible while avoiding collisions.

## Overview

Block Dodge Game is a simple arcade-style game built around obstacle avoidance and survival-based scoring.

Blocks continuously spawn across predefined positions, leaving one randomly selected lane open. The player must move between lanes to avoid incoming obstacles. The difficulty increases over time through changes in block gravity.

## Gameplay

- Control the player horizontally to avoid falling blocks.
- Obstacles spawn at predefined positions with one randomly selected position left empty.
- Survive as long as possible to increase your score.
- Colliding with an obstacle ends the current run.
- The game records and saves the highest survival time.

## Controls

| Input | Action |
|---|---|
| A / Left Arrow | Move Left |
| D / Right Arrow | Move Right |

## Technical Overview

**Engine:** Unity  
**Programming Language:** C#  
**Physics:** Unity 2D Physics (Rigidbody2D and Collider2D)  
**UI:** TextMesh Pro  
**Data Persistence:** PlayerPrefs

### Core Systems

**Player Controller**
- Handles horizontal player movement.
- Restricts movement within predefined boundaries.
- Detects collisions with obstacles.

**Obstacle Spawner**
- Spawns obstacle prefabs at predefined spawn points.
- Randomly selects an open lane for each spawning cycle.
- Controls the interval between spawning cycles.

**Obstacle Behaviour**
- Uses Rigidbody2D for gravity-based movement.
- Gradually increases gravity scaling over time.
- Removes obstacles after they leave the playable area.

**Game Manager**
- Handles game-over events.
- Prevents repeated game-over execution.
- Loads the game-over scene when the player collides with an obstacle.

**Scoring System**
- Tracks elapsed survival time.
- Maintains a separate high-score record.
- Saves the highest survival time using PlayerPrefs.

**Scene Management**
- Handles gameplay start, restart, and exit operations.

## Project Structure

```text
Block-Dodge-Game/
├── Assets/
│   ├── Scenes/
│   │   ├── Menu.unity
│   │   ├── MainLevel.unity
│   │   └── End.unity
│   ├── Script/
│   │   ├── Block.cs
│   │   ├── BlockSpawner.cs
│   │   ├── Exit.cs
│   │   ├── GameManager.cs
│   │   ├── Play.cs
│   │   ├── Player.cs
│   │   ├── Restart.cs
│   │   └── Score.cs
│   ├── TextMesh Pro/
│   └── Block.prefab
├── Packages/
├── ProjectSettings/
└── README.md
```

## Setup Instructions

1. Clone or download the repository.
2. Open the project using Unity Hub.
3. Allow Unity to import the project assets and dependencies.
4. Open the `Menu` scene.
5. Ensure the Menu, MainLevel, and End scenes are included in Build Settings.
6. Run the project through the Unity Editor.

## Dependencies

- Unity 2D Physics
- TextMesh Pro
- Unity Scene Management
- Unity PlayerPrefs

## Development

The project uses a component-based architecture with separate scripts for player movement, obstacle spawning, obstacle behaviour, scoring, and scene management.

