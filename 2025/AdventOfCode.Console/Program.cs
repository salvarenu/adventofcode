// See https://aka.ms/new-console-template for more information
using AdventOfCode.Console;
using AdventOfCode2025;

Console.WriteLine("Hello, World!");

IFileOperations fileOperations = new FileOperations();

//Day01 day01 = new Day01(fileOperations);

//Console.WriteLine("Day 01 - Part 1 Result:" + day01.Part1());

//Console.WriteLine("Day 01 - Part 2 Result:" + day01.Part2());

//Day02 day02 = new Day02(fileOperations);

//Console.WriteLine("Day 02 - Part 1 Result: " + day02.Part1());

//Console.WriteLine("Day 02 - Part 2 Result: " + day02.Part2());

Day03 day03 = new Day03(fileOperations);

Console.WriteLine("Day 03 - Part 1 Result: " + day03.Part1());

Console.WriteLine("Day 03 - Part 2 Result: " + day03.Part2());
