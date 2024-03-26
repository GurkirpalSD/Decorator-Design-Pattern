namespace Design_pattern
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "What's going on?";
        }
    }
}
