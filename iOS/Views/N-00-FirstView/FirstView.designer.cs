// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Demobird.iOS.Views.N00FirstView
{
    [Register ("FirstView")]
    partial class FirstView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelFullName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldFirstName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldLastName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelFullName != null) {
                labelFullName.Dispose ();
                labelFullName = null;
            }

            if (textFieldFirstName != null) {
                textFieldFirstName.Dispose ();
                textFieldFirstName = null;
            }

            if (textFieldLastName != null) {
                textFieldLastName.Dispose ();
                textFieldLastName = null;
            }
        }
    }
}