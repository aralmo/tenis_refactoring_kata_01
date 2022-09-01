#Tenis 01


## step by step

- Code review (20mins)
- Added extra test coverage (30mins)
- Refactor immediate return for readability (6mins)
- Refactor function to get score points string representation (15mins)
- Tidy up (5mins)

## recommendations

- Tests seem to have too much responsability, that lead into a failing implementation on player names other than the ones expected to be used inside the test covered cases. I usually try to avoid hardcoded constats on tests if possible and use random values instead to avoid missing this kind of case. 
Tests names should be descriptive of what it´s expected to improve readability and also avoid this cases.

- To improve readability I would recommend to return immediatelly when we have a result instead of storing it into a variable and returning as last statement in the method.

- Try to avoid hard to understand algorithms like the for that was used to append player 1 and 2 scores. Readability should never be neglected, it makes code easier to debug in case of issues and also improves productivity in the long term.



