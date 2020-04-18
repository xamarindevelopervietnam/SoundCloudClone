// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace SoundCloudClone.iOS.Controls
{
	public partial class SearchResultsViewController : UIViewController, IUITableViewDataSource
	{
        private List<string> _results = new List<string> { "Item 1", "Item 2", "Item 3" };

		public SearchResultsViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SearchResultsTableView.DataSource = this;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("SearchResultCell", indexPath) as SearchResultsCell;

            cell.Update(_results[indexPath.Row]);

            return cell;
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return _results.Count;
        }
    }
}
