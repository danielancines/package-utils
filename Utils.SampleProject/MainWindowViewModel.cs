using Utils.Commands;

namespace Utils.SampleProject;

public sealed class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        this.ClickMeCommand = new ObservableCommand(parameter => System.Windows.MessageBox.Show("Hello from Click Me Command!"));
    }
    public ObservableCommand ClickMeCommand { get; }
}
