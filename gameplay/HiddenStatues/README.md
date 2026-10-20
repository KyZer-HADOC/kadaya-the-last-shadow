# Kadaya — Hidden Statues

First gameplay patch for statues Kadaya can hide inside to evade enemies. This is an add-on; it does not replace any recovered level scene.

## Behavior
- Walk close to a statue and press **E** to enter.
- Kadaya's renderers and Animator are hidden, configured movement/attack scripts pause, and physics movement is frozen.
- Press **E** again to emerge at the statue's exit point.
- A mobile HUD button can call HideStatue.OnInteractButton().
- An optional Unity UI Text can show the context prompt.
- Enemy scripts can call KadayaHideState.IsHiddenTarget(playerTransform) or check KadayaHideState.AnyPlayerHidden before detecting/attacking a concealed player.

## Unity setup
1. Import the included Assets folder into the recovered Unity project.
2. Add KadayaHideState to Kadaya's root Player GameObject.
3. In Disable While Hidden, drag the player's movement, input, dash, and attack MonoBehaviour components. Do not add KadayaHideState.
4. Add HideStatue to a statue GameObject. Assign the Player transform (or ensure its tag is Player).
5. Create child empty GameObjects named HideAnchor and ExitAnchor. Place them inside/just beside the statue, then assign them.
6. Optionally assign a Unity UI Text prompt, or wire a mobile Button to OnInteractButton().
7. In enemy targeting code, skip target acquisition while KadayaHideState.IsHiddenTarget(playerTransform) is true. Hiding the visuals alone cannot override enemy scripts that directly follow a cached player Transform.

## Visual direction
Use dark stone, ash-black cracks, and a faint red glow. The statue should read as environmental cover, not a shop or premium unlock. Hiding is reusable by default and does not consume currency.

## Important
The recovered project came from a compiled Android game. Original scripts may be incomplete shells, so player movement and enemy detection must be connected in Unity and tested in a copy of the target scene before publishing. No existing level scenes are overwritten by this patch.
