using Facade;

ScoreClienteFacade score = new();

var Score = score.Score("07078585285", "4654645655");

Console.WriteLine("O Score do cliente é: " + Score);
