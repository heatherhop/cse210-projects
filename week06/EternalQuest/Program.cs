using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Showing Creativity and Exceeding Requirements - I added a 
        // member variable _totalGoalsAccomplished that counts the 
        // accomplished goals and gives a 50 point bonus after 3 completed goals
        GoalManager manager = new GoalManager(0);
        manager.Start();
    }
}