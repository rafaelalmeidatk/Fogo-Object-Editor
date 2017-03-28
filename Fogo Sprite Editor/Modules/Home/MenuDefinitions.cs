using Fogo_Sprite_Editor.Modules.Home.Commmands;
using Gemini.Framework.Menus;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.Home
{
    public static class MenuDefinitions
    {
        [Export]
        public static MenuItemGroupDefinition NewProjectGroup = new MenuItemGroupDefinition(
            Gemini.Modules.Shell.MenuDefinitions.FileNewCascadeGroup.Parent, 0);

        [Export]
        public static MenuItemDefinition NewProjectItemMenu = new CommandMenuItemDefinition<NewProjectCommandDefinition>(
            NewProjectGroup, 0);
    }
}
