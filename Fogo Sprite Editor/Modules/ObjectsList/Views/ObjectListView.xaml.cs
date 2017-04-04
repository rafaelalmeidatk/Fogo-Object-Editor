using Caliburn.Micro;
using Fogo_Sprite_Editor.EditorProject;
using Gemini.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fogo_Sprite_Editor.Modules.ObjectsList.Views
{
    /// <summary>
    /// Interaction logic for ObjectListView.xaml
    /// </summary>
    public partial class ObjectListView : UserControl
    {
        public ObjectListView()
        {
            InitializeComponent();
        }

        private void OnListBoxMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var projectManager = IoC.Get<ProjectManager>();
            if (ListBox.SelectedIndex < projectManager.GameObjects.Count)
            {
                var item = projectManager.GameObjects[ListBox.SelectedIndex];
                item.Activate(IoC.Get<IShell>());
            }
        }
    }
}
