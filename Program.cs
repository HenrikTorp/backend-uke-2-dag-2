namespace backend_uke_2_dag_2;

class Program
{
    static void Main(string[] args)

    {

    var Data = new Dictionary<string, string>(); // to be filled with data we learn about the user
    
    Console.WriteLine("Hello I am a program trying to understand you, type something!");
    Console.WriteLine("If you want to exit, type 'exit'");
    string inputandtype = InputType();
    string type = inputandtype.Split(" ")[1];
    string input = inputandtype.Split(" ")[0];
    Console.WriteLine($"I read this as data of type {type}");

    if (type == "int")
    {
        int number = int.Parse(input);
        Console.WriteLine($"Is {number} your age? Type yes or no");
        inputandtype = InputType();
        type = inputandtype.Split(" ")[1];
        input = inputandtype.Split(" ")[0];

        if (type == "string")
        {
            if (input == "yes")
            {
                Console.WriteLine("Good to know, can you also enter your name?");
                inputandtype = InputType();
                type = inputandtype.Split(" ")[1];
                while (type != "string")
                {
                    Console.WriteLine("That is not a name");
                    inputandtype = InputType();
                    type = inputandtype.Split(" ")[1];
                    continue;

                }
                
                
                    string nameRaw = inputandtype.Split(" ")[0];
                    string name = nameRaw[0].ToString().ToUpper() + nameRaw.Substring(1).ToLower();
                    Console.WriteLine($"Hello {name} of age {number}, nice to meet you!");
                    Data.Add("Name", name);
                    Data.Add("Age", number.ToString());
                
            }
            else if (input == "no")
            {
                Console.WriteLine("I am sorry, I will try to do better next time");
            }
            else
            {
                Console.WriteLine("I am sorry, I did not understand that");
            }
        }
        else 
        {
            Console.WriteLine("That is a number, not a string");
        }

    }
    else if (type == "double")
    {
        double Dnumber = double.Parse(input);
        Console.WriteLine($"Is  {Dnumber} your age? Type yes or no");
    }
    else
    {
        Console.WriteLine($"The input {input} is a string");
    }

    }
    // Console.WriteLine("What is your name?");
    // string name = InputHandler();
    
    // Console.WriteLine($"Hello {name}! How old are you?");
    // string ageString = InputHandler();
    // if (!int.TryParse(ageString, out int age))
    // {
    //     Console.WriteLine("Please write a number");
    //     ageString = InputHandler();
    // }
    // Console.WriteLine($"So {name}, that means that in 100 years you will be {age + 100} years old!");

    // }

    //     static string InputHandler()
    // {
    //     string? input = Console.ReadLine();
        

    //     while (string.IsNullOrWhiteSpace(input))
    //     {
    //         Console.WriteLine("Please write something");
    //         input = Console.ReadLine();
    //     }

    //     input = input[0].ToString().ToUpper() + input.Substring(1).ToLower();
    //     return input;
    // }

    static string InputType()
    {
        string? input = Console.ReadLine();
        

        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Please write something");
            input = Console.ReadLine();
        }

        if (input.ToLower() == "exit")
        {
            Environment.Exit(0);
            return "exit exit";
        }

        else if (int.TryParse(input, out _))
        {
            return $"{input} int";
        }

        else if (double.TryParse(input, out _))
        {
            return $"{input} double";
        }

        else
        {
            return $"{input} string";
        }

    }

    // static string YesOrNo()
    // {
    //     // reusing previous method to handle the input
    //     string inputandtype = InputType();
    //     string type = inputandtype.Split(" ")[1];  

    //     while (type != "string")
    //     {
    //         Console.WriteLine("Press yes or no please");
    //         inputandtype = InputType();
    //         type = inputandtype.Split(" ")[1];
    //         while(type != "string")
    //         {
    //             Console.WriteLine("Please type yes or not");
    //             inputandtype = InputType();
    //             type = inputandtype.Split(" ")[1];
    //             continue;
    //         }

    //         string input = inputandtype.Split(" ")[0];
    //         if (input.ToLower() == "yes")
    //         {
    //             return "yes";
    //         }
    //         else if (input.ToLower() == "no")
    //         {
    //             return "no";
    //         }
    //         else
    //         {
    //             Console.WriteLine("I did not understand that");
    //             return "error";
    //         }

    //     }
    // }










}

    