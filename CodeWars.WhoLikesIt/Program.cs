using System;
using System.Text;

namespace CodeWars.WhoLikesIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Likes(new string[0])); //=> "no one likes this"
            Console.WriteLine(Kata.Likes(new[] { "Peter" })); // => "Peter likes this"
            Console.WriteLine(Kata.Likes(new[] { "Jacob", "Alex" })); // => "Jacob and Alex like this"
            Console.WriteLine(Kata.Likes(new[] { "Max", "John", "Mark" })); // => "Max, John and Mark like this"
            Console.WriteLine(Kata.Likes(new[] { "Alex", "Jacob", "Mark", "Max" })); // => "Alex, Jacob and 2 others like this"
        }
    }

    public static class Kata
    {
        ////Best Practices
        //public static string Likes(string[] names)
        //{
        //    switch (names.Length)
        //    {
        //        case 0: return "no one likes this"; // :(
        //        case 1: return $"{names[0]} likes this";
        //        case 2: return $"{names[0]} and {names[1]} like this";
        //        case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
        //        default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
        //    }
        //}

        public static string Likes(string[] name)
        {
            string regular = name.Length == 1 ? "s" : string.Empty;
            string sb = string.Empty;

            if (name.Length == 0)
                return "no one likes this";


            switch (name.Length)
            {
                case 1:
                    {
                        foreach (string t in name)
                            sb = $"{t} likes this";

                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < name.Length; i++)
                            sb += $"{name[i]} {(i == 0 ? "and " : "")}";
                        sb += "like this";
                        break; ;
                    }
                case 3:
                    {
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (i == 0)
                                sb += $"{name[i]}, ";
                            else if (i == 1)
                                sb += $"{name[i]} and ";
                            else
                                sb += $"{name[i]}";
                        }
                        sb += " like this";
                        break;
                    }
                default:
                    {
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (i == 0)
                                sb += $"{name[i]}, ";
                            else if (i == 1)
                                sb += $"{name[i]} and ";
                        }
                        sb += $"{name.Length - 2} others like this";
                        break;
                    }
            }
            //sb = $"{sb}like{regular} this";
            return sb;
        }
    }


  


}
