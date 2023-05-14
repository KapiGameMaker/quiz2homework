class quiz2 {
    static public void Main(String[] args)
    {
        bool isend = false;
        char decision;
        while(!isend)
        {
            string dna = Console.ReadLine();
            if(IsValidSequence(dna) == true)
            {
                Console.WriteLine("Current half DNA sequence : {0}",dna);
                Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                 
                while(true)
                {
                    char decision1 = char.Parse(Console.ReadLine());
                    if(decision1 == 'Y')
                    {
                        Console.WriteLine("Replicated half DNA sequence : {0}",ReplicateSeqeunce(dna));
                        break;  
                    }
                    else if(decision1 == 'N')
                    {
                        break;
                    }
                    else Console.WriteLine("Please input Y or N.");
                }
                   
            }
            else 
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
            isend = ReturnProgram();
        }       
    }


    static bool ReturnProgram()
    {
        char decision = char.Parse(Console.ReadLine());
        if(decision == 'Y')
        {
            return true;
        }
        else if(decision == 'N')
        {
            return false;
        }
        else return ReturnProgram();
    }

    static bool IsValidSequence(string halfDNASequence)
    {
        foreach(char nucleotide in halfDNASequence)
        {
            if(!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach(char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}
