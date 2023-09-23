# TroopControl

TroopControl is a simple unit control game prototype built using Unity. It features unit selection, target assignment, adjustable parameters, and camera controls.

## Unit Controls

- Units can be selected by right-clicking on them.
- Multiple units can be selected by holding down the "Shift" key during right-click.
- Holding down the right mouse button scans an area for unit selection.
- When the "Shift" key is held during selection, the newly selected group merges with the previous group.
- Clicking without "Shift" clears previous selections and selects new units.
- Clicking on an empty space clears all group selections.
- Selected units are moved to a target by left-clicking.
- Units stop in a circular formation when they reach the target.
- If the target moves away, units resume moving towards it.

## Target Controls

- Three targets are present in the level (yellow, red, blue).
- Left-clicking on a target assigns selected units to it, causing them to move toward the target.
- Targets can be dragged and dropped to new locations within the level by holding down the left mouse button.

## Adjustable Parameters

- You can dynamically adjust the movement speed of units and the distance they need to reach the target (threshold).

## Camera Controls

- Use the WASD keys to control the game camera. 
