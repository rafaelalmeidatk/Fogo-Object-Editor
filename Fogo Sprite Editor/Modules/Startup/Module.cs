using Caliburn.Micro;
using Fogo_Sprite_Editor.EditorProject;
using Fogo_Sprite_Editor.Modules.ObjectViewer.Commands;
using Gemini.Framework;
using Gemini.Modules.Inspector;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.Startup
{
    [Export(typeof(IModule))]
    class Module : ModuleBase
    {

        public override void Initialize()
        {
            MainWindow.Title = "Fogo Sprite Editor";
            MainWindow.WindowState = System.Windows.WindowState.Maximized;
            Shell.ToolBars.Visible = true;

            // Force new project
            IoC.Get<ProjectManager>().CreateNewProject();
        }
    }
}
