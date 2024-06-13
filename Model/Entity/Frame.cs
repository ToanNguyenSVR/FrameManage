namespace Frame_Manager.Model.Entity
{
    public class Frame
    {
        public string Id { get; set; }
        public List<object> ListFrame { get; set; }
        public List<object> ListLike { get; set; }
        public List<object> ListComment { get; set; }
        public string Name { get; set; }
        public string NameKo { get; set; }
        public string NameEn { get; set; }
        public string Url { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public int CategoryType { get; set; }
        public string TypeFrame { get; set; }
        public int Price { get; set; }
        public int CountCut { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Version { get; set; }
        public int CountComment { get; set; }
        public int CountLike { get; set; }
    }
}


