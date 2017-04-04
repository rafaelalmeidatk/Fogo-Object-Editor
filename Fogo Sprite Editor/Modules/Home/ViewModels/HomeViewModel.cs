using Fogo_Sprite_Editor.EditorProject;
using Gemini.Framework;
using Gemini.Framework.Services;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.Home.ViewModels
{
    [Export(typeof(HomeViewModel))]
    class HomeViewModel : Document
    {
        private readonly IShell _shell;
        private readonly List<IGameObject> _gameObjects;
        public List<IGameObject> GameObjects => _gameObjects;

        public override string DisplayName
        {
            get { return "Home"; }
        }

        [ImportingConstructor]
        public HomeViewModel([Import] IShell shell)
        {
            _shell = shell;
            _gameObjects = new List<IGameObject>();
        }

        public void Activate(IGameObject gameObject)
        {
            _gameObjects.Add(gameObject);
            gameObject.Activate(_shell);
        }
    }
}
