using Fogo_Sprite_Editor.Modules.ObjectsList.Models;
using Fogo_Sprite_Editor.Modules.ObjectViewer.ViewModels;
using Gemini.Framework.Services;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Fogo_Sprite_Editor.EditorProject
{
    public class GameObject : ObjectListItem, IGameObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public BitmapSource Spritesheet { get; set; }
        public bool Selected { get; set; }

        public GameObject()
        {
            Name = "[New Object]";
        }


        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Activate(IShell shell)
        {
            var found = false;
            foreach (var document in shell.Documents)
            {
                if (document is ObjectViewModel)
                {
                    var objectView = (ObjectViewModel)document;
                    if (objectView.GameObject == this)
                    {
                        shell.OpenDocument(objectView);
                        found = true;
                    }
                }
            }
            if (!found)
            {
                var document = new ObjectViewModel();
                document.SetGameObject(this);
                shell.OpenDocument(document);
            }
        }
    }
}
