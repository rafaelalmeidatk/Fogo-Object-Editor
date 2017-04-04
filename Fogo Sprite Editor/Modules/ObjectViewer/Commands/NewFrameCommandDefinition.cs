using Gemini.Framework.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer.Commands
{
    [CommandDefinition]
    public class NewFrameCommandDefinition : CommandDefinition
    {
        public const string CommandName = "NewFrame";

        public override string Name
        {
            get { return CommandName; }
        }

        public override string Text
        {
            get { return "New _Frame"; }
        }

        public override string ToolTip
        {
            get { return "New Frame"; }
        }

        public override Uri IconSource
        {
            get { return new Uri("pack://application:,,,/Resources/Icons/NewFrame.png"); }
        }

        [Export]
        public static CommandKeyboardShortcut KeyGesture = new CommandKeyboardShortcut<NewObjectCommandDefinition>(new KeyGesture(Key.F, ModifierKeys.Control));
    }
}
