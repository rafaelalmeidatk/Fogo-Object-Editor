using Fogo_Sprite_Editor.Modules.ObjectViewer.ViewModels;
using Gemini.Framework.Services;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Collections.Generic;

namespace Fogo_Sprite_Editor.EditorProject
{
    public class GameObject : IGameObject, INotifyPropertyChanged
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

        private List<ObjectFrame> _frames;
        public List<ObjectFrame> Frames => _frames;

        public GameObject()
        {
            _name = "[New Object]";
            _frames = new List<ObjectFrame>();
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        public void CreateFrame()
        {
            var frame = new ObjectFrame();
            frame.Name = "Test Name";
            _frames.Add(frame);
            NotifyPropertyChanged("Frames");
        }
    }
}
