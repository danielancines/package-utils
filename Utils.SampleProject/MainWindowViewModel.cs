using Utils.Commands;

namespace Utils.SampleProject;

public sealed class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        this.ClickMeCommand = new ObservableCommand(parameter => System.Windows.MessageBox.Show("Hello from Click Me Command!"));
        this.GenericObservableCommand = new ObservableCommand<string>(parameter => System.Windows.MessageBox.Show(parameter));
    }

    public ObservableCommand ClickMeCommand { get; }
    public ObservableCommand<string> GenericObservableCommand { get; }
}
