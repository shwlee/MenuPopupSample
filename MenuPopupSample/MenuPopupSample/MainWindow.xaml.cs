using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MenuPopupSample.ViewModels;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Docking;

namespace MenuPopupSample
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			var viewModel = this.DataContext as MainWindowViewModel;
			viewModel.Load();
		}

		private void OnPreviewShowCompass(object sender, PreviewShowCompassEventArgs e)
		{
			bool isRootCompass = e.Compass is RootCompass;
			var splitContainer = e.DraggedElement as RadSplitContainer;
			if (splitContainer != null)
			{
				bool isDraggingDocument = splitContainer.EnumeratePanes().Any(p => p is RadDocumentPane);
				var isTargetDocument = e.TargetGroup == null ? true : e.TargetGroup.EnumeratePanes().Any(p => p is RadDocumentPane);
				if (isDraggingDocument)
				{
					e.Canceled = isRootCompass || !isTargetDocument;
				}
				else
				{
					e.Canceled = !isRootCompass && isTargetDocument;
				}
			}
		}

		private void FilterToolboxesSource(object sender, FilterEventArgs e)
		{
			var vm = e.Item as PaneViewModel;
			e.Accepted = !vm.IsDocument;
		}
	}
}
