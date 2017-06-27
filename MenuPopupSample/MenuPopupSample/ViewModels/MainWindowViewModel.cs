using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Docking;

namespace MenuPopupSample.ViewModels
{
	public class MainWindowViewModel
	{
		public MainWindowViewModel()
		{
		}

		public ObservableCollection<PaneViewModel> Panes { get; } = new ObservableCollection<PaneViewModel>();

		public void Load()
		{
			// Initial layout in Docking
			this.Panes.Add(new PaneViewModel { Header = "Error List", InitialPosition = DockState.DockedBottom, IsActive = true});
			this.Panes.Add(new PaneViewModel { Header = "Properties", InitialPosition = DockState.DockedRight });
			this.Panes.Add(new PaneViewModel { Header = "Server Explorer", InitialPosition = DockState.DockedLeft });
			this.Panes.Add(new PaneViewModel { Header = "Output", InitialPosition = DockState.DockedBottom });
			this.Panes.Add(new PaneViewModel { Header = "Solution Explorer", InitialPosition = DockState.DockedRight });
			this.Panes.Add(new PaneViewModel { Header = "ToolBox", InitialPosition = DockState.DockedLeft });
		}
	}
}
