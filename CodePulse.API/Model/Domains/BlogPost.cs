namespace CodePulse.API.Model.Domains
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String ShortDescription { get; set; }
        public String Content { get; set; }
        public String FeaturedImageUrl { get; set; }
        public String UrlHandle { get; set; }
        public String PublishedDate { get; set; }
        public String Auther { get; set; }
        public bool IsVisible { get; set; }

    }
}
