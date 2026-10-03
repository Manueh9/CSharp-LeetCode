# LeetCode Practice — Try It Yourself

This repo collects LeetCode exercises I've solved, but it's set up so you can
use it as a **challenge**, not just an answer key:

1. Open a problem's `.md` file and read the statement.
2. Try to solve it yourself first.
3. Only then open the matching `.cs` file to see (or compare against) the
   solution.

No solution code is shown in the problem `.md` files — the only place the
answer lives is the `.cs` file, so you won't spoil it just by reading the
problem.

## Problems

| # | Problem | Difficulty | Category |
|---|---------|------------|----------|
| 01 | [Concatenation of Array](problems/arrays/01_ConcatenationOfArray/01_ConcatenationOfArray.md) | Easy | Array |
| 02 | [Shuffle the Array](problems/arrays/02_ShuffleTheArray/02_ShuffleTheArray.md) | Easy | Array |
| 03 | [Max Consecutive Ones](problems/arrays/03_FindMaxConsecutiveOnes/03_FindMaxConsecutiveOnes.md) | Easy | Array |
| 04 | [Set Mismatch](problems/arrays/04_SetMismatch/04_SetMismatch.md) | Easy | Array |
| 05 | [How Many Numbers Are Smaller Than the Current Number](problems/arrays/05_SmallerNumbersThanCurrent/05_SmallerNumbersThanCurrent.md) | Easy | Array |
| 06 | [Find All Numbers Disappeared in an Array](problems/arrays/06_FindDisappearedNumbers/06_FindDisappearedNumbers.md) | Easy | Array |

## Running a solution

This is a .NET console project. Each solution's `Run()` method is wired into
`Program.cs` via a category + problem number:

```
dotnet run <Category> <ProblemNumber>

# example
dotnet run Array 03
```

## Repo convention

Each solved problem lives in its own folder under `problems/<category>/`,
named after the problem, containing a pair of files sharing the same base
name:

```
problems/<category>/NN_ProblemName/
    NN_ProblemName.cs   — the solution, with a Run() method wired into Program.cs as usual
    NN_ProblemName.md   — the problem statement (description, examples,
                           constraints, and a link to the .cs file), following
                           the format used in the three problems above
```

When adding a new solved problem, create the folder with both files and add a
new row to the table above.
