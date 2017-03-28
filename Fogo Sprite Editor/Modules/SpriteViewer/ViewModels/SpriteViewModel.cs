using Gemini.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fogo_Sprite_Editor.Modules.SpriteViewer.ViewModels
{
    [Export(typeof(SpriteViewModel))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class SpriteViewModel : Document
    {
        public SpriteViewModel()
        {
            DisplayName = "[New Sprite]";
        }
    }
}
