using Gemini.Framework.Commands;

namespace Fogo_Sprite_Editor.Modules.Home.Commmands
{
    [CommandDefinition]
    class NewProjectCommandDefinition : CommandDefinition
    {
        public const string CommandName = "NewProject";

        public override string Name
        {
            get { return CommandName; }
        }

        public override string Text
        {
            get { return "New _Project"; }
        }

        public override string ToolTip
        {
            get { return "New Project"; }
        }
    }
}
