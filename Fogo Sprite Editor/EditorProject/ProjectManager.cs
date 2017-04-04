using Caliburn.Micro;
using Fogo_Sprite_Editor.Modules.Home.ViewModels;
using Fogo_Sprite_Editor.Modules.ObjectsList;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.EditorProject
{
    [Export(typeof(ProjectManager))]
    public class ProjectManager
    {
        //--------------------------------------------------
        // Project Initialized?

        private bool _initialized;
        public bool Initialized => _initialized;

        //--------------------------------------------------
        // Project Data

        private ProjectData _projectData;
        public List<GameObject> GameObjects => _projectData.GameObjects;

        public void CreateNewProject()
        {
            _initialized = true;
            _projectData = new ProjectData();
        }

        public GameObject CreateNewGameObject()
        {
            var gameObject = new GameObject();

            _projectData.GameObjects.Add(gameObject);

            var objectList = IoC.Get<IObjectList>();
            objectList.AddGameObject(gameObject);

            IoC.Get<HomeViewModel>().Activate(gameObject);

            return gameObject;
        }
    }
}
