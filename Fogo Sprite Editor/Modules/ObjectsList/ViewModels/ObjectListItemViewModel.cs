using Fogo_Sprite_Editor.EditorProject;
using Fogo_Sprite_Editor.Modules.ObjectsList.Models;
using System.ComponentModel;

namespace Fogo_Sprite_Editor.Modules.ObjectsList.ViewModels
{
    class ObjectListItemViewModel : INotifyPropertyChanged
    {
        private readonly GameObject _model;

        public GameObject Model
        {
            get { return _model; }
        }

        public string Name
        {
            get { return _model.Name; }
        }

        public bool Selected { get; set; }

        public ObjectListItemViewModel(GameObject model)
        {
            _model = model;
            Model.PropertyChanged += OnModelPropertyChanged;
        }

        private void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyPropertyChanged(e.PropertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
