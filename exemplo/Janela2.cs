using System;
using Gtk;
using System.Data;
using MySql.Data.MySqlClient;

namespace exemplo
{
    public partial class Janela2 : Gtk.Window
    {
        public Janela2() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        private void connectionMysql()
        {
            string connectionString =
              "Server=localhost;" +
              "Database=mysql;" +
              "User ID=root;" +
              "Password=(E6}?qjq/38Y7j{7;" +
              "Pooling=false";
            IDbConnection dbcon;
            dbcon = new MySqlConnection(connectionString);
            dbcon.Open();

            IDbCommand dbcmd = dbcon.CreateCommand();
            // requires a table to be created named employee
            // with columns firstname and lastname
            // such as,
            //        CREATE TABLE employee (
            //           firstname varchar(32),
            //           lastname varchar(32));
            string sql =
                "SELECT host, user " +
                "FROM user";
            dbcmd.CommandText = sql;
            IDataReader reader = dbcmd.ExecuteReader();

            while (reader.Read())
            {
                string host = (string)reader["host"];
                string user = (string)reader["user"];
                textview1.Buffer.Text = "Host: " + host + " : Usuário:" + user;
            }

            // clean up
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbcon.Close();
            dbcon = null;
        }

        protected void OnCliqueAquiMensagem(object sender, EventArgs e)
        {
            MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent,
            MessageType.Info,
            ButtonsType.Ok, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed nec justo volutpat, luctus nisl ut, rhoncus odio. Sed dui est, mattis id blandit eget, dignissim ut ante. Suspendisse congue, ex non semper vestibulum, augue nisi auctor libero, imperdiet imperdiet leo diam quis purus. Vestibulum sapien massa, imperdiet commodo dolor vitae, malesuada viverra ex. Duis ornare volutpat lectus. Integer nec rhoncus enim. Duis maximus, velit vitae viverra luctus, arcu orci scelerisque leo, non posuere quam risus viverra lectus. Donec in rutrum elit. Ut ac sem lacus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt lectus eu ligula venenatis maximus. Quisque ac tellus a leo semper porttitor non et magna.");
            md.Run();
            md.Destroy();
        }

        protected void OnShown(object sender, EventArgs e)
        {
            this.connectionMysql();
        }

        protected void OnFocused(object o, FocusedArgs args)
        {
            this.connectionMysql();
        }
    }
}
