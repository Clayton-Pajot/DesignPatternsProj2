using CP_Proj2;
using System;
using System.Collections.Generic;

namespace CP_Proj2
{
    class Program
    {
        public static Post clone()// CLONE METHOD FOR PROTOTYPES
        {
            Post prototype = new Post("Title Placeholder", "Body Placeholder");
            return prototype;

        }
        static void Main(string[] args)
        {

            //==================================== VARIABLES ====================================

            List<PostProxy> Posts = new List<PostProxy>();

            PostProxy p1 = new PostProxy();
            Posts.Add(p1);

            PostProxy p2 = new PostProxy();
            Posts.Add(p2);

            PostProxy p3 = new PostProxy();
            Posts.Add(p3);
            int postCount = 3;


            //================== ----------- ====================================
            //==================    BEGIN    ====================================
            //================== ----------- ====================================
            Console.WriteLine("Welcome to the Social Network!\nEnter a command to get started, or 'help' to see a list of commands:");
            string command = "";

            while(command != "quit") {
                string[] commandArgs = command.Split(':');
                int postNum = -1;
                if(commandArgs.Length > 1) {
                    try {
                        postNum = int.Parse(commandArgs[1]);
                    } catch(FormatException) {
                        Console.WriteLine("Error: Invalid post number specified!");
                    }

                    if(postNum < 0 || postNum > Posts.Count) {
                        Console.WriteLine("Error: Invalid post number specified!");
                        break;
                    }
                }

                //================== ----------- ====================================
                //================== HELP & MENU ====================================
                //================== ----------- ====================================
                switch (commandArgs[0]) {
                    case "help":
                        Console.WriteLine("help\t\t\tDisplay this menu");
                        Console.WriteLine("new\t\t\tCreate a new post.");
                        Console.WriteLine("list\t\t\tList all posts.");
                        Console.WriteLine("download:[id]\t\tDownload a post.");
                        Console.WriteLine("settitle:[id]:[title]\tSet a post's title.");
                        Console.WriteLine("setbody:[id]:[body]\tSet a post's body.");
                        Console.WriteLine("view:[id]\t\tView a post.");
                        Console.WriteLine("quit\t\t\tQuit the application");
                        break;
                    // ============= NEW ====================================================
                    case "new":
                        Post newPost = clone();
                        postCount++;
                        PostProxy pp = new PostProxy(newPost);
                        Posts.Add(pp);
                        Console.WriteLine("Added new post at index " + (postCount-1));
                        break;
                    // ============= LIST ====================================================
                    case "list":
                        
                        for(int i = 0; i < Posts.Count; i++)
                        {
                            Console.WriteLine(i + "\t" + Posts[i].getProxyTitle());
                        }
                        break;
                    // ============= DOWNLOAD ====================================================
                    case "download":
                        for (int i = 0; i < Posts.Count; i++)
                        {
                            if (i == postNum)
                            {
                                FancyPost np = new FancyPost(clone());
                                Posts[i] = new PostProxy(np);
                                break;
                            }
                        }
                        break;
                    // ============= SET TITLE ====================================================
                    case "settitle":
                        for (int i = 0; i < Posts.Count; i++)
                        {
                            if (i == postNum)
                            {
                                
                                Posts[i].setProxyTitle(commandArgs[2]);
                                break;
                            }
                        }
                        break;
                    // ============= SET BODY ====================================================
                    case "setbody":
                        for (int i = 0; i < Posts.Count; i++)
                        {
                            if (i == postNum)
                            {
                                if (Posts[i].realContent == null)
                                {
                                    Posts[i].realContent = new Post();
                                }

                                Posts[i].setProxyBody(commandArgs[2]);
                            }
                        }
                        break;
                    // ============= VIEW ====================================================
                    case "view":
                        for (int i = 0; i < Posts.Count; i++)
                        {
                            if (i == postNum)
                            {
                                Posts[i].DisplayPost();
                            }
                        }
                        break;
                    // ============= INVALID COMMAND ====================================================
                    default:
                        if(command != "") {
                            Console.WriteLine("Invalid command.");
                        }
                        break;
                }
                Console.Write("\n>");
                command = Console.ReadLine();
            }
        }
    }
}
