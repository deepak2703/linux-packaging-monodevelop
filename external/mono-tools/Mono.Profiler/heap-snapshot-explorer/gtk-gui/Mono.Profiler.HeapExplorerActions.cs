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
    
    
    public partial class HeapExplorerActions {
        
        private Gtk.Action loadDataAction;
        
        private Gtk.Action filterByClassAction;
        
        private Gtk.Action filterByClassOfReferencedObjectAction;
        
        private Gtk.Action filterByClassOfReferencingObjectAction;
        
        public virtual void Build() {
            // Action group Mono.Profiler.HeapExplorerActions
            this.loadDataAction = new Gtk.Action("loadDataAction", Mono.Unix.Catalog.GetString("Load data"), null, "gtk-add");
            this.loadDataAction.ShortLabel = Mono.Unix.Catalog.GetString("Load data");
            this.Add(this.loadDataAction, null);
            this.filterByClassAction = new Gtk.Action("filterByClassAction", Mono.Unix.Catalog.GetString("Filter by class"), null, null);
            this.filterByClassAction.ShortLabel = Mono.Unix.Catalog.GetString("Filter by class");
            this.Add(this.filterByClassAction, null);
            this.filterByClassOfReferencedObjectAction = new Gtk.Action("filterByClassOfReferencedObjectAction", Mono.Unix.Catalog.GetString("Filter by class of referenced object"), null, null);
            this.filterByClassOfReferencedObjectAction.ShortLabel = Mono.Unix.Catalog.GetString("Filter by class of referenced object");
            this.Add(this.filterByClassOfReferencedObjectAction, null);
            this.filterByClassOfReferencingObjectAction = new Gtk.Action("filterByClassOfReferencingObjectAction", Mono.Unix.Catalog.GetString("Filter by class of referencing object"), null, null);
            this.filterByClassOfReferencingObjectAction.ShortLabel = Mono.Unix.Catalog.GetString("Filter by class of referencing object");
            this.Add(this.filterByClassOfReferencingObjectAction, null);
        }
    }
}