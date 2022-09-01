#Tenis 01


## step by step

- Code review (20mins)
- Added extra test coverage (30mins)
- Refactor immediate return for readability (6mins)
- Refactor function to get score points string representation (15mins)
- Switch tidy up (5mins)

## why is this important

Keeping code "in shape" by refactoring and doing proper testing has several benefits that are not always easy to see, but make a big impact in the long run. 

Some of the benefits of having clean tested code are: 

- Applications less prone to errors; Good testing methodology and practices are proben to give a more resilient source code that can grow in time, without breaking due to side effects, after a future feature addition or change in requirements.

- Better long term productivity; Both having less errors and a properly architected solution and test coverage provide a good base to build on. This avoids the typical productivity lost seen in projects with long life spans that don't follow this rules. It also allows for easier and smoother onboarding of new developers that will need much less support to understand the current code base.

- Happier developers; Having to constantly fight with hard to understand code base or non tested and undocumented behavior will definitelly create an unnecesary burden in developers, wich may start making mistakes and may also end in a broken window theory that spirals into unmaintainable, expensive to develop projects. Developers leaving the company in those conditions have the additional problem of the lost undocumented know-how wich is an added cost, both in developer hours and lost opportunities due to low productivity.

## recommendations for collegue

- Tests seem to have too much responsability, that lead into a failing implementation on player names other than the ones expected to be used inside the test covered cases. I usually try to avoid hardcoded constats on tests if possible and use random values instead to avoid missing this kind of case. 
Tests names should be descriptive of what it´s expected to improve readability and also avoid this cases.

- To improve readability I would recommend to return immediatelly when we have a result instead of storing it into a variable and returning as last statement in the method.

- Try to avoid hard to understand algorithms like the for that was used to append player 1 and 2 scores. Readability should never be neglected, it makes code easier to debug in case of issues and also improves productivity in the long term.


## Emily Bache Q-A

- How did it feel to work with such fast, comprehensive tests?
Bitter sweet, sweet to have full black box coverage on the generated scores, bitter in that they didn´t had clear facts defined.

Did you make mistakes while refactoring that were caught by the tests?
Yes, I did a typo and was adding both players score from player 1, that was caught by the tests.

If you used a tool to record your test runs, review it. Could you have taken smaller steps? Made fewer refactoring mistakes?
Not in the mistake I did, but could have used some unit tests for smaller parts for sure.

Did you ever make any refactoring mistakes and then back out your changes? How did it feel to throw away code?
It's fine I usually rollback if I could not finish something and had to context switch, no big deal.

What would you say to your colleague if they had written this code?
If he was just a college or very serious just the recommendations above. (Otherwise if he was a friend would have theatrically made like I was ripping my eyes from my face and throwing them away.) 

What would you say to your boss about the value of this refactoring work? Was there more reason to do it over and above the extra billable hour or so?
It deppends on how we take this, if it was a big project and not a so simple logic check explanation above, otherwise if that was the whole application purpose and we are pretty sure that Tennis is not gonna be changin rules soon, then I think not, proper coverage to ensure it´s fine should be enough.