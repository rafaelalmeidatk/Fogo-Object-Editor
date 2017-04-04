using Gemini.Framework;
using System.ComponentModel.Composition;
using Gemini.Framework.Services;
using Caliburn.Micro;
using Fogo_Sprite_Editor.EditorProject;

namespace Fogo_Sprite_Editor.Modules.ObjectsList.ViewModels
{
    [Export(typeof(IObjectList))]
    class ObjectListViewModel : Tool, IObjectList
    {
        public override PaneLocation PreferredLocation => PaneLocation.Left;

        private readonly BindableCollection<GameObject> _items;
        public IObservableCollection<GameObject> Items => _items;

        [ImportingConstructor]
        public ObjectListViewModel(IShell shell)
        {
            DisplayName = "Game Objects";
            _items = new BindableCollection<GameObject>();
        }

        public void AddGameObject(GameObject item)
        {
            item.Selected = true;
            _items.Add(item);
        }
    }
}
