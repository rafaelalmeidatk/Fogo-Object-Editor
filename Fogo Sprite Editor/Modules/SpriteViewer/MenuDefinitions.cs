using Fogo_Sprite_Editor.Modules.SpriteViewer.Commands;
using Gemini.Framework.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fogo_Sprite_Editor.Modules.SpriteViewer
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
