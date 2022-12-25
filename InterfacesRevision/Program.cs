using InterfacesRevision;

List<IControl> formControls = new List<IControl>();

Button button1 = new Button();
button1.Type = "Button";
TextBox textBox1 = new TextBox();
textBox1.Type = "Text";

formControls.Add(button1);
formControls.Add(textBox1);

foreach(ControlNew item in formControls)
{
    Console.WriteLine(item.GetText());
    if(item.Type == "Button")
    {
        Console.WriteLine(((Button)item).ClickButton());
    }
}

//IControl ctrl = new Button();
//((Button)ctrl).ClickButton();


//Button btn = new Button();
//btn.ClickButton();
