using System.Collections;

namespace DICTIONARY1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,ArrayList> verbs = new Dictionary<string,ArrayList>()
   {
       {"go",new ArrayList{"went  " ,"gone"} } ,
       {"speak",new ArrayList{"spoke  ","spoken" } },
                {"take",new ArrayList{"took  ","taken"} } ,
                {"eat",new ArrayList{"ate  ","eaten" } },
                {"break", new ArrayList{"broke  ","broken"} },
                {"be",new ArrayList{"was,were  ","been"} },
                {"drink",new ArrayList{"drank  ","drunk"} },
                {"give",new ArrayList{"gave  ","given"} },
                {"know",new ArrayList{"knew  ","known"} },
                {"make",new ArrayList{"made  ","made"} }
   };
            Console.WriteLine("              IRREGULAR VERBS                  ");
            Console.WriteLine("      ------------------------------------           ");
            Console.Write("VERBS -->>>  ");
            foreach(string s in verbs.Keys)
            {
                Console.Write(s+"\t");
            }
            Console.WriteLine();
            Console.Write("VERBS2-->>   ");
            foreach(var v in verbs.Values)
            {
                Console.Write(v[0]);
            }
            Console.WriteLine();
            Console.Write("VERBS3-->>   ");
            foreach (var v in verbs.Values)
            {
                Console.Write(v[1]+"\t");
            }
        }
        }
    }

