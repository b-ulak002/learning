namespace Solid.Interface_Segregation_Principle.Example1
{
    public class Contact : IEmailable, IDiallable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
    }
}
