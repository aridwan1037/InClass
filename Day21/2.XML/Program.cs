using System;
using System.IO;
using System.Xml.Serialization;

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

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player()
        {
            Pieces = new Piece[]
                    {
                    new Piece{ PieceId = 0, PieceState = "InGame", PiecePos = 9},
                    new Piece{ PieceId = 1, PieceState = "Home", PiecePos = 0},
                    new Piece{ PieceId = 2, PieceState = "Home", PiecePos = 0},
                    new Piece{ PieceId = 3, PieceState = "Home", PiecePos = 0},
                    },
            
            PlayerId = 0
        };


        //serialize the object
        XmlSerializer serializer = new XmlSerializer(typeof(Player));
        using (StreamWriter writer = new StreamWriter("player.xml"))
        {
            serializer.Serialize(writer, player);
        }

        // Deserialize the object
        Player deserialized;
        using (StreamReader reader = new StreamReader("player.xml"))
        {
            deserialized = (Player)serializer.Deserialize(reader);
        }

        Console.WriteLine(deserialized);


        //Console.WriteLine($"Deserialized Person: {deserializedPerson.Name}, {deserializedPerson.Age}");
    }
}
