
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Projects.OptionPanels
{
	internal partial class CombineBuildOptionsWidget
	{
		private global::Gtk.VBox vbox68;
		private global::Gtk.Label label73;
		private global::Gtk.HBox hbox46;
		private global::Gtk.Label label74;
		private global::MonoDevelop.Components.FolderEntry folderEntry;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Projects.OptionPanels.CombineBuildOptionsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Ide.Projects.OptionPanels.CombineBuildOptionsWidget";
			// Container child MonoDevelop.Ide.Projects.OptionPanels.CombineBuildOptionsWidget.Gtk.Container+ContainerChild
			this.vbox68 = new global::Gtk.VBox ();
			this.vbox68.Name = "vbox68";
			this.vbox68.BorderWidth = ((uint)(12));
			// Container child vbox68.Gtk.Box+BoxChild
			this.label73 = new global::Gtk.Label ();
			this.label73.Name = "label73";
			this.label73.Xalign = 0F;
			this.label73.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Output Directory</b>");
			this.label73.UseMarkup = true;
			this.vbox68.Add (this.label73);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox68 [this.label73]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox68.Gtk.Box+BoxChild
			this.hbox46 = new global::Gtk.HBox ();
			this.hbox46.Name = "hbox46";
			this.hbox46.Spacing = 6;
			// Container child hbox46.Gtk.Box+BoxChild
			this.label74 = new global::Gtk.Label ();
			this.label74.Name = "label74";
			this.label74.LabelProp = global::Mono.Unix.Catalog.GetString ("    ");
			this.hbox46.Add (this.label74);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox46 [this.label74]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox46.Gtk.Box+BoxChild
			this.folderEntry = new global::MonoDevelop.Components.FolderEntry ();
			this.folderEntry.Name = "folderEntry";
			this.hbox46.Add (this.folderEntry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox46 [this.folderEntry]));
			w3.Position = 1;
			this.vbox68.Add (this.hbox46);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox68 [this.hbox46]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(6));
			this.Add (this.vbox68);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
