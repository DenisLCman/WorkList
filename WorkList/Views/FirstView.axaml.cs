using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using WorkList.ViewModels;

namespace WorkList.Views
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
