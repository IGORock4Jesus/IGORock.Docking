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
using System.Windows.Shapes;

namespace IGORock.Docking.Containers
{
	/// <summary>
	/// Логика взаимодействия для FloatingWindowContainer.xaml
	/// </summary>
	public partial class FloatingWindowContainer : Window, IContainer
	{
		public FloatingWindowContainer()
		{
			InitializeComponent();
		}

		public void AddRight(Page page)
		{
			throw new NotImplementedException();
		}

		private void Window_DragOver(object sender, DragEventArgs e)
		{
			if(e.GetPosition(grid).X > this.ActualWidth / 2)
			{
				bool found = false;
				foreach (var child in grid.Children)
				{
					if(child is Tools.RightTool)
					{
						found = true;
						break;
					}
				}
				if (!found)
					grid.Children.Add(new Tools.RightTool());
			}
		}
	}
}
