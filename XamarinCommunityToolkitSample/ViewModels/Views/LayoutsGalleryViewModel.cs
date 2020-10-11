using System.Collections.Generic;
using Xamarin.CommunityToolkit.Sample.Models;
using Xamarin.CommunityToolkit.Sample.Pages.Views;
using Xamarin.CommunityToolkit.Sample.Resx;

namespace Xamarin.CommunityToolkit.Sample.ViewModels.Views
{
	public class LayoutsGalleryViewModel : BaseViewModel
	{
		public IEnumerable<SectionModel> Items { get; } = new List<SectionModel>
		{
			new SectionModel(typeof(DockLayoutPage), AppResources.DockLayoutTitle, AppResources.DockLayoutDescription)
		};
	}
}