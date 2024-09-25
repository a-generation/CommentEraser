using System.Text.RegularExpressions;

class CommentEraser
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            PrintUsage();
            return;
        }

        if (args.Length != 2)
        {
            Console.WriteLine("Usage: commenteraser.exe \"targetfile\" language");
            PrintUsage();
            return;
        }

        string filePath = args[0];
        string language = args[1].ToLower();

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Error: File '{filePath}' not found.");
            return;
        }

        try
        {
            string fileContent = File.ReadAllText(filePath);
            string cleanedContent = RemoveComments(fileContent, language);

            File.WriteAllText(filePath, cleanedContent);
            Console.WriteLine($"Comments removed from '{filePath}' for language '{language}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void PrintUsage()
    {
        Console.WriteLine("CommentEraser Usage:");
        Console.WriteLine("commenteraser.exe \"targetfile\" language");
        Console.WriteLine("\nSupported languages:");
        Console.WriteLine("- python");
        Console.WriteLine("- javascript");
        Console.WriteLine("- css");
        Console.WriteLine("- html");
        Console.WriteLine("- html+javascript+css");
        Console.WriteLine("- csharp");
        Console.WriteLine("- php");
        Console.WriteLine("- java");
        Console.WriteLine("- ruby");
        Console.WriteLine("- cpp (C/C++)");
    }

    static string RemoveComments(string content, string language)
    {
        switch (language)
        {
            case "python":
                return RemovePythonComments(content);
            case "javascript":
                return RemoveJavaScriptComments(content);
            case "css":
                return RemoveCSSComments(content);
            case "html":
                return RemoveHTMLComments(content);
            case "html+javascript+css":
            case "javascript+html+css":
            case "css+html+javascript":
            case "html+css+javascript":
                return RemoveHTMLAndJavaScriptAndCSSComments(content);
            case "csharp":
                return RemoveCSharpComments(content);
            case "php":
                return RemovePHPComments(content);
            case "java":
                return RemoveJavaComments(content);
            case "ruby":
                return RemoveRubyComments(content);
            case "cpp":
                return RemoveCppComments(content);
            default:
                Console.WriteLine("Error: Unsupported language.");
                return content;
        }
    }

    static string RemovePythonComments(string content)
    {
        return Regex.Replace(content, @"#.*", "");
    }

    static string RemoveJavaScriptComments(string content)
    {
        return Regex.Replace(content, @"(//.*?$|/\*.*?\*/)", "", RegexOptions.Singleline | RegexOptions.Multiline);
    }

    static string RemoveCSSComments(string content)
    {
        return Regex.Replace(content, @"/\*.*?\*/", "", RegexOptions.Singleline);
    }

    static string RemoveHTMLComments(string content)
    {
        return Regex.Replace(content, @"<!--.*?-->", "", RegexOptions.Singleline);
    }

    static string RemoveHTMLAndJavaScriptAndCSSComments(string content)
    {
        content = RemoveHTMLComments(content);
        content = RemoveCSSComments(content);
        content = RemoveJavaScriptComments(content);
        return content;
    }

    static string RemoveCSharpComments(string content)
    {
        return Regex.Replace(content, @"(//.*?$|/\*.*?\*/)", "", RegexOptions.Singleline | RegexOptions.Multiline);
    }

    static string RemovePHPComments(string content)
    {
        return Regex.Replace(content, @"(//.*?$|#.*?$|/\*.*?\*/)", "", RegexOptions.Singleline | RegexOptions.Multiline);
    }

    static string RemoveJavaComments(string content)
    {
        return Regex.Replace(content, @"(//.*?$|/\*.*?\*/)", "", RegexOptions.Singleline | RegexOptions.Multiline);
    }

    static string RemoveRubyComments(string content)
    {
        return Regex.Replace(content, @"#.*", "");
    }

    static string RemoveCppComments(string content)
    {
        return Regex.Replace(content, @"(//.*?$|/\*.*?\*/)", "", RegexOptions.Singleline | RegexOptions.Multiline);
    }
}
