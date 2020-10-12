using System;
namespace JanelaExemplo
{
    public partial class JanelaExemplo : Gtk.Window
    {
        public JanelaExemplo() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
