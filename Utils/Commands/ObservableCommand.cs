using System.Windows.Input;

namespace Utils.Commands;

public class ObservableCommand : ICommand
{
    #region Events

    public event EventHandler? CanExecuteChanged;

    #endregion

    #region Fields

    public readonly Action<object?>? _commandAction;

    #endregion

    #region Constructor

    public ObservableCommand(Action<object?>? commandAction)
    {
        _commandAction = commandAction;
    }

    #endregion

    #region Public Methods

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        _commandAction?.Invoke(parameter);
    }

    #endregion
}
