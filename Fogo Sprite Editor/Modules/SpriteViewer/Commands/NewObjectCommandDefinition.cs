using Gemini.Framework.Commands;

namespace Fogo_Sprite_Editor.Modules.SpriteViewer.Commands
{
    [CommandDefinition]
    class NewObjectCommandDefinition : CommandDefinition
    {
        public const string CommandName = "NewObject";

        public override string Name
        {
            get { return CommandName; }
        }

        public override string Text
        {
            get { return "New _Object"; }
        }

        public override string ToolTip
        {
            get { return "New Object"; }
        }
    }
}
