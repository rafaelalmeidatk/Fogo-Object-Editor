using Gemini.Framework;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.Home.ViewModels
{
    [Export(typeof(HomeViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class HomeViewModel : Document
    {
        public HomeViewModel()
        {
            DisplayName = "Home";
        }
    }
}
