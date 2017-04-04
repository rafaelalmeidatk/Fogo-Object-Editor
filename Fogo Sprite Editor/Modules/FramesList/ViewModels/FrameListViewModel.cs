using Caliburn.Micro;
using Fogo_Sprite_Editor.EditorProject;
using Gemini.Framework;
using Gemini.Framework.Services;
using System.ComponentModel;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.FramesList.ViewModels
{
    [Export(typeof(IFrameList))]
    class FrameListViewModel : Tool, IFrameList
    {
        public override PaneLocation PreferredLocation => PaneLocation.Right;
        
        private readonly BindableCollection<ObjectFrame> _items;
        public IObservableCollection<ObjectFrame> Items => _items;

        private GameObject _gameObject;

        [ImportingConstructor]
        public FrameListViewModel(IShell shell)
        {
            DisplayName = "Object Frames";
            _items = new BindableCollection<ObjectFrame>();
        }

        public void SetGameObject(GameObject gameObject)
        {
            _gameObject = gameObject;
            _gameObject.PropertyChanged += OnGameObjectPropertyChanged;
            RefreshFrames();
        }

        private void OnGameObjectPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Frames")
            {
                RefreshFrames();
            }
        }

        private void RefreshFrames()
        {
            _items.Clear();
            _items.AddRange(_gameObject.Frames);
        }
    }
}
