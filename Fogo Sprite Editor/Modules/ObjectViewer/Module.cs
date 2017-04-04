using Caliburn.Micro;
using Fogo_Sprite_Editor.Modules.FramesList;
using Fogo_Sprite_Editor.Modules.Home.ViewModels;
using Fogo_Sprite_Editor.Modules.ObjectsList;
using Fogo_Sprite_Editor.Modules.ObjectViewer.ViewModels;
using Gemini.Framework;
using Gemini.Modules.Inspector;
using Gemini.Modules.Toolbox;
using System.ComponentModel.Composition;

namespace Fogo_Sprite_Editor.Modules.ObjectViewer
{
    [Export(typeof(IModule))]
    class Module : ModuleBase
    {
        private readonly IInspectorTool _objSettings;
        private readonly IToolbox _objectListInspector;

        [ImportingConstructor]
        public Module(IInspectorTool objSettings, IToolbox objList)
        {
            _objSettings = objSettings;
            _objSettings.DisplayName = "Object Properties";

            _objectListInspector = objList;
            _objectListInspector.DisplayName = "Other Object Properties";
        }

        public override void Initialize()
        {
            base.Initialize();

            Shell.ActiveDocumentChanged += (sender, e) => RefreshInspector();
            RefreshInspector();
        }

        private void RefreshInspector()
        {
            if (Shell.ActiveItem is ObjectViewModel)
            {
                var document = (ObjectViewModel)Shell.ActiveItem;
                _objSettings.SelectedObject = new InspectableObjectBuilder()
                    .WithObjectProperties(Shell.ActiveItem, pd => pd.ComponentType == Shell.ActiveItem.GetType())
                    .ToInspectableObject();
                
                Shell.ShowTool(_objSettings);
                Shell.ShowTool(IoC.Get<IObjectList>());
                Shell.ShowTool(IoC.Get<IFrameList>());
                IoC.Get<IFrameList>().SetGameObject(document.GameObject);
            }
            else
            {
                _objSettings.SelectedObject = null;
            }
        }
    }
}
