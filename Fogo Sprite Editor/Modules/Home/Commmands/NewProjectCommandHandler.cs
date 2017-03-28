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
            return TaskUtility.Completed;
        }
    }
}
