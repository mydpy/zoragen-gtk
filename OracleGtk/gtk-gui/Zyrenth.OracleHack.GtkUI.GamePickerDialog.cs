
// This file has been generated by the GUI designer. Do not modify.
namespace Zyrenth.OracleHack.GtkUI
{
	public partial class GamePickerDialog
	{
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.NodeView nvInfos;
		
		private global::Zyrenth.OracleHack.GtkUI.FilePreviewWidget previewWidget;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Zyrenth.OracleHack.GtkUI.GamePickerDialog
			this.Name = "Zyrenth.OracleHack.GtkUI.GamePickerDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child Zyrenth.OracleHack.GtkUI.GamePickerDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nvInfos = new global::Gtk.NodeView ();
			this.nvInfos.CanFocus = true;
			this.nvInfos.Name = "nvInfos";
			this.GtkScrolledWindow.Add (this.nvInfos);
			this.hbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.GtkScrolledWindow]));
			w3.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.previewWidget = new global::Zyrenth.OracleHack.GtkUI.FilePreviewWidget ();
			this.previewWidget.Events = ((global::Gdk.EventMask)(256));
			this.previewWidget.Name = "previewWidget";
			this.hbox3.Add (this.previewWidget);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.previewWidget]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			w1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox3]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Internal child Zyrenth.OracleHack.GtkUI.GamePickerDialog.ActionArea
			global::Gtk.HButtonBox w6 = this.ActionArea;
			w6.Name = "dialog1_ActionArea";
			w6.Spacing = 10;
			w6.BorderWidth = ((uint)(5));
			w6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6 [this.buttonCancel]));
			w7.Expand = false;
			w7.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6 [this.buttonOk]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 155;
			this.Show ();
			this.nvInfos.RowActivated += new global::Gtk.RowActivatedHandler (this.OnNvInfosRowActivated);
		}
	}
}