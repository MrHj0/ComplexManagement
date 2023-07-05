namespace Complex_Management_nogit.Entities
{
    public class Complex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitCount { get; set; }
        public List<Block> Blocks { get; set; }
    }
}
