# Custom Navigation Tool bar

###  Usage

```
public CustomNavigationController NavController {
		get;
		set;
}
```

```
this.Title = "Custom Navigation Bar";
if (this.NavigationController != null
	&& this.NavigationController is CustomNavigationController) {
	NavController = (CustomNavigationController)this.NavigationController;
	NavController.ActiveNavigationBarTitle = "Choose Menu Items";
	this.NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Add, DidSelectShow);
}
```

```
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
```
