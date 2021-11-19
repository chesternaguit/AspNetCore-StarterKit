namespace Model.Entities
{
    public class Brand : Base.BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Tax { get; set; }
    }
}
