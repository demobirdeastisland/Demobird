using System;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using UIKit;
using Demobird.ViewModels.N00FirstView;

namespace Demobird.iOS.Views.N00FirstView
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(this.textFieldFirstName).To(vm => vm.FirstName);
            set.Bind(this.textFieldLastName).To(vm => vm.LastName);
            set.Bind(this.labelFullName).To(vm => vm.FullName);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

