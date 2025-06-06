# 🎹 Piano Rhythm Game

A simple rhythm-based piano game built with Unity where players hit the correct piano keys as musical notes fall down the screen.

## 🎮 Game Overview

Players watch musical notes fall from the top of the screen and must press the corresponding piano buttons at the right time to score points. The game features a 6-key piano setup (C4-A4) with visual and audio feedback.

## ✨ Features

- **6-Key Piano Interface** - C4, D4, E4, F4, G4, A4 keys
- **Falling Note System** - Visual notes spawn and fall down the screen
- **Real-time Scoring** - Points awarded for correctly timed button presses
- **Audio Feedback** - Each key plays its corresponding piano note
- **Customizable Melodies** - Easy-to-configure note sequences and timing

## 🎯 How to Play

1. Musical notes will spawn at the top of the screen
2. Notes fall down toward the piano keys at the bottom
3. Press the correct piano button when the note reaches the trigger zone
4. Score points for accurate timing and correct notes
5. Notes are automatically destroyed when they reach the bottom boundary

## 🛠️ Technical Implementation

### Core Scripts

- **`NoteSpawner.cs`** - Manages note spawning and melody playback
- **`NoteBehaviour.cs`** - Controls falling note movement and collision detection
- **`AudioController.cs`** - Handles button presses, audio playback, and scoring system

### Key Components

- **Melody System** - Configurable note sequences with custom timing
- **Trigger Zone Detection** - Precise hit detection for scoring
- **Audio Management** - Real piano sound effects for each key
- **UI Score Display** - Real-time score updates

## 📋 Setup Requirements

### Unity Components Needed:
- Canvas with UI buttons for piano keys
- Audio Source for sound playback
- Collider2D trigger zones for each button
- Note prefabs for each musical note
- Bottom boundary for note cleanup

### Assets Required:
- Piano audio clips (C4.wav, D4.wav, E4.wav, F4.wav, G4.wav, A4.wav)
- Note sprite prefabs
- TextMeshPro for score display

## 🎵 Configuration

### Setting Up Melodies
```csharp
// In NoteSpawner inspector, add melody entries:
// Note Name: "C4", Time Delay: 1.0
// Note Name: "D4", Time Delay: 2.0
// Note Name: "E4", Time Delay: 3.0
```

### Customizable Parameters
- **Fall Speed** - Adjust note falling speed
- **Spawn Positions** - Configure where each note type spawns
- **Trigger Zones** - Set hit detection areas for each button
- **Score Values** - Modify points awarded per successful hit

## 🚀 Getting Started

1. Clone/download the project
2. Open in Unity 2022.3 or later
3. Assign all prefabs and audio clips in the inspector
4. Configure melody sequences in NoteSpawner
5. Set up trigger zones for each piano button
6. Build and run!

## 🎯 Future Enhancements

- Multiple difficulty levels
- Combo system for consecutive hits
- Visual feedback effects
- Extended key range (full octave)
- Song selection menu
- High score persistence

## 📱 Platform Compatibility

- **Primary Target**: PC/Mac desktop
- **Potential**: Mobile devices with touch controls
- **Unity Version**: 2022.3 LTS or newer

## 🎼 Educational Value

This project demonstrates:
- Unity game development fundamentals
- Audio system implementation
- UI/UX design principles
- Object-oriented programming patterns
- Game timing and rhythm mechanics
- Physics-based collision detection
