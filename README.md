# Higher or Lower

A simple console-based number guessing game developed in **C# using .NET**. This project was created to strengthen my understanding of C# programming fundamentals and practice building applications independently.

## Features

- **Random Number Generation:** Generates a random number between 1 and 100.
- **Guess Feedback:** Tells the player whether their guess is too high or too low.
- **Input Validation:** Uses `int.TryParse()` to handle non-numeric inputs without crashing.
- **Guess Counter:** Tracks the number of attempts needed to guess the correct number.
- **Replay System:** Allows players to start a new round without restarting the application.
- **Exit Option:** Players can choose to quit after completing a round.

## Technologies Used

- C#
- .NET
- Visual Studio Code

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- A terminal or code editor such as Visual Studio Code

### Installation

**1. Clone the repository**

```bash
git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
```

**2. Navigate to the project directory**

```bash
cd YOUR-REPOSITORY
```

**3. Run the application**

```bash
dotnet run
```

Run the command from the directory containing the `.csproj` file.

## How to Play

1. Launch the application.
2. Enter a number between 1 and 100.
3. The game will tell you whether your guess is too high or too low.
4. Continue guessing until you find the correct number.
5. Once you win, the game displays your total number of guesses.
6. Enter `Y` to play another round or `N` to exit.

## Example Gameplay

```text
Welcome to the Number Guessing Game!
The guess is from 1 - 100! I will let you know if you need to go higher or lower!

25
Too low!

75
Too high!

50
Congrats! The correct answer was 50
You needed 3 guesses to get the correct number!

Would you like to play again? (Y/N)
n
Thank you so much for playing my game!
```

## What I Learned

Building this project helped me practice several core C# concepts:

- Using variables and data types to manage application state.
- Implementing `while` loops and conditional statements.
- Creating reusable methods with return values.
- Validating user input with `int.TryParse()`.
- Generating random numbers with the `Random` class.
- Managing multiple game rounds within a single application.

This project is part of my journey toward becoming a more confident and independent software developer.
