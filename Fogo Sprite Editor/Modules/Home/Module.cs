using Caliburn.Micro;
using Fogo_Sprite_Editor.EditorProject;
using Fogo_Sprite_Editor.Modules.Home.ViewModels;
using Gemini.Framework;
using Gemini.Modules.PropertyGrid;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.Home
{
    [Export(typeof(IModule))]
    public class Module : ModuleBase
    {
        public override IEnumerable<IDocument> DefaultDocuments
        {
            get
            {
                yield return IoC.Get<HomeViewModel>();
            }
        }

        public override void PostInitialize()
        {
            IoC.Get<IPropertyGrid>().SelectedObject = IoC.Get<HomeViewModel>();
            Shell.OpenDocument(IoC.Get<HomeViewModel>());
            IoC.Get<ProjectManager>().CreateNewGameObject();
        }
    }
}
