using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GeneralNumbering
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void Clik_Open_File()
        {

        }
    }
}
