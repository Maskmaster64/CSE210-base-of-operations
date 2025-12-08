using System;

class Program
{
    static void Main(string[] args)
    {
        Video firstVideo = new Video("My First Video", "Ashton Fairhurst", 240);
        Comment firstComment = new Comment("Dad", "Congrats on your first video");
        Comment hello = new Comment("Bill", "Hi ashton.");
        Comment goodLuck = new Comment("Will", "Good luck with your next video");

        firstVideo.AddComment(firstComment);
        firstVideo.AddComment(hello);
        firstVideo.AddComment(goodLuck);

        firstVideo.DisplayVideo();
        firstVideo.DisplayComments();
    }
}