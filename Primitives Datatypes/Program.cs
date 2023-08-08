
//Byte age = (byte) 10;//make it a byte

//Console.WriteLine( long.MinValue);

//Char x = 'X';

//var greeting = "He said \"Good Morning\"";

//string Path = "C:\\Users\\JonathanNdambuki\\Desktop\\The C# Tank\\Slides\\C#\\4. Datatypes";
//Console.WriteLine(greeting);


//; Console.WriteLine("The default value of Int is: " + default(int));



//numbers = (byte) (numbers+ 234);// Given permission to lose data  479-255

//Console.WriteLine(numbers);


using Primitives_Datatypes;
using System.Diagnostics;
using System.Text;

byte numbers = 245;


//Convert to int

int number1 = 2000;

byte numbers2 = (byte) number1;

Console.WriteLine(numbers2);

string numbers3 = "1123";
//int number4 = Convert.ToInt32(numbers3);
//int numbers5 = int.Parse(numbers3);
//int concertedNumber;
//var y= int.TryParse(numbers3, out concertedNumber);
//if (y)
//{
//    Console.WriteLine(concertedNumber);
//}
//else
//{
//    Console.WriteLine("An Error Occured");
//}

//var paragraph = "Hello There:\n \'GooodMorning\' ";
//Console.WriteLine(paragraph);

//var c = 'D';
//int s = 34;
//string n = s.ToString();

//Console.WriteLine(numbers5);

//var a = 10;
//var b = a;

//b += 10;

//Console.WriteLine(b);
//Console.WriteLine(a);

//person moris = new("moris",10);
//person queens = new("queens",12);
//console.writeline(queens.name);

//DateTime dateTime = new DateTime();


// targeted-typed-new //
//// Allocates space in Memory
///Create an Empty object {}
///point this to the empty object ({} is now called this)
//{
//    Name = "Moris Mwai",
//    Age = 20
//};

//Person moris2 = moris;
//moris.Name = "Wachira";

//Console.WriteLine(moris2.Name);

//string OurTitle = "My Title";


//var message = $$"""
// {
//   "userId": 1,
//   "id": 1,
//   "title": {{OurTitle}},
//   "body": "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
// },
// """;

//Console.WriteLine(message);



//var message2 = $"My Title is :{OurTitle}";
//var message1 = $"
//        {
//      "userId": 1,
//      "id": 1,
//      "title":{OurTitle},
//      "body": "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
//      }
//    "
//
//
//    ;



//var greetings = "Hello There";//its available for GC
//greetings = "Good Afternoon";//a new object is created 


//var stopWatch = new Stopwatch();
//StringBuilder sb = new StringBuilder();
//stopWatch.Start();

//for (var i = 0; i < 50000; i++)
//{
//    sb.Append(i.ToString());
//}

//stopWatch.Stop();

//var stopWatch1 = new Stopwatch();
//var num = 0;
//stopWatch1.Start();

//for (var i = 0; i < 500000; i++)
//{
//    num += i;
//}

//stopWatch1.Stop();

//Console.WriteLine($"It took :{stopWatch.ElapsedMilliseconds}ms to create this strings");
//Console.WriteLine($"It took :{stopWatch1.ElapsedMilliseconds}ms to create this Numbers");
////Console.WriteLine(sb);

//var name = "Emily Tiampati"; // "      "

//Console.WriteLine(name);
//Console.WriteLine(name.Trim());
//var index = name.IndexOf(' ');
//Console.WriteLine(index);
//;

////var x = name.Substring(5);

//Console.WriteLine(name);
//Console.WriteLine(name.Replace(" ", "  "));

//var x= name.Split(' ');
//Console.WriteLine(x[0]);
//Console.WriteLine(x[1]);


Console.WriteLine("Enter a Senetense");
var input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Please Enter Text");
}
else
{
    Capitalize cap = new(input);
    Console.WriteLine(cap.CapitalizeSentense());
}