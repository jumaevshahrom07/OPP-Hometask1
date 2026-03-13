// using Hometask;

// Person person = new Person()
// {
//     FirstName = "Shahrom",
//     LastName = "Jumaev",
//     Age = 19,
//     Address = "Dushanbe",
// };

// Console.WriteLine(person.GetFullName());
// Console.WriteLine($"My birth year is {person.GetBirthYear()}");


// using Hometask;

// // Rectangle rectangle = new Rectangle()
// // {
// //     Width = 7,
// //     Height =  5
// // };

// Rectangle rectangle1 = new Rectangle();
// rectangle1.Width = Convert.ToDouble(Console.ReadLine());
// rectangle1.Height = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Area = {rectangle.Area()}");


// using Hometask;

// Student student1 = new Student()
// {
//     Name = "Shahrom Jumaev",
//     GradeLevel = 11,
//     TestScores = new int [] {80, 85, 90}
// };

// Student student2 = new Student()
// {
//     Name = "Akbar Jumaev",
//     GradeLevel = 10,
//     TestScores = new int [] {80, 90, 100}
// };

// Student[] students = {student1, student2};
// foreach (var item in students)
// {
//     double average = item.GetAverage();

//     if (average > 85)
//     {
//         Console.WriteLine($"Congratulations {item.Name} on achieving above average scores ({average}) in grade {item.GradeLevel}!");
//         Console.WriteLine("Keep up the good work!");
//     }

//     else if (average < 70)
//     {
//         Console.WriteLine($"{item.Name}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {average} in grade {item.GradeLevel}.");
//     }
//     else
//     {
//         Console.WriteLine($"Congratulations {item.Name} on achieving an average score of {average} in grade {item.GradeLevel}!");
//         Console.WriteLine("Keep working hard for even better results!");
//     }
// }

using Hometask;

Car myCar = new Car("Toyota", "Camry", 2022, 0, 10);

Console.WriteLine($"Make: {myCar.Make}");
Console.WriteLine($"Model: {myCar.Model}");
Console.WriteLine($"Year: {myCar.Year}");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");

Console.WriteLine();
myCar.Drive(100);

myCar.AddFuel(10);

Console.WriteLine($"\nAfter the trip and refueling:");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");