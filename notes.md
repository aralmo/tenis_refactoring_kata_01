#Tenis 01

## step by step

- Code review (20mins)
- Added extra test coverage (30mins)


## recommendations

- Tests seem to have too much responsability, that lead into a failing implementation on player names other than the ones expected to be used inside the test covered cases. I usually try to avoid hardcoded constats on tests if possible and use random values instead to avoid missing this kind of case. 
Tests names should be descriptive of what it´s expected to improve readability and also avoid this cases.

