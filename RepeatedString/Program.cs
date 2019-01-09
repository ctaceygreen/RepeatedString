using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        var stringLength = s.Length;
        var endStringLength = (int)(n % stringLength);
        long numberOfFullString = (n / stringLength);

        long numberOfA = s.Count(c => c == 'a');
        long numberOfAInEnd = endStringLength == 0 ? 0 : s.Take(endStringLength).Count(c => c == 'a');

        return numberOfAInEnd + (numberOfFullString * numberOfA);

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
