using Fogo_Sprite_Editor.EditorProject;
using Fogo_Sprite_Editor.Modules.ObjectsList.Models;
using Gemini.Framework;

namespace Fogo_Sprite_Editor.Modules.ObjectsList
{
    public interface IObjectList : ITool
    {
        void AddGameObject(GameObject item);
    }
}
