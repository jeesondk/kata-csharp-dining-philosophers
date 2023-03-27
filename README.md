# Code kata Dining Philosophers

## Language
Csharp, .NET 6

## Problem
Dining Philosophers Problem States that there are 5 Philosophers who are engaged in two activities Thinking and Eating. Meals are taken communally in a table with five plates and five forks in a cyclic manner as shown in the figure.

### Constraints and Condition for the problem
Every Philosopher needs two forks in order to eat.
Every Philosopher may pick up the forks on the left or right but only one fork at once.
Philosophers only eat when they had two forks. We have to design such a protocol i.e. pre and post protocol which ensures that a philosopher only eats if he or she had two forks.
Each fork is either clean or dirty.
