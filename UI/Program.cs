using System;
using Xwt;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;

namespace UI
{
	

class XwtDemo {
    [STAThread]
    static void Main ()
    {
        Application.Initialize (ToolkitType.Gtk);
        var mainWindow = new Window (){
            Title = "Xwt Demo Application",
            Width = 500,
            Height = 400
        };
        mainWindow.Show ();
        Application.Run ();
        mainWindow.Dispose ();
    }
}
/*
    public static class SWDRecorder_Program
    {
        
        [STAThread]
	public class TreeViewTests: ScrollableWidgetTests
	{
		public override Widget CreateWidget ()
		{
			return new TreeView ();
		}

		public override IScrollableWidget CreateScrollableWidget ()
		{
			DataField<string> text = new DataField<string> ();
			TreeStore s = new TreeStore (text);
			var list = new TreeView (s);
			list.Columns.Add ("Hi", text);

			for (int n = 0; n < 100; n++) {
				var r = s.AddNode ();
				r.SetValue (text, n + new string ('.',100));
			}
			return list;
		}

		[Test]
		public void HiddenTree ()
		{
			var f = new DataField<string> ();
			TreeStore ts = new TreeStore (f);
			var node = ts.AddNode ().SetValue (f, "1").AddChild ().SetValue (f, "2").AddChild ().SetValue (f, "3");
			var tree = new TreeView (ts);

			Window w = new Window ();
			Notebook nb = new Notebook ();
			nb.Add (new Label ("Hi"), "One");
			nb.Add (tree, "Two");
			w.Content = nb;
			ShowWindow (w);

			tree.ScrollToRow (node.CurrentPosition);

			tree.Columns.Add ("Hi", f);

			tree.ScrollToRow (node.CurrentPosition);
		}
	}
    }
    */
}
