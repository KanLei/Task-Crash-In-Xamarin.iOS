using System;
using UIKit;
using BugtagsBinding.iOS;
using System.Threading.Tasks;

namespace BugtagsDemo
{
    public class RootViewController:UIViewController
    {
        public RootViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;

            TestMethodAsync();
        }

        private async Task TestMethodAsync()
        {
            // 1. Success
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("After Delay Thread");

            // 2. Fail
            await Task.Delay(1000);
            Console.WriteLine("After Delay Task");
        }
    }
}

