using Controls.ImageUploader;
using Core.Core.Browser;
using Core.Log;
using Core.TestExecution;
using Core.Wait;

namespace ACSC.Tests.Extensions.StockItem
{
	public class ImageUploaderExt : ImageUploader
    {
		public ImageUploaderExt(string locator, string name, string tabId) : base(locator, name, tabId) { }

		public new void Upload()
		{
			using (TestExecution.CreateGroup("Operation", "Click Upload button in the Upload File dialog"))
			{
				base.TryLocate(false);
				Browser.JavaScriptExecutor.ExecuteScript("var dialog = window.px_all[arguments[0]]; dialog && dialog.uploader && dialog.uploader.doUpload();", new object[]
				{
					this.Locator
				});
				Wait.WaitForCallbackToComplete(5000);
				Log.Screenshot();
			}
		}
	}
}
