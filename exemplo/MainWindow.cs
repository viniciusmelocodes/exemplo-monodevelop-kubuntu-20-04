using System;
using exemplo;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnCliqueAqui(object sender, EventArgs e)
    {
        MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
            MessageType.Info,
            ButtonsType.Ok, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed nec justo volutpat, luctus nisl ut, rhoncus odio. Sed dui est, mattis id blandit eget, dignissim ut ante. Suspendisse congue, ex non semper vestibulum, augue nisi auctor libero, imperdiet imperdiet leo diam quis purus. Vestibulum sapien massa, imperdiet commodo dolor vitae, malesuada viverra ex. Duis ornare volutpat lectus. Integer nec rhoncus enim. Duis maximus, velit vitae viverra luctus, arcu orci scelerisque leo, non posuere quam risus viverra lectus. Donec in rutrum elit. Ut ac sem lacus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt lectus eu ligula venenatis maximus. Quisque ac tellus a leo semper porttitor non et magna.");
        md.Run();
        md.Destroy();
    }

    protected void OnCliqueNovaJanela(object sender, EventArgs e)
    {
        Janela2 win = new Janela2();
        win.Show();
    }
}
