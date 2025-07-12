using PropertyChanged;
using System.Windows.Input;

namespace MAUICalculator.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalsViewModel
    {
        public string Formula { get; set; }

        public string Result { get; set; } = "0";

        public ICommand OperationCommand => new Command((number) =>
        {
            Formula += number;
        });
    }
}
