using System;
// To exceed requirements, I "gamified" this proram and made it where the user can level up each time they pass a 1000 point threshold
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}