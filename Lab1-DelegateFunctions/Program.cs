//Lab: Delegate Functions
//Write a delegate that returns a string from a method with a signature of (string wordArg, int numArg).
//Use it to invoke one method that returns a word concatenated x number of times,and then a method that removes x many letters from the end of the word.
//实验室。委托函数
//编写一个委托函数，从一个签名为(string wordArg, int numArg)的方法返回一个字符串。
//用它来调用一个方法，该方法返回一个串联了x次的单词，然后调用一个方法，从单词的末尾删除x个字母。


MyDelegate PrintNumTimes = (string wordArg, int numArg) =>
{
    string result = "";

    for (int i = 0; i < numArg; i++)
    {
        result += wordArg;
    }
    return result;
};

MyDelegate RemoveLettersFromRnd = (string wordArg, int numArg) =>
{
    string result = wordArg.Substring(0, wordArg.Length - numArg);

    return result;
};

Console.WriteLine(PrintNumTimes("HelloWorld", 3));
Console.WriteLine(RemoveLettersFromRnd("HelloWorld", 3));

delegate string MyDelegate(string word, int num);