namespace Grafies;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Form f1 = new Form();

        Button btn = new Button { Text = "Hallo" };
        btn.Location = new Point(100, 200);
        btn.Click += ClickMe;

        btn.MouseHover += Hooooover;

        f1.Controls.Add(btn);

        f1.ShowDialog();
    }

    private static void Hooooover(object? sender, EventArgs e)
    {
        Button b = (Button)sender;
        b.BackColor = Color.Purple;
    }

    static void ClickMe(object? sender, EventArgs e)
    {
        Button b = (Button)sender;
        b.Parent.BackColor = Color.Red;
        b.Parent.Text = "Hoi";
    }
}