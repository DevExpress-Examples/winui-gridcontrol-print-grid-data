using DevExpress.WinUI.Grid.Printing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace PrintGridControl {

    public sealed partial class GridPage : Page {

        public GridPage() {
            InitializeComponent();
        }

        public ViewModel ViewModel { get; } = new ViewModel();

        void Button_Click(object sender, RoutedEventArgs e) {
            gridcontrol.Print();
        }
    }
}
