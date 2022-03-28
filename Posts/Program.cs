//Please nstantiate manually the objects following de UML diagram. (Course)
//Posts, Title, Likes and Comments
using Posts.Entities;


Comment c1 = new Comment("Have a nice trip!");
Comment c2 = new Comment("Wow! That's absolutely awesome!!!");
Post p1 = new Post(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Traveling to Canada",
    "I'm going to live in this wonderful contry!",
    37);
p1.AddComment(c1);
p1.AddComment(c2);

Comment c3 = new Comment("Have a Good Night.");
Comment c4 = new Comment("May the force be with you");
Post p2 = new Post(
    DateTime.Parse("26/07/2018 23:14:09"),
    "Good Night, folks!",
    "See ya :)",
    12);
p2.AddComment(c3);
p2.AddComment(c4);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(p1);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(p2);

Console.ResetColor();
    


