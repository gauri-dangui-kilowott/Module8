// See https://aka.ms/new-console-template for more information
// Challenge to make the code more readble 

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

/*
 To reverse a string and count the number of times a particular character appears.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] changedMessage = originalMessage.ToCharArray();

Array.Reverse(changedMessage);

int count = 0;

foreach (char i in changedMessage) 
{ 
    if (i == 'o') 
    { 
        count++; 
    } 
}

string newMessage = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {count} times.");
