using Fogo_Sprite_Editor.Modules.ObjectViewer.Commands;
using Gemini.Framework.Menus;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer
{
    public static class MenuDefinitions
    {
        [Export]
        public static MenuItemGroupDefinition NewObjectGroup = new MenuItemGroupDefinition(
            Gemini.Modules.Shell.MenuDefinitions.FileNewCascadeGroup.Parent, 1);

        [Export]
        public static MenuItemDefinition NewProjectItemMenu = new CommandMenuItemDefinition<NewObjectCommandDefinition>(
            NewObjectGroup, 0);
    }
}
