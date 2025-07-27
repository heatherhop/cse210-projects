using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning to Code in C# 101", "Professor Code", 600);
        video1._comments.Add(new Comment("Heather Gray", "This video was so helpful. I am grateful for Professor Code!"));
        video1._comments.Add(new Comment("Garith Stone", "I learned so much from your examples."));
        video1._comments.Add(new Comment("Rich Sheff", "I have had a hard time following the flow of the video."));
        video1._comments.Add(new Comment("Tiffany Shore", "I found the examples to be too complex for a beginnner. Maybe dumb them down a bit."));
        videos.Add(video1);

        Video video2 = new Video("How to Change the Oil in Your Car", "Jason Clayton", 720);
        video2._comments.Add(new Comment("Lora Poulsen", "This video was so helpful. I think I can now change my oil and save money."));
        video2._comments.Add(new Comment("MJ Hopkins", "I would love if you made a video with my exact make and model."));
        video2._comments.Add(new Comment("Christian Lane", "I found this to be the most helpful video on oil changes so far."));
        video2._comments.Add(new Comment("Monet Gunderson", "I hope that I can learn how to do this for myself each time the oil needs to be changed."));
        videos.Add(video2);

        Video video3 = new Video("My Trip to Belize", "Andrea Wilding", 1800);
        video3._comments.Add(new Comment("Justin Carpenter", "Thank you for all of the information and suggestions. I can't wait to make my trip happen later this year."));
        video3._comments.Add(new Comment("Joey Hacking", "This video was so helpful for planning my trip to Belize. Do you have any other videos for other South American trips?"));
        video3._comments.Add(new Comment("Eva Stock", "I loved all of the beautiful pictures that you shared. So amazing!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
        
    }
}