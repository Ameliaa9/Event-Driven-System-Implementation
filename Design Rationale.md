# Design Rationale and Gameplay Impact

## 1. Design and Event Flow of the System
My game is a short maze game where the player must avoid obstacles and reach the end of the maze. The player needs to navigate through the maze, avoiding obstacles that could damage them. If the player’s health reaches zero, they lose the game and can start over. If they reach the end of the maze without dying, they win.

## 2. Modularity and Gameplay Responsiveness

### Modularity
I set up obstacles and text triggers in a modular way. I created one obstacle with the necessary code and colliders, then copied it and placed it throughout the maze. This approach makes it easy to make changes later. For example, if I want to modify how an obstacle works, I can just update the script, and since the script is attached to all of the same obstacles, the changes will automatically apply to all of them. This keeps everything organized and makes it easier to manage.

### Responsiveness
The events make the game react quickly to the player’s actions. For example, when the player hits an obstacle, the game checks their health. If their health reaches zero, the "Game Over" screen appears immediately. Similarly, when the player finishes the maze, the "You Win" screen pops up right away. Since the obstacles and triggers are modular, the game can handle these events smoothly and without glitches. The event system ensures that everything happens instantly and consistently.

## 3. Challenges and Solutions During Development

### Challenges:
- At first, the scenes weren’t working properly. When I pressed the menu button, it wouldn’t bring me back to the menu screen.
- When I tried building the game, some screens didn’t show up as expected.
### Solutions:
- I fixed the scene switching issue by changing the order of the scenes in the build settings.
- I solved the issue with missing screens by removing the screens from being a child of a canvas.
