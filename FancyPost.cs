using System;

namespace CP_Proj2
{
    class FancyPost : Post
    {

        public string Title;
        public string Body ;

        public FancyPost() { }
        public FancyPost(Post post)
        {
            this.Title = post.getTitle();
            this.Body = post.getBody();
        }
        public FancyPost(string t, string b) : base(t, b)
        {
            this.Title = t;
            this.Body = b;
        }


        //======== GETTERS ==========================================================================
        public override string getTitle() { return Title; }
        public override string getBody() { return Body; }

        //======== SETTERS ===========================================================================
        public override void setTitle(string t) { Title = t; }
        public override void setBody(string b) { Body = b; }


        //======== PRINT ==========================================================================
        protected override string GetPostTitle() 
        {
            string fancyTitle = "----------------------------------------\n" + Title + "\n----------------------------------------";
            return fancyTitle;
        }

        protected override string GetPostBody()
        {
            string fancyBody = "\n================================================\n" + Body + "\n================================================\n";
            return fancyBody;
        }


        //======== DISPLAY POST ===========================================================================
        public override void DisplayPost()
        {
            Console.WriteLine(GetPostTitle() + "\n" + GetPostBody());
        }
    }
}
