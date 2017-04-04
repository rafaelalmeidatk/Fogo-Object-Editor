using Fogo_Sprite_Editor.Modules.ObjectViewer.Commands;
using Gemini.Framework.ToolBars;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer
{
    public static class ToolBarDefinitions
    {
        [Export]
        public static ToolBarItemGroupDefinition ObjectViewToolBarGroup = new ToolBarItemGroupDefinition(
            Gemini.Modules.Shell.ToolBarDefinitions.StandardOpenSaveToolBarGroup.ToolBar, 16);

        [Export]
        public static ToolBarItemDefinition NewObjectToolBarItem = new CommandToolBarItemDefinition<NewObjectCommandDefinition>(
            ObjectViewToolBarGroup, 0);

        [Export]
        public static ToolBarItemDefinition NewFrameToolBarItem = new CommandToolBarItemDefinition<NewFrameCommandDefinition>(
            ObjectViewToolBarGroup, 1);
    }
}
