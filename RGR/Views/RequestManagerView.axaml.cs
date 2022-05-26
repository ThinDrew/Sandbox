using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RGR.Views
{
    public partial class RequestManagerView : UserControl
    {
        public RequestManagerView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
