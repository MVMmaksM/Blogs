namespace BlogsWebApi.Contracts.Responce
{
    public class ArticleResponce
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Text { get; set; }
        public int CountView { get; set; }
        public int CountLike { get; set; }
        public string Author { get; set; }
    }
}
