using Avalonia.Controls;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packaging.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public async Task OpenFile()
        {
            var dialog = new OpenFileDialog();
            string[] result = null;
            result = await dialog.ShowAsync(new Window());
            if (result != null)
            {
                Path = result[0];
            }
        }
        public async Task WorkFileB()
        {
            WorkFile work = new WorkFile(_CountColum, _CountLine, _Path);

        }
        private int _CountColum = 0;
        public int CountColum
        {
            get => _CountColum;
            set
            {
                this.RaiseAndSetIfChanged(ref _CountColum, value);
            }
        }
        private int _CountLine = 0;
        public int CountLine
        {
            get => _CountLine;
            set
            {
                this.RaiseAndSetIfChanged(ref _CountLine, value);
            }
        }
        private string _Path = "”казаный путь";
        public string Path
        {
            get => _Path;
            set
            {
                this.RaiseAndSetIfChanged(ref _Path, value);
            }
        }

    }
}
