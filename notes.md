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


