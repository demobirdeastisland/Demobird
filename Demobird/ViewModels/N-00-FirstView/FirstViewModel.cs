using System;
using MvvmCross.Core.ViewModels;

namespace Demobird.ViewModels.N00FirstView
{
    public class FirstViewModel : MvxViewModel
    {
        private string _firstName;
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; RaisePropertyChanged(() => FullName); }
        }

        private string _lastName;
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; RaisePropertyChanged(() => FullName); }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", _firstName, _lastName); }
        }
    }
}
