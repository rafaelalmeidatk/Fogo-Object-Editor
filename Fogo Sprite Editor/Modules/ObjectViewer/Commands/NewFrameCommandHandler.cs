using Caliburn.Micro;
using Fogo_Sprite_Editor.EditorProject;
using Fogo_Sprite_Editor.Modules.ObjectViewer.ViewModels;
using Gemini.Framework.Commands;
using Gemini.Framework.Services;
using Gemini.Framework.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer.Commands
{
    [CommandHandler]
    public class NewFrameCommandHandler : CommandHandlerBase<NewFrameCommandDefinition>
    {
        private readonly IShell _shell;

        [ImportingConstructor]
        public NewFrameCommandHandler(IShell shell)
        {
            _shell = shell;
        }

        public override void Update(Command command)
        {
            command.Enabled = IoC.Get<ProjectManager>().Initialized && _shell.ActiveItem is ObjectViewModel;
        }

        public override Task Run(Command command)
        {
            if (!(_shell.ActiveItem is ObjectViewModel))
            {
                return TaskUtility.Completed;
            }
            var documentObject = (ObjectViewModel)_shell.ActiveItem;
            documentObject.GameObject.CreateFrame();
            return TaskUtility.Completed;
        }
    }
}
