// C# is a strongly typed language
// C# likes detail
// Javascript -> var/let/const 
// var number = "Hello"
// Python -> don't have variable declarators
// number = "Hello"

// C# you MUST declare a data type from the beginning
// int number = 10; // this is valid C# code
// int number = "Hello" // C# is going to get very mad at me

// Why do we like this?
// Because efficiency
// It will only use up as much space in memory as it needs, and it KNOWS how much space to use because we declared the variable types from the beginning

// Compile our code BEFORE RUNTIME
// C# checks our code BEFORE we run it - this saves us on errors and time
// From the beginning we will write less buggy code

// If we are going to write C# code, we must follow these rules:
// Rule #1: you MUST declare a data type
    // This means you have to know what you're working with to start
    // This makes you intentional with the code you write, so you have a better idea from the very beginning what you are doing
// Rule #2: you should name your variable - pro tip: name it something that makes sense
    // Troll: string number - if someone reads this and thinks number should be taking an integer
// Rule #3: C# can get a little weird
    // It can be SO verbose you don't know what's happening anymore
    // int[] anyNameIWant = new int[5]; // I would do this if I knew I had 5 values, but I don't know what those values are yet
    // or 
    // int[] array = new int[] {1,2,3,4,5}; // I would do this if I already know exactly what values I'm using
    // OR 
    // int[] array = {3,4,8,4,1}; // This is the line above but slightly less typing
    // It does this because of memory efficiency
    // We don't just have an array, we have an array with a specific # of values, which takes up a specific amount of space in memory
// Rule #4: Semicolons are God - you must have it or it will not work

// Javascript
// var number
// var name
// var isTrue

// C#
// int number
// string name
// bool isTrue

// Character c1 = new Character();

// Data types we use the most in this class:
// int - string - bool - List<type>

// It all comes down to that concept of memory conservation

// C# DOES have a var, and you can use it to stand in for a data type. It's just not good practice

// Big takeaway: It takes practice

// What we can and can't do - comes down to practice