using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfHelper;

public abstract class ViewModel
    : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	protected void OnPropertyChanged([CallerMemberName] string? name = default)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}