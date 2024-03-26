namespace Design_pattern
{
    public class PlainDecorator : Decorator<string>
    {
        string? _prefix = "Hello! How are You? ";
        public PlainDecorator(IComponent<string> icomponent, string Prefix) : base(icomponent)
        {
            _prefix = Prefix;
        }


        public override string GetText()
        {
            return _prefix + base.GetText();
        }
    }
}
