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

namespace Fogo_Sprite_Editor.Modules.FramesList.Views
{
    /// <summary>
    /// Interaction logic for FrameListView.xaml
    /// </summary>
    public partial class FrameListView : UserControl
    {
        public FrameListView()
        {
            InitializeComponent();
        }

        private void OnListBoxMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        }

        private void OnListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _propertyGrid.SelectedObject = ListBox.SelectedItem;
        }
    }
}
