using Caliburn.Micro;
using Fogo_Sprite_Editor.EditorProject;
using Gemini.Framework.Commands;
using Gemini.Framework.Threading;
using System.Threading.Tasks;

namespace Fogo_Sprite_Editor.Modules.Home.Commmands
{
    [CommandHandler]
    class NewProjectCommandHandler : CommandHandlerBase<NewProjectCommandDefinition>
    {
        public override Task Run(Command command)
        {
            var projManager = IoC.Get<ProjectManager>();
            projManager.CreateNewProject();
            return TaskUtility.Completed;
        }
    }
}
