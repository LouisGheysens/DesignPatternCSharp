using AdapterPattern.Interfaces;


namespace AdapterPattern
{
    public class Adapter: IPerson
    {
        private readonly Adaptee _adapter;

        public Adapter(Adaptee adapter)
        {
            this._adapter = adapter;
        }

        public string SayHello()
        {
            return $"This is '{this._adapter.SayHello()}'";
        }
    }
}