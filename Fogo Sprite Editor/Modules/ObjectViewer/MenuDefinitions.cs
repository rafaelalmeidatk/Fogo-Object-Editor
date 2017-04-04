using Fogo_Sprite_Editor.Modules.ObjectViewer.Commands;
using Gemini.Framework.Menus;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer
{
    public static class MenuDefinitions
    {
        [Export]
        public static MenuItemGroupDefinition ObjectGroup = new MenuItemGroupDefinition(
            Gemini.Modules.Shell.MenuDefinitions.FileNewCascadeGroup.Parent, 1);

        [Export]
        public static MenuItemDefinition NewObjectItemMenu = new CommandMenuItemDefinition<NewObjectCommandDefinition>(
            ObjectGroup, 0);

        [Export]
        public static MenuItemDefinition NewFrameItemMenu = new CommandMenuItemDefinition<NewFrameCommandDefinition>(
            ObjectGroup, 1);
    }
}
