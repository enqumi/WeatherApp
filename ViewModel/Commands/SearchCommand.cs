using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeatherApp.ViewModel.Commands;

public class SearchCommand : ICommand
{
    public SearchCommand(WeatherViewModel weatherViewModel)
    {
        _weatherViewModel = weatherViewModel;
    }

    private WeatherViewModel _weatherViewModel;

    public bool CanExecute(object? parameter)
    {
        return _weatherViewModel.Query.Length > 0;
    }

    public void Execute(object? parameter)
    {
        _weatherViewModel.SearchForCities();
    }

    public event EventHandler? CanExecuteChanged;
}
