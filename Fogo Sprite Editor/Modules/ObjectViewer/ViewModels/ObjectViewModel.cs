using Fogo_Sprite_Editor.EditorProject;
using Gemini.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer.ViewModels
{
    [Export(typeof(ObjectViewModel))]
    public class ObjectViewModel : Document
    {
        private GameObject _gameObject;
        public GameObject GameObject => _gameObject;

        private string _name;
        [DisplayName("Name")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                _gameObject.Name = value;
                DisplayName = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private BitmapSource _spritesheet;
        [DisplayName("Spritesheet")]
        public BitmapSource Spritesheet
        {
            get { return _spritesheet; }
            set
            {
                _spritesheet = value;
                _gameObject.Spritesheet = value;
                NotifyOfPropertyChange(() => Spritesheet);
            }
        }

        public ObjectViewModel()
        {
            DisplayName = "[New Object]";
        }

        public void SetGameObject(GameObject gameObject)
        {
            _gameObject = gameObject;
            DisplayName = _gameObject.Name;
        }
    }
}
