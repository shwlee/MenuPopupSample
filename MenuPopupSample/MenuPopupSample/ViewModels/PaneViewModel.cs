using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls.Docking;

namespace MenuPopupSample.ViewModels
{
	public class PaneViewModel
	{
		public string Header { get; set; }
		
		public DockState InitialPosition { get; set; }
		
		public bool IsActive { get; set; }
		
		public bool IsHidden { get; set; }
		
		public bool IsDocument { get; set; }
	}
}
