using System;
using System.IO;

class Documents
{
    private string[] fileForVoting = File.ReadAllLines(@"E:\Push\VotingSystem_2\VotingSystem\VotingSystem1.2\Documents.txt");

    public Documents() { }
    public void Count()
    {
        Console.WriteLine("За гласуване има постъпили => "+fileForVoting.Length+" документа");
    }
    public int Counter()
    {
        return fileForVoting.Length;
    }
}

