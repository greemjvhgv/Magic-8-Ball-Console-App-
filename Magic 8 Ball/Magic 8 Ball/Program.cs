using Magic_8_Ball;

var randoAnswer = AnswerGenerator.GenerateAnswer();
var randomThinkingMessage = AnswerGenerator.ThinkingMessageGenerate();


Console.ForegroundColor = ConsoleColor.Blue;
    string text = @"

     _______               __            ______      ______         __ __ 
    |   |   |.---.-.-----.|__|.----.    |  __  |    |   __ \.---.-.|  |  |
    |       ||  _  |  _  ||  ||  __|    |  __  |    |   __ <|  _  ||  |  |
    |__|_|__||___._|___  ||__||____|    |______|    |______/|___._||__|__|
                   |_____|                                                
                                                              
    ";
        Console.WriteLine(text);

    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("-Ask The Magic 8 Ball A Question!- ");
       var question = Console.ReadLine();

    while (string.IsNullOrEmpty(question))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-!Please Enter A Question!-");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
            question = Console.ReadLine();
     }


    Console.WriteLine($"\n{randomThinkingMessage}");
        Thread.Sleep(2000);

  Console.ForegroundColor = ConsoleColor.Blue; 

    Console.WriteLine($"{randoAnswer}");

Console.ForegroundColor = ConsoleColor.White;

Console.ReadKey();

