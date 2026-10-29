# Scene Editor — places of a novel without hand-written JSON

The Scene Editor is a window over the running game for the places of a visual novel: a scene's backgrounds, its ambient sound, its default scenario and the list of its scenarios. A saved scene is known to the game at once, and **Go to scene** takes you there, so you can build a place and walk into it without restarting.

## Opening it

Press the hammer button on the in-game toolbar and choose **Scene Editor** in the tool box. The window stays open across scene changes; it can be moved, resized and closed with the cross.

## Making a new place

![The Scene Editor with my_novel_town of the novel template selected: the scene list on the left, the town_entry background in the middle and in the scene's backgrounds, Save to my_novel_game and the scene's scenario my_novel_town on the right.](assets/scene-editor.jpg)

1. Press **+ New scene**, type the scene id (latin letters, digits and `_`; `switch_scene` and scenario headers refer to it) and pick the mod in **Save to**.
2. Pick a background in the list and press **+ Add background to scene** (or double-click it). A scene can have several backgrounds; one is picked at random when the scene is entered.
3. Choose a **Sound** (the play button lets you listen) and, if you like, the default scenario that plays when no other scenario of the scene is left.
4. **Save** (Ctrl+S) writes `scenes/<id>.json` into the chosen mod.
5. **+ New scenario** creates a scenario file for this scene in the chosen mod. With `scenario_editor` installed, the file opens there at once; **Open** (or a double-click) opens an existing scenario of the scene.
6. **Go to scene** ends the running dialog and enters the scene.

## Whose files are written

A scene is the sum of the `scenes/<id>.json` files of all mods. The editor writes only the file of the mod chosen in **Save to**, and only mods installed as folders can be chosen. Backgrounds and settings that come from other mods' files are shown locked; editing a foreign scene creates a file in your mod that adds to it. **Delete** removes only the chosen mod's file.

## If something goes wrong

- **Open is greyed out.** The scenario editor is not installed; add `scenario_editor` (or the Developer Tools toolset). New scenario files can still be created.
- **Save to lists no mods.** Only folder mods can be written to; packed `.zip` mods are read-only.
- **A new background or sound is missing in the lists.** Press **Rescan** after adding files to a mod.

## Dependencies

`tools_base`, `scenario_tools_base`, `dialog_base`, `ui_base`. Optional: `scenario_editor` for **Open**.
The older `editor_tools` package installs this mod together with the other authoring windows.
