using System;
using System.Collections;
using Xwt;
using Xwt.Drawing;
using UI;

// https://github.com/mono/xwt/tree/master/TestApps/Samples
namespace UI
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Application.Initialize(ToolkitType.Gtk);
			Window MainWindow = new Window()
			{
				Title = "Xwt Demo Application",
				Width = 500,
				Height = 400
			};
			MainWindow.CloseRequested += (o, e) =>
			{
				Application.Exit();
			};
			Menu MainMenu = new Menu();
			RichTextView TextView = new RichTextView();
			MenuItem FileOpenMenuItem = new MenuItem("???????");
			Menu FileMenu = new Menu();
			FileOpenMenuItem.Clicked += (o, e) =>
			{
				OpenFileDialog Dialog = new OpenFileDialog("??????? ????");
				if (Dialog.Run(MainWindow))
				{
					TextView.LoadFile(Dialog.FileName, Xwt.Formats.TextFormat.Markdown);
				}
			};
			MenuItem FileMenuItem = new MenuItem("????") { SubMenu = FileMenu };
			FileMenu.Items.Add(FileOpenMenuItem);
			MainMenu.Items.Add(FileMenuItem);

			MainWindow.MainMenu = MainMenu;
			var n = new NotebookSample();

			MainWindow.Content = n;

			MainWindow.Show();
			Application.Run();
		}
	}


}