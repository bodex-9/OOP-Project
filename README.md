# Exam System (OOP Console App)

A C# console application that models a simple exam system, built as an OOP practice project. It demonstrates core object-oriented concepts: **inheritance**, **abstraction**, **polymorphism**, and interface implementation (`ICloneable`, `IComparable`).

## Overview

The app models a `Subject` that holds one `Exam`. An exam can be a `FinalExam` or a `PracticalExam`, and each is made up of `Question`s (`MCQQuestion` or `TrueFalseQuestion`), each with a set of possible `Answer`s and one correct answer.

## Project Structure

Project/
├── Program.cs # Entry point / demo
├── Answers/
│ └── Answer.cs # Represents a single answer option
├── Question/
│ ├── Question.cs # Base question class
│ ├── MCQQuestion.cs # Multiple-choice question
│ └── TrueFalseQuestion.cs # True/False question
├── Exams/
│ ├── Exam.cs # Abstract base exam class
│ ├── FinalExam.cs # Concrete exam: shows questions + grade
│ └── PracticalExam.cs # Concrete exam: shows questions + answer key
└── Subjects/
└── Subject.cs # Holds a subject and its assigned exam


## Classes

| Class | Description |
|---|---|
| `Answer` | Id + text of an answer option. Implements `ICloneable`, `IComparable` (by `AnswerId`). |
| `Question` | Base class: header, body, mark, answers, right answer. Implements `ICloneable`, `IComparable` (by `Mark`). |
| `MCQQuestion` | Multiple-choice question, inherits `Question`. |
| `TrueFalseQuestion` | True/False question, inherits `Question`. |
| `Exam` | Abstract base: time, question count, questions array. Declares abstract `ShowExam()`. Implements `ICloneable`, `IComparable` (by `Time`). |
| `FinalExam` | Prints all questions/answers and the total grade. |
| `PracticalExam` | Prints all questions/answers, then a separate answer key. |
| `Subject` | Holds a subject id/name and one assigned `Exam`. |

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (targets `net10.0`)

## Run

```bash
cd Project
dotnet run
```

## Unit Tests

Unit tests live in a separate `Project.Tests` project (xUnit), covering constructors, `ToString()`, `Clone()`, `CompareTo()`, and `ShowExam()` output for every class.

```bash
cd Project.Tests
dotnet test
```

## Tech Stack

- C# / .NET
- xUnit (testing)

## Author

**Abdullah Mhrous**
GitHub: [@bodex-9](https://github.com/bodex-9)
