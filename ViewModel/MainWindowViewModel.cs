using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ValidationProblem.ViewModel
{
    internal class MainWindowViewModel: INotifyDataErrorInfo
    {
        private string _text = "";
        public string Text { get => _text; set { _text = value; ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(Text))); } }
        public bool HasErrors => true;

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public IEnumerable GetErrors(string? propertyName)
        {
            return new List<string> { "Error" };
        }
    }
}
