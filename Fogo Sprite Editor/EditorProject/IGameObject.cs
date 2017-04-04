using Gemini.Framework.Services;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Fogo_Sprite_Editor.EditorProject
{
    public interface IGameObject
    {
        // Data
        string Name { get; set; }
        BitmapSource Spritesheet { get; set; }
        List<ObjectFrame> Frames { get; }
        // UI
        bool Selected { get; set; }
        // Methods
        void CreateFrame();
        void Activate(IShell shell);
    }
}
