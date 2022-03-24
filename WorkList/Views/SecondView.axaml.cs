using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using WorkList.Models;
using WorkList.ViewModels;

namespace WorkList.Views
{
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}