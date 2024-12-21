# DotNet Personal Code Bank

This project is a collection of each concept of C# so that I have a frame of reference for
what I know and what I do not.

These sections have been written in the order of the following article https://www.scholarhat.com/tutorial/csharp/csharp12-developer-roadmap

# Table of Contents

1. [If and Else](#if_and_else)
1. [Switch and Case](#switch_and_case)
1. [For Loop](#for_loop)


## Basic Syntax
This section is made up of projects that show how to use simple syntax and control structures.

### If and Else <a name="if_and_else"></a>

The project to showcase this is the **HigherOrLower.Cli** project. This is a simple
game where a user has to guess a number between 0 and 100 in *7* guesses.

I have used If and Else statements here to handle the following logic

- Has the User won the game (guessed the correct number)
- If they haven't
	- Have they guessed Lower than the number or higher than the number


### Switch and Case <a name="switch_and_case"></a>

The project to showcase this is  the **SimpleMenuSystem.Cli** project. This is a 
simple system that takes a user input, validates it and then performs an action
based on the user's option.

Using a switch case statement here allows:
- Actions to be performed based on an extendable varienty of options
- An easier to read layout compared to a large if, else if , else block
- Ensures that there are cases for each scenario (the compiler helps here)

### For Loop <a name="for_loop"></a>

The project to showcase this is the **ShoppingListManager.Cli** project. This is a 
system that has taken the lesson learnt from the <a href="#switch_and_case" >Switch and Case</a>
project for its menu system.

The main use of the **for loop** here is to iterate over the items in the shopping list and 
output them to the user.