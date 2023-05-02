using System;
using System.IO;
using System.Text.Json;

public class Piece
    {
        public int PieceId { get; set; }
        public string? PieceState { get; set; }
        public int PiecePos { get; set; }
    }
public class Player
{
    public int PlayerId { get; set; }
    public Piece[] Pieces { get; set; }
}

class Program{
    static void Main(string[] args){
        Player player = new Player()
                {
                    PlayerId = 0,
                    Pieces = new Piece[]
                    {
                    new Piece{ PieceId = 0, PieceState = "InGame", PiecePos = 0},
                    new Piece{ PieceId = 1, PieceState = "Home", PiecePos = 0},
                    new Piece{ PieceId = 2, PieceState = "Home", PiecePos = 0},
                    new Piece{ PieceId = 3, PieceState = "Home", PiecePos = 0},
                    }
                };
        
        
        // Piece piece = new Piece { PieceId = 45, PiecePosition = 17, PieceState ="InGame"};
        // Piece piece2 = new Piece { PieceId = 12, PiecePosition = 0, PieceState ="InHomeBase"};

        //serialize the object
        string serializedText = JsonSerializer.Serialize(player);
        // string serializedText2 = JsonSerializer.Serialize(piece2);
        
        //Save jsom to file
        //Try using StreamWriter ERROR
        // using (StreamWriter writer = new StreamWriter("JsonStreamWriter.json")){
        //     JsonSerializer.Serialize(writer, serializedText);
            //fs.WriteLine(serializedText, 0, serializedText.Length);
        // }
        
        File.WriteAllText("Pieces.json", serializedText);
        // File.WriteAllText("Pieces.json", serializedText2);


        //Read the json file
        string jsonText = File.ReadAllText("Pieces.json");
        
        //Deserialize the json file
        Player desPlayer = JsonSerializer.Deserialize<Player>(jsonText);

        Console.WriteLine(jsonText);
        Console.WriteLine(desPlayer);
        Console.WriteLine($"Deserialized Player: {desPlayer.PlayerId}, {desPlayer.Pieces}");


    }
}
