
using System.ComponentModel.Design;

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
                where n.Length == 6
                select n.ToUpper();


foreach(var item in  strquery){
    System.Console.WriteLine(item);
}