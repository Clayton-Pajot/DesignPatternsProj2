using System;

namespace CP_Proj2
{
    class Post : Content
    {
        public string Title;
        public string Body;


        public Post() { }
        public Post(Post content) {
            this.Title = content.getTitle();
            this.Body  = content.getBody();
        }
        public Post(string t, string b) {
            this.Title = t;
            this.Body = b;
        }
        //======== GETTERS ==================================================================================
        public override string getTitle() { return Title; }
        public override string getBody() { return Body; }

        //======== SETTERS ==================================================================================
        public override void setTitle(string t) { Title = t; }
        public override void setBody(string b) { Body = b; }

        //======== PRINT =================================================================================
        public void print() { Console.WriteLine(GetPostTitle() + "\n" + GetPostBody()); }

        protected virtual string GetPostTitle() { return Title; }

        protected virtual string GetPostBody() {  return Body;  }


        //======== DISPLAY POST ===========================================================================
        public override void DisplayPost() { Console.WriteLine(Title+ "\n" + Body); }
    }
}
