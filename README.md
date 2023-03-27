# Code kata Dining Philosophers

## Language
Csharp, .NET 6

## Problem
Dining Philosophers Problem States that there are 5 Philosophers who are engaged in two activities Thinking and Eating. Meals are taken communally in a table with five plates and five forks in a cyclic manner as shown in the figure.

### Constraints and Condition for the problem
1. Every Philosopher needs two forks in order to eat.
2. Every Philosopher may pick up the forks on the left or right but only one fork at once.
3. Philosophers only eat when they had two forks. We have to design such a protocol i.e. pre and post protocol which ensures that a philosopher only eats if he or she had two forks.
4. Each fork is either clean or dirty.

## Acecptance Criteria
1. Mutual Exclusion Principle, No two Philosophers can have the two forks simultaneously.
2. Free from Deadlock, Each philosopher can get the chance to eat in a certain finite time.
3. Free from Starvation When few Philosophers are waiting then one gets a chance to eat in a while.
4. No strict Alternation.
5. Proper utilization of time.