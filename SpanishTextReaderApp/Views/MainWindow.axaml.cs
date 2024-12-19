using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using System.Diagnostics;
using System.Linq;

namespace SpanishTextReaderApp.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    internal IStorageFile? SelectedFile { get; set; }
    // Button click to open file dialog
    private async void OnFileSelectButtonClick(object sender, RoutedEventArgs e)
    {
        var result=await StorageProvider.OpenFilePickerAsync(new Avalonia.Platform.Storage.FilePickerOpenOptions() { AllowMultiple=false,Title="Select Textfile to Load"});
        SelectedFile=result.FirstOrDefault();
    }

    //// Drag-and-drop file event handlers

    //private void OnDragOver(object sender, DragEventArgs e)
    //{
    //    // Set the drag effect when a file is dragged over
    //    if (e.Data.GetFiles()!=null)
    //    {
    //        if (e.Data.GetFiles().Count() > 1)
    //        {
    //            e.DragEffects = DragEffects.None;
    //        }
    //        else
    //        {
    //            e.DragEffects = DragEffects.Copy;
    //        }
    //    }
    //}

    //private void OnDrop(object sender, DragEventArgs e)
    //{
    //    // Handle the dropped file
    //    var filePaths = e.Data.GetFiles();
    //    ShowDialog()
    //}
}