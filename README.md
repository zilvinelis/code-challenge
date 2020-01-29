# Welcome to Stormgeo Code Challenge!
## There will be a code challenge every month starting January 2020
## Each code challenge
- has a deadline
- solves a real world (existing stormgeo project) issue/problem
- follows the rules, but may have a specific set if needed
- has a ***prize*** for the best solution
## Rules
- Please ~~fork~~ **duplicate** this repository into your account and make it private so nobody can see your implementation prior to the deadline
- Work within the CodeChallenge Visual Studio solution and the project which corresponds to monthly challenge (CodeChallengeJanuary, February..)
- After you have polished the answer, give @zilvinelis access to your private repository. This must be done prior to the deadline.
## Evaluation
- All the answers will be evaluated according to these criteria
  - **Correctness** Does the algorithm work correclty and produce valid results. (0-5 points)
  - **Code Style** Is your code clean and readable. (0-3 points)
  - **Algorithm complexity** Is your algorithm the optimal solution and perform well. What is the complexity of your algorithm ([O(n)](https://en.wikipedia.org/wiki/Time_complexity)..) (0-2 points)
- Each application can be evaluated to the score in the range of 0-10

## Code Challenge #1 2020 January "Split"
### Implement the method to split vessel report/position list according to the rules
#### INPUT: position list, split type
#### OUTPUT: list of position lists (initial list grouped)
#### CONTEXT: The reports from the vessel comes in a specific order. Each report is described by the type and all the other additional properties. Usual report sequence looks like this (example starts from one port and ends in another port):
- ...
- NOON IN PORT
- NOON IN PORT
- DEPARTURE
- NOON AT MANEUVERING
- BOSP (BEGIN OF SEA PASSAGE)
- NOON AT SEA
- NOON AT SEA
- NOON AT SEA
- EOSP (END OF SEA PASSAGE)
- ARRIVAL
- NOON IN PORT
- ...
#### The interval from BOSP until EOSP is called a leg. The interval from DEPARTURE until ARRIVAL could be called Berth-to-berth.
#### You have to implement the method to get the legs or the berth-to-berth intervals out of the position list. The method should have a parameter which type of split to do.
#### NOTE: the input position list could start at any position. The result should include incomplete legs/berth-to-berths.
