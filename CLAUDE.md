# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a Unity 3D game project (Unity 6000.2.15f1) called ProjectPralay_Unity featuring a third-person character controller system. The project uses Universal Render Pipeline (URP) and includes comprehensive character locomotion with animations, input handling, and camera controls.

## Unity Development Commands

Since this is a Unity project, development is primarily done through the Unity Editor. No build scripts or command-line tools are configured.

### Project Structure

```
Assets/
├── FinalCharacterController/        # Main character controller system
│   ├── Scripts/                     # C# scripts for character behavior
│   │   ├── PlayerController.cs      # Core character movement and physics
│   │   ├── PlayerState.cs           # Movement state management
│   │   ├── PlayerAnimation.cs       # Animation controller
│   │   └── Input/                   # Input system components
│   ├── Animation/                   # Character animations and controllers
│   ├── Prefabs/                     # Character controller prefabs
│   └── Scenes/                      # Demo scenes
├── GhostSamurai_Animset/           # Character model and animations
├── Scenes/                         # Main project scenes
└── Settings/                       # URP render pipeline settings
```

## Character Controller Architecture

### Core Components
- **PlayerController** (`Assets/FinalCharacterController/Scripts/PlayerController.cs`): Main character physics and movement logic
- **PlayerState** (`Assets/FinalCharacterController/Scripts/PlayerState.cs`): Manages movement states (Idling, Walking, Running, Sprinting, Jumping, Falling)
- **PlayerLocomotionInput** (`Assets/FinalCharacterController/Scripts/Input/PlayerLocomotionInput.cs`): Handles input via Unity's Input System

### Movement System
The character controller uses a state-based movement system with these states:
- **Idling**: No movement input
- **Walking**: Slow movement (togglable)
- **Running**: Default movement speed
- **Sprinting**: Fast movement (hold/toggle)
- **Jumping/Falling**: Airborne states

### Input System
Uses Unity's new Input System with PlayerControls.inputactions asset. Input is handled through:
- Movement (WASD/joystick)
- Camera look (mouse/right stick)
- Jump (spacebar/button)
- Sprint toggle (shift/button)
- Walk toggle (caps lock/button)

### Key Features
- Physics-based movement with acceleration/deceleration
- Slope handling and step offset adjustment
- Camera-relative movement direction
- Smooth character rotation to face movement direction
- Ground detection with different logic for grounded vs airborne states
- Drag and gravity simulation

## Package Dependencies

Key Unity packages in use:
- `com.unity.inputsystem`: New Input System for player controls
- `com.unity.cinemachine`: Advanced camera systems
- `com.unity.render-pipelines.universal`: URP rendering
- `com.unity.ai.navigation`: Navigation mesh system
- `com.unity.probuilder`: Level design tools

## Scene Organization

- **LocomotionTest.unity**: Primary testing scene for character controller
- **LocomotionTest_Final_IK.unity**: Character controller with Final IK integration
- **PlayGround_Design.unity**: Level design playground

## Development Notes

- Character controller uses namespace `GOC.FinalCharacterController`
- Uses execution order attributes to ensure proper component initialization
- Includes debug print statements for velocity monitoring
- Ground layer detection configured via LayerMask
- Camera rotation and character model rotation are handled separately for smooth gameplay

## Testing the Character Controller

Open `LocomotionTest.unity` scene and use:
- WASD: Move character
- Mouse: Look around
- Space: Jump
- Shift: Sprint (hold/toggle)
- Caps Lock: Walk mode toggle