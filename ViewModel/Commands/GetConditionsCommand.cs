using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeatherApp.ViewModel.Commands
{
        public class GetConditionsCommand : ICommand
        {
            private WeatherViewModel _weatherViewModel;

            public GetConditionsCommand(WeatherViewModel weatherViewModel)
            {
                _weatherViewModel = weatherViewModel;
            }

            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                _weatherViewModel.GetCurrentConditions();
            }

            public event EventHandler? CanExecuteChanged;
        }
    }
