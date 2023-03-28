using System;

namespace CP_Proj2
{
    abstract class Content
    {
        public virtual string getTitle() { return "Placeholder Title"; }
        public virtual string getBody() { return "Placeholder Body"; }

        public virtual void print() { }

        public virtual void DisplayPost() { }

        public virtual void setTitle(string t) { }
        public virtual void setBody(string b){}
        
        
    }
}
