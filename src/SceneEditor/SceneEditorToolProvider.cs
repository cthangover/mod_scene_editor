using Cthangover.Core.UI.Tool;
using Godot;

namespace Cthangover.Tools.SceneEditor
{
    /// <summary>Registers the scene editor window opened from the in-game toolbox.</summary>
    public class SceneEditorToolProvider : IToolProvider
    {
        /// <summary>Unique tool identifier.</summary>
        public string Id => "scene_editor";
        /// <summary>Translation key for the tool's display name.</summary>
        public string LocaleKey => "tools/scene_editor/title";
        /// <summary>Creates the editor window instance.</summary>
        public Window CreateWindow() => new SceneEditorWindow();
    }
}
