# Challenge

- Create an application that chooses an int between 0 and 100, inclusive, at random.
- The User will be explained the game and given 10 opportunites to guess the number. 
- The program will tell the user if the random number is higher or lower than their guess.
- The program will print out a list of the users guesses for each turn in this format, "50, 20, 35"
- After 10 unsuccessful guesses, the user loses and is given an opportiunity to play again.

# Constraints
- You must have a GetRandomNumber() method to get the random number between 0 and 100, inclusive, an int.
- You must have a GetUsersGuess() method to get users input, validate that is is an in between 0 and 100, includive, and return the int. Reprompt until the user enters a correct value.
- You must have a CompareNums() method to compare the random number and the user input.
- You must have a PlayGameAgain() method to offer the user the chance to play again. Return true if they want to play again and false if they do not.
- Replay the game until the user chooses not to play again.
- You cannot use the .NET .CompareTo() method. You must create your own method to compare user input to the random number chosen.

 # Note 
 - Make sure to follow SOLID Principles.
 - This game will require the Random Class ('System' Namespace) - https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netcore-3.1
 - It is not best practice to have user interaction within a method, but we are doing it here to allow testing.
 - EVERY method is called in Main() and returns to Main().