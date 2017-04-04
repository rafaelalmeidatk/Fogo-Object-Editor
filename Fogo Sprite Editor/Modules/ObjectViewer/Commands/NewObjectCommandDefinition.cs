using Gemini.Framework.Commands;
using System;
using System.ComponentModel.Composition;
using System.Windows.Input;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer.Commands
{
    [CommandDefinition]
    public class NewObjectCommandDefinition : CommandDefinition
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

        public override Uri IconSource
        {
            get { return new Uri("pack://application:,,,/Resources/Icons/NewObject.png"); }
        }

        [Export]
        public static CommandKeyboardShortcut KeyGesture = new CommandKeyboardShortcut<NewObjectCommandDefinition>(new KeyGesture(Key.N, ModifierKeys.Control));
    }
}
