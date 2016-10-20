using System;
using CustomNavigationToolBar;
using UIKit;
using Foundation;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		public CustomNavigationController NavController {
			get;
			set;
		}

		public ViewController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.View.BackgroundColor = UIColor.White;
			this.Title = "Custom Navigation Bar";
			if (this.NavigationController != null
				&& this.NavigationController is CustomNavigationController) {
				NavController = (CustomNavigationController)this.NavigationController;
				NavController.ActiveNavigationBarTitle = "Choose Menu Items";
				this.NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Add, DidSelectShow);
			}
		}

		public void DidSelectShow(object sender, EventArgs evt)
		{
			this.NavController.DropDownToolbar.Items = new UIBarButtonItem[]
			{
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
				new UIBarButtonItem(UIBarButtonSystemItem.Edit),
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
				new UIBarButtonItem(UIBarButtonSystemItem.Save),
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
				new UIBarButtonItem(UIBarButtonSystemItem.Pause),
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
				new UIBarButtonItem(UIBarButtonSystemItem.Compose),
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
				new UIBarButtonItem(UIBarButtonSystemItem.Camera),
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
				new UIBarButtonItem(UIBarButtonSystemItem.Reply),
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
				new UIBarButtonItem(UIBarButtonSystemItem.Refresh),
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace)
			};
			var sendObj = sender as UIBarButtonItem;
			if (this.NavController.IsDropDownVisible) {
				this.NavController.HideDropDown(sendObj);
				this.Title = "Custom Navigation Bar";
			} else {
				this.NavController.ShowDropDown(sendObj);
			}
		}
	}
}
