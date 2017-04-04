using Gemini.Framework.Services;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace Fogo_Sprite_Editor.EditorProject
{
    public interface IGameObject
    {
        string Name { get; set; }
        BitmapSource Spritesheet { get; set; }
        bool Selected { get; set; }
        void Activate(IShell shell);
    }
}
