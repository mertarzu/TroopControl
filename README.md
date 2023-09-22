TroopControl
A simple unit control game prototype. Unity Navmesh was used for pathfinding in a maze-like section.
Unit Controls
Units can be selected by right-clicking on them, and multiple units can be selected by holding down the "Shift" key. Holding down the right mouse button scans an area, and units within that area are selected. If the "Shift" key is held down while selecting, the newly selected group is merged with the previous group to form a single group. Each time an area selection or click is made without pressing the "Shift" key, the selections from the previous group are cleared, and the newly selected units become active. Clicking on an empty space clears the group selections. Selected units are moved to a target by left-clicking. When units reach the target (or get close enough), they stop, but if the target moves away, they resume moving towards the target. 
Target Controls
Within the created level, there are three targets (yellow, red, blue). When left-clicked on these targets, selected units are assigned to the respective target, and units start moving toward that target. Targets can be dragged and dropped to the desired location within the level by holding down the left mouse button.
Parameters
The movement speed of units and the distance to reach the target (threshold) should be dynamically adjustable.
Camera Controls
The game camera can be moved using the WASD keys. 