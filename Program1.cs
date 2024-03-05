string pangram = "The quick brown fox jumps over the lazy dog";
string[] wordsOfPangram = pangram.Split(" ");
string pangramReversed = "";

foreach (string word in wordsOfPangram)
{
  char[] letters = word.ToCharArray();

  Array.Reverse(letters);

  string reversedWord = String.Join("", letters);

  pangramReversed += reversedWord + " ";

}
System.Console.WriteLine(pangramReversed);
