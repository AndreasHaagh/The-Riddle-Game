# The-Riddle-Game

#Description
This is a game about guessing riddles on time. In the main menu of the game you can change the font color and the difficulty of the game.
The diificulty set the time and decides how hard the riddles are. The normal difficulty is the default difficulty. 

Every time the player guesses the answer of a riddle a new one shows and the score counts up.

When the time hits 0 the game will then ask if the play wishes to save the score. the score is then visibel from the main menu when typing 'High score'.

In order to end the game type end in the main menu and the program will end.

#Set up

---------- GitHub ----------

In order to get the code go to https://github.com/AndreasHaagh/The-Riddle-Game-Andreas-Flyvholm-Haagh.
Go to the code tab and press the "Clone or download" button and copy the url in the messagebox.
Then go to your favorit source control application and clone the project using the url you copied.

---------- Riddle files ----------

All the riddles are stored in some text files (EasyRiddles.txt, NormalRiddles.txt, HardRiddles.txt). 
Their "copy to output directory" propertie should be "Copy allways".

In order to add new riddles to the game. Go to one of the text file and type write "Riddles: this is a riddle Answer: this is the answer".

---------- Play the game ----------

#Up comming changes

	-Display time
		Write the time when it half way. again when it is at 15, 10, 5 seconds.

	- In game commands
		In order to run a command a "/" must be infront of the word.
		- Pause: Pauses the game until the play types "Start"
		- Hint: gives one letter of the answer every time it is run. Can be used 3 times
		- Score: Displays the curent score
		- Help: shows all the in game commands


# Made by:
Andreas Flyvholm Haagh