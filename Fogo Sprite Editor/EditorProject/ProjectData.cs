using System.Collections.Generic;

namespace Fogo_Sprite_Editor.EditorProject
{
    class ProjectData
    {
        private List<GameObject> _gameObjects;
        public List<GameObject> GameObjects => _gameObjects;

        public ProjectData()
        {
            _gameObjects = new List<GameObject>();
        }
    }
}
