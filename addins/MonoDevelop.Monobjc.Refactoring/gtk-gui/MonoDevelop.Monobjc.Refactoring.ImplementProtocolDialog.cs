
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Monobjc.Refactoring
{
	internal partial class ImplementProtocolDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow GtkScrolledWindowProtocols;

		private global::Gtk.TreeView treeviewProtocols;

		private global::Gtk.ScrolledWindow GtkScrolledWindowMembers;

		private global::Gtk.TreeView treeviewMembers;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Monobjc.Refactoring.ImplementProtocolDialog
			this.Name = "MonoDevelop.Monobjc.Refactoring.ImplementProtocolDialog";
			this.Title = "";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			// Internal child MonoDevelop.Monobjc.Refactoring.ImplementProtocolDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindowProtocols = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindowProtocols.Name = "GtkScrolledWindowProtocols";
			this.GtkScrolledWindowProtocols.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindowProtocols.Gtk.Container+ContainerChild
			this.treeviewProtocols = new global::Gtk.TreeView ();
			this.treeviewProtocols.CanFocus = true;
			this.treeviewProtocols.Name = "treeviewProtocols";
			this.GtkScrolledWindowProtocols.Add (this.treeviewProtocols);
			this.vbox2.Add (this.GtkScrolledWindowProtocols);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindowProtocols]));
			w3.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindowMembers = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindowMembers.Name = "GtkScrolledWindowMembers";
			this.GtkScrolledWindowMembers.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindowMembers.Gtk.Container+ContainerChild
			this.treeviewMembers = new global::Gtk.TreeView ();
			this.treeviewMembers.CanFocus = true;
			this.treeviewMembers.Name = "treeviewMembers";
			this.GtkScrolledWindowMembers.Add (this.treeviewMembers);
			this.vbox2.Add (this.GtkScrolledWindowMembers);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindowMembers]));
			w5.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w7.Position = 0;
			// Internal child MonoDevelop.Monobjc.Refactoring.ImplementProtocolDialog.ActionArea
			global::Gtk.HButtonBox w8 = this.ActionArea;
			w8.Name = "dialog1_ActionArea";
			w8.Spacing = 6;
			w8.BorderWidth = ((uint)(5));
			w8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8[this.buttonCancel]));
			w9.Expand = false;
			w9.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8[this.buttonOk]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 595;
			this.DefaultHeight = 469;
			this.Hide ();
		}
	}
}
