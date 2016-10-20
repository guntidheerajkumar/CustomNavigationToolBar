using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace CustomNavigationToolBar
{
	// @interface CustomNavigationController : UINavigationController
	[BaseType(typeof(UINavigationController))]
	interface CustomNavigationController
	{
		// @property (nonatomic, strong) UIToolbar * dropDownToolbar;
		[Export("dropDownToolbar", ArgumentSemantic.Strong)]
		UIToolbar DropDownToolbar { get; set; }

		// @property (nonatomic, strong) NSString * activeNavigationBarTitle;
		[Export("activeNavigationBarTitle", ArgumentSemantic.Strong)]
		string ActiveNavigationBarTitle { get; set; }

		// @property (nonatomic, strong) NSString * activeBarButtonTitle;
		[Export("activeBarButtonTitle", ArgumentSemantic.Strong)]
		string ActiveBarButtonTitle { get; set; }

		// @property (assign, nonatomic) BOOL isDropDownVisible;
		[Export("isDropDownVisible")]
		bool IsDropDownVisible { get; set; }

		// -(void)toggleDropDown:(id)sender;
		[Export("toggleDropDown:")]
		void ToggleDropDown(NSObject sender);

		// -(void)hideDropDown:(id)sender;
		[Export("hideDropDown:")]
		void HideDropDown(NSObject sender);

		// -(void)showDropDown:(id)sender;
		[Export("showDropDown:")]
		void ShowDropDown(NSObject sender);
	}
}
