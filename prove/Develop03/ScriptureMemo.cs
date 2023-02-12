using System;
using System.Collections.Generic;

class ScriptureReference
{
    private string reference;

    public ScriptureReference(string reference)
    {
        this.reference = reference;
    }

    public string GetReference()
    {
        return reference;
    }
}

class Scripture
{
    private ScriptureReference reference;
    private List<ScriptureWord> words;
    private List<ScriptureWord> hiddenWords;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(x => new ScriptureWord(x)).ToList();
        hiddenWords = new List<ScriptureWord>();
    }

    public int GetWordsLeft()
    {
        return words.Count - hiddenWords.Count;
    }

    public void Display()
    {
        Console.WriteLine(reference.GetReference());
        foreach (ScriptureWord word in words)
        {
            if (hiddenWords.Contains(word))
            {
                Console.Write("__ ");
            }
            else
            {
                Console.Write(word.GetWord() + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordIndex = random.Next(0, words.Count - hiddenWords.Count);
        int hiddenWordCount = 0;
        for (int i = 0; i < words.Count; i++)
        {
            if (!hiddenWords.Contains(words[i]))
            {
                if (hiddenWordCount == wordIndex)
                {
                    hiddenWords.Add(words[i]);
                    break;
                }
                hiddenWordCount++;
            }
        }
    }
}




class ScriptureWord
{
    private string word;


    public ScriptureWord(string word)
    {
        this.word = word;
    }

    public string GetWord()


    {
        return word;
    }
}
