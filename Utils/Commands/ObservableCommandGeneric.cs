using System.Windows.Input;

namespace Utils.Commands;

public sealed class ObservableCommand<T>(Action<T?>? commandAction) : ICommand
{
    #region Events

    public event EventHandler? CanExecuteChanged;

    #endregion

    #region Fields

    private readonly Action<T?>? _commandAction = commandAction;

    #endregion

    #region Public Methods

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter)
    {
        var commandParameter = default(T);

        if (parameter is T convertedParameter)
            commandParameter = convertedParameter;

        this._commandAction?.Invoke(commandParameter);
    }

    #endregion
}
