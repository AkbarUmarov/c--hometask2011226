//task1

// List<int> number1 = new List<int>{1,2,3,4,5,6,7,8,9};

// int sum=0;
// foreach(var number2 in number1)
// {
//     sum+=number2;
// }
// System.Console.WriteLine(sum);

//task2

// List<string> text = ["akbar", "ruslan", "ALAJOAJO","HUGYTNBV", "UGASDFGHJK"];

// text.Sort((a,b) => b.Length.CompareTo(a.Length));

// foreach(var text1 in text)
// {
//     System.Console.WriteLine(text1+ " ");
// }

//task3
// List<Person> pers = new List<Person>
// {

// };



// class Person
// {
//     public string Name {get; set;}
//     public int Age{get; set;}

//      public GetInfo(string n, int a)
//     {
//         Name = n;
//         Age = a;
//     }

// }


//task4

// List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9};

// numbers.RemoveAll(x=> x%2!=0);

// foreach(var n1 in numbers)
// {
//     System.Console.Write(n1+" ");
// }

//task5

// List<string> texts = new List<string>{"Akbar", "Ruslan","muminov", "Akabrov"};

// foreach(var tex in texts)
// {
//     System.Console.Write(new string (tex.ToUpper())+" ");
// }

//task6



// List<int> texts = new List<int>{1,2,3,4,5,6,99,-2,9};
// int a=0;
// int b=0;
// a=texts.Max();
// b=texts.Min();
// System.Console.Write(a+ " ");
// System.Console.Write(b+" ");


//task7

// List<string> text = ["akbbar", "umarovu","ruslana", "akakann","amir"];

// foreach(var item in text)
// {
//     System.Console.WriteLine(new string(item.ToLower().Distinct().ToArray()));
// }

//task8

// List<int> age = new List<int> {15,20, 25, 30};
// int avg = 0;
//  int sum=0;
// foreach(var ag in age)
// {
//     sum+=ag;
// }
// avg=sum/age.Count;
// System.Console.WriteLine(avg);

//task9

// List<int> number = new List<int>{10,20,30,4,50,20,10,52,99,88,25,99};

// List<int> numbers = number.Distinct().ToList();

// foreach(var item in numbers)
// {
//     System.Console.Write(item+" ");
// }

//task10

// List <string> text = new List<string>{"Akabr", "Rulan", "kazak","Amir","level"};


// foreach(var tx1 in text)
// {
//     tx1.Reverse();
// }

//task13

// List<int> number = new List<int>{1,2,3,4,5,6,7,8,9};

// int index=0;
// int sum = 0;

// foreach(var toq in number)
// {
//    if(index%2!=0)
//     {
//         sum+=toq;
//     }
//     index++;
// }
// System.Console.WriteLine($"Summa nechotnix indexov : {sum}");

//task14
// List<string> texts = new List<string>{"AkabrUmarov", "Akbar", "Umarov", "Amir", "Umar"};

// string dlinatex = texts [0];
// foreach (var item in texts)
// {
//     if(item.Length>dlinatex.Length)
//     {
//         dlinatex = item;
//     }
// }
// System.Console.WriteLine(dlinatex);

//task15


class Student
{
    public string Name{get; set;}

    public void GetInfo()
    {
        System.Console.WriteLine($"Name: {Name}");
    }
    
}

