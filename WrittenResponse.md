# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.
The purpose of the program is to provide entertainment for a person by having them guess a random 5-letter word.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

This video demonstrates that a certain color will be displayed based on the accuracy of a word. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. It will then return a certain color (Green if correct, yellow if the letter is in the word, but not the right place, and white if the letter is not a part of the word at all), based on the accuracy of their guess. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
public static string GetRandomWord()
        {
            List<string> words = new List<string>();
            words.Add("abuse");
            words.Add("adult");
            words.Add("agent");
            words.Add("anger");
            words.Add("apple");
            ...
            words.Add("watch");
            words.Add("water");
            words.Add("while");
            words.Add("white");
            words.Add("whole");
            words.Add("woman");
            words.Add("world");
            words.Add("youth");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];

            // program.loadfile(words.txt);


            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return randomWord;
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in "words".

### 3b iv.

Describes what the data contained in the list represents in your program

The list contains all possible words that can be generated and guessed.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list allows me to use as many words as I want using a single variable. Without a list, I would have to use a different variable for each word. Then, to select a random word, I would need to write an if / else if statement for each possible word. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static void DisplayInfo(string guess, string correct)
        {
            if (guess.Length != correct.Length)
            {
                throw new Exception($"Expected {guess} and {correct} to have the same length.");
            }

            int ix = 0;

            while (ix < correct.Length)
            {
                char guessChar = guess[ix];
                char correctChar = correct[ix];

                DisplayCharInfo(guessChar, ix, correct);
                ix = ix + 1;

            }

            // 1. Get random word
            // 2. Display number of letters in the word
            // 3. Prompt player to enter a guess

            return;

        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
else
{
    DisplayInfo(input, correctWord);
    Console.WriteLine("");
}
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

This method makes sure that the guess is the correct length (5 letters long), and checks whether or not each letter is in the word or not. Then it displays the info that tells the player which letters are correct, incorrect, and in the word but not the right position. This contributes to the overall functionality of the program by helping the player to guess the correct word by telling them how close their guess is to the correct word each time they make a guess. 
### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.
1. Checks if the guess has the correct length
2. If not, it will throw an exception and ask the player to put in a guess that is the correct length
3. Iterate through each character
    * Check each letter and display the info for each character

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
 program.DisplayInfo("snack", "snake");

Condition(s) tested by the second call:

 program.DisplayInfo("star", "snake");

### 3d iii.

Result of the first call:

You see "snack" in green letters except for a red 'c' and a yellow 'k'

Result of the second call:

The result is that the exception is thrown.
