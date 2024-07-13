
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

int[] nums = {1,2,3,4,5,6,7,8,9};


// using forreach loop
// foreach(int n in nums){
//     if(n % 2 == 0)
//         Console.WriteLine(n);
// }

// using linq query
var query = from n in nums
            where n % 2 == 0
            orderby n descending
            select n;

// query is executed here
foreach(int n in query){
    Console.WriteLine(n);
}

List<string> names = ["Houston", "Austin", "Dallas", "Lubbock"];

var strquery = from n in names
                select new { Upper = n.ToUpper(), Lower = n.ToLower()};


foreach(var item in  strquery){
    System.Console.WriteLine(item);
}

int a = 10;

System.Console.WriteLine(a.GetType());

var q1 = nums.Where(i => i % 2  == 0).Select(n => n);

foreach(var item in q1){
    System.Console.WriteLine(item);
}


Func<int, int> myfunc1 = x => x * 2;
Func<int, int> myfunc2 = delegate (int x) {return x * 2;};

System.Console.WriteLine(myfunc1(10));
System.Console.WriteLine(myfunc2(20));


