// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Mono.Profiler {
    
    
    public partial class LoadedClassChooser {
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.NodeView ClassList;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Mono.Profiler.LoadedClassChooser
            this.Name = "Mono.Profiler.LoadedClassChooser";
            this.Title = Mono.Unix.Catalog.GetString("Choose item");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            // Internal child Mono.Profiler.LoadedClassChooser.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.ClassList = new Gtk.NodeView();
            this.ClassList.CanFocus = true;
            this.ClassList.Name = "ClassList";
            this.ClassList.Reorderable = true;
            this.ClassList.SearchColumn = 0;
            this.GtkScrolledWindow.Add(this.ClassList);
            w1.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(w1[this.GtkScrolledWindow]));
            w3.Position = 0;
            // Internal child Mono.Profiler.LoadedClassChooser.ActionArea
            Gtk.HButtonBox w4 = this.ActionArea;
            w4.Name = "dialog1_ActionArea";
            w4.Spacing = 6;
            w4.BorderWidth = ((uint)(5));
            w4.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w5 = ((Gtk.ButtonBox.ButtonBoxChild)(w4[this.buttonCancel]));
            w5.Expand = false;
            w5.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(w4[this.buttonOk]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.Response += new Gtk.ResponseHandler(this.OnOK);
            this.Close += new System.EventHandler(this.OnCancel);
        }
    }
}