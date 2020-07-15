using System.Collections.Generic;
using System.ComponentModel;

namespace MaterialMvvmSample.ViewModels
{
    public class MaterialTextFieldViewModel : BaseViewModel
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                Set(ref _name, value);
                base.OnPropertyChanged(nameof(HasError));
                base.OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool HasError
        {
            get
            {
                return string.IsNullOrEmpty(_name);
            }
        }

        public string ErrorMessage
        {
            get
            {
                if (HasError)
                {
                    return "Name is required!";
                }

                return string.Empty;
            }
        }

        public MaterialTextFieldViewModel()
        {
        }

        public IList<string> Choices => new List<string>
        {
            "Ayala Corporation",
            "San Miguel Corporation",
            "YNGEN Holdings Inc.",
            "ERNI Development Center Philippines, Inc., Bern, Switzerland"
        };

    }
}
