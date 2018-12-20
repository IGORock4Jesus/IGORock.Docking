﻿using System;
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

namespace IGORock.Docking.Demo
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class DemoWindow : Window
	{
		public DemoWindow()
		{
			InitializeComponent();

			//manager.LoadLayout("demo.xml");

			DemoLoadingPage demoLoadingPage = new DemoLoadingPage();
			manager.New(demoLoadingPage);
		}
	}
}
