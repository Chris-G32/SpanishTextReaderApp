using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using System;
using System.IO;
using System.Linq;
using Avalonia.Platform.Storage;
namespace SpanishTextReaderApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    internal IStorageFile? SelectedFile { get; set; }
}
