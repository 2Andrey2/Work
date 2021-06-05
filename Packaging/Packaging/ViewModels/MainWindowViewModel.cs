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
        public async Task OpenFileRez()
        {
            var dialog = new OpenFolderDialog();
            string result = null;
            result = await dialog.ShowAsync(new Window());
            if (result != null)
            {
                PathRez = result;
            }
        }
        public void WorkFileB()
        {
            WorkFile work = new WorkFile(_CountColum, _CountLine, _Path, _PathRez);
            work.BildFile();
        }
        private int _CountColum = 2;
        public int CountColum
        {
            get => _CountColum;
            set
            {
                this.RaiseAndSetIfChanged(ref _CountColum, value);
            }
        }
        private int _CountLine = 20;
        public int CountLine
        {
            get => _CountLine;
            set
            {
                this.RaiseAndSetIfChanged(ref _CountLine, value);
            }
        }
        private string _PathRez = @"C:\Users\Andrey\Desktop";
        public string PathRez
        {
            get => _PathRez;
            set
            {
                this.RaiseAndSetIfChanged(ref _PathRez, value);
            }
        }

        private string _Path = @"C:\Users\Andrey\Desktop\work\rez\2021_5_30_15_28_Product1(0)_info.txt";
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
