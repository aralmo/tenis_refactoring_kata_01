#Tenis 01

## step by step

(10mins)
- Added test coverage for different player names, it showed a flaw in the algorithm which had the player1 name hardcoded.
- Ran test coverage wich showed a 100% coverage on the implementation

(20mins)
- refactored the for used for calculation for both players when under winning points and different scores.



## recommendations

- While it was working, the algorithm could have been made easier to understand by extracting part of the logic into private reusable methods. That would reduce the amount of tought future developers have to put on understanding the logic.

- To improve readability, I would recommend to try to avoid storing results in fields to be returned after and instead return immediatelly. 

- May be wrong on this, but maybe the issue with the set player name being disregarded on tests was due to not following proper baby steps? If that´s the case I would recommend to do incremental steps and try to avoid covering too much on a single iteration. If the algorithm is simple enough an inside-out approach could be good too.
