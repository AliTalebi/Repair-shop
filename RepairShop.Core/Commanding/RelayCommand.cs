using System;
using System.Windows.Input;

namespace RepairShop.Core.Commanding
{
	public sealed class RelayCommand : ICommand
	{
		private Action<object> _executeAction;
		private bool _canExecuteCache = false;
		private Predicate<object> _canExecuteAction;
		public event EventHandler CanExecuteChanged;

		public RelayCommand(Action<object> executeAction)
			: this(executeAction, null) { }

		public RelayCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
		{
			_canExecuteCache = false;
			_executeAction = executeAction;
			_canExecuteAction = canExecuteAction;
		}

		public bool CanExecute(object parameter)
		{
			if (_canExecuteAction == null)
				return true;

			var canExecute = _canExecuteAction(parameter);

			if (canExecute != _canExecuteCache)
			{
				_canExecuteCache = canExecute;
				CanExecuteChanged(this, new EventArgs());
			}

			return _canExecuteCache;
		}

		public void Execute(object parameter)
		{
			_executeAction(parameter);
		}
	}

	public sealed class RelayCommand<T> : ICommand
	{
		private Action<T> _executeAction;
		private bool _canExecuteCache = false;
		private Predicate<T> _canExecuteAction;
		public event EventHandler CanExecuteChanged;

		public RelayCommand(Action<T> executeAction)
			: this(executeAction, null) { }

		public RelayCommand(Action<T> executeAction, Predicate<T> canExecuteAction)
		{
			_canExecuteCache = false;
			_executeAction = executeAction;
			_canExecuteAction = canExecuteAction;
		}

		public bool CanExecute(object parameter)
		{
			if (_canExecuteAction == null)
				return true;

			var canExecute = _canExecuteAction((T)parameter);

			if (canExecute != _canExecuteCache)
			{
				_canExecuteCache = canExecute;
				CanExecuteChanged(this, new EventArgs());
			}

			return _canExecuteCache;
		}

		public void Execute(object parameter)
		{
			_executeAction((T)parameter);
		}
	}
}
