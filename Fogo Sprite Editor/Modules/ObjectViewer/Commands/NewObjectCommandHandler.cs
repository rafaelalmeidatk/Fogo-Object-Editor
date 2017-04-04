using Caliburn.Micro;
using Fogo_Sprite_Editor.EditorProject;
using Fogo_Sprite_Editor.Modules.Home.ViewModels;
using Fogo_Sprite_Editor.Modules.ObjectViewer.ViewModels;
using Gemini.Framework.Commands;
using Gemini.Framework.Services;
using Gemini.Framework.Threading;
using Gemini.Modules.Inspector.Inspectors;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Threading.Tasks;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer.Commands
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

        public override void Update(Command command)
        {
            command.Enabled = IoC.Get<ProjectManager>().Initialized;
        }

        public override Task Run(Command command)
        {
            var projManager = IoC.Get<ProjectManager>();
            projManager.CreateNewGameObject();
            return TaskUtility.Completed;
        }
    }
}
