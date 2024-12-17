// Defining a string array of fraudulent numbers
string[] fraudulentNums = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

/* Looping through the fraudulentNums array and using .StartsWith()
method checking which item of fraudulentNums array starts with letter B */
foreach (string ids in fraudulentNums){
    if(ids.StartsWith("B")){
        Console.WriteLine(ids);
    }
}