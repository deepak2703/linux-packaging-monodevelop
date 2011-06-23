
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.SourceEditor
{
	internal partial class GotoLineNumberWidget
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry entryLineNumber;
		private global::Gtk.Button buttonGoToLine;
		private global::Gtk.EventBox eventbox2;
		private global::Gtk.Image image2;
		private global::Gtk.Button closeButton;
		private global::Gtk.EventBox eventbox1;
		private global::Gtk.Image image1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.SourceEditor.GotoLineNumberWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.SourceEditor.GotoLineNumberWidget";
			// Container child MonoDevelop.SourceEditor.GotoLineNumberWidget.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryLineNumber = new global::Gtk.Entry ();
			this.entryLineNumber.CanFocus = true;
			this.entryLineNumber.Name = "entryLineNumber";
			this.entryLineNumber.IsEditable = true;
			this.entryLineNumber.InvisibleChar = '●';
			this.hbox1.Add (this.entryLineNumber);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryLineNumber]));
			w1.Position = 0;
			w1.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonGoToLine = new global::Gtk.Button ();
			this.buttonGoToLine.CanDefault = true;
			this.buttonGoToLine.CanFocus = true;
			this.buttonGoToLine.Name = "buttonGoToLine";
			this.buttonGoToLine.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child buttonGoToLine.Gtk.Container+ContainerChild
			this.eventbox2 = new global::Gtk.EventBox ();
			this.eventbox2.Name = "eventbox2";
			this.eventbox2.AboveChild = true;
			this.eventbox2.VisibleWindow = false;
			// Container child eventbox2.Gtk.Container+ContainerChild
			this.image2 = new global::Gtk.Image ();
			this.image2.Name = "image2";
			this.image2.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-jump-to", global::Gtk.IconSize.Menu);
			this.eventbox2.Add (this.image2);
			this.buttonGoToLine.Add (this.eventbox2);
			this.buttonGoToLine.Label = null;
			this.hbox1.Add (this.buttonGoToLine);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonGoToLine]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.closeButton = new global::Gtk.Button ();
			this.closeButton.CanFocus = true;
			this.closeButton.Name = "closeButton";
			this.closeButton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child closeButton.Gtk.Container+ContainerChild
			this.eventbox1 = new global::Gtk.EventBox ();
			this.eventbox1.Name = "eventbox1";
			this.eventbox1.AboveChild = true;
			this.eventbox1.VisibleWindow = false;
			// Container child eventbox1.Gtk.Container+ContainerChild
			this.image1 = new global::Gtk.Image ();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-close", global::Gtk.IconSize.Menu);
			this.eventbox1.Add (this.image1);
			this.closeButton.Add (this.eventbox1);
			this.closeButton.Label = null;
			this.hbox1.Add (this.closeButton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.closeButton]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
