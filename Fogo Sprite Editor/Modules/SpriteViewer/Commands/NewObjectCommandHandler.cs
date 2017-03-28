using Caliburn.Micro;
using Fogo_Sprite_Editor.Modules.SpriteViewer.ViewModels;
using Gemini.Framework.Commands;
using Gemini.Framework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fogo_Sprite_Editor.Modules.SpriteViewer.Commands
{
    [CommandHandler]
    class NewObjectCommandHandler : CommandHandlerBase<NewObjectCommandDefinition>
    {
        private readonly IShell _shell;

        [ImportingConstructor]
        public NewObjectCommandHandler(IShell shell)
        {
            _shell = shell;
        }

        public override Task Run(Command command)
        {
            _shell.OpenDocument(new SpriteViewModel());
            throw new NotImplementedException();
        }
    }
}
