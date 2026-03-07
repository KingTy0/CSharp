using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventsLamborghini.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged = (sender, e) => { };

        protected void PropertyChangedEvent([CallerMemberName] string? propertyName = null)
        {
            if (PropertyChanged == null)
            {
                throw new InvalidOperationException("whatever");

            }
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
