using System;

namespace CP_Proj2
{
    class PostProxy : Content
    {
        public Post realContent;
        int id = -1;


        //======== CONSTRUCTORS ====================================================================================
        public PostProxy()  { }
        public PostProxy(Post content)
        { 
            this.realContent = content;

        }

        //======== GETTERS ====================================================================================
        public string getProxyTitle()
        {
            string result = "";
            try
            {
                result = realContent.getTitle();

            }
            catch (Exception e)
            {
                result = "Loading...";
            }
            
            
            return result;
        }
        public string getProxyBody()
        {
            string result = "";
            try
            {
                result = realContent.getBody();

            }
            catch (Exception e)
            {
                result = "Loading...";
            }
            
            return result;
        }


        //======== SETTERS ====================================================================================
        public void setProxyTitle(string title) 
        {
            try
            {
                realContent.setTitle(title);

            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot set title: Post is not loaded.");
            }
        }

        public void setProxyBody(string body) 
        {
            try
            {
                realContent.setBody(body);

            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot set body: Post is not loaded.");
            }
        }


        //======== DISPLAY POST ====================================================================================
        public void DisplayPost()
        {
            if(realContent == null)
            {
                Console.WriteLine("Cannot display: Post is not loaded.");
            }
            else
            {
                realContent.DisplayPost();
            }
            
        }
    }
}
