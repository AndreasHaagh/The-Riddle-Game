# The-Riddle-Game

#Description
This is a game about guessing riddles on time. The more riddles the player guess correctly the bigger the scores gets.
The riddles can differ in difficulty based on what the play sets it too. 
When the time run out the player can then save the score to a high score on the local computer.

#Set up

---------- GitHub ----------

In order to get the code go to https://github.com/AndreasHaagh/The-Riddle-Game-Andreas-Flyvholm-Haagh.
Go to the code tab and press the "Clone or download" button and copy the url in the messagebox.
Then go to your favorit source control application and clone the project using the url you copied.

---------- Riddle files ----------

All the riddles are stored in some text files (EasyRiddles.txt, NormalRiddles.txt, HardRiddles.txt). 
Their "copy to output directory" propertie should be "Copy allways".

In order to add new riddles to the game. Go to one of the text file and type write "Riddles: this is a riddle Answer: this is the answer".
Also remember to write the answer with lower case letters.

Since the riddles get picked at random there is a change of the same riddle to apear multiple time in a row.
So the keep in mind the more riddles there is that less change of them apearing multiple times.

---------- Play the game ----------

When the game starts up you will be presented with a start menu. from here there is a few options

	- Play: Starts the game. write a guess to the riddle that is displayed, if it is correct it will give you a new one until the times stops.
			When the time stops press enter. Then a message apears with the score and ask if you want to save it

	- Tutorial: Start a small tutorial

	- High score: display the high scores

	- Settings: show the settings menu. here there are some more options
		- Change difficulty: changes the difficulty to either easy, normal, hard
		- Change color: changes the font color

	- Crdits: Show the credits

	- End: exits the game

#Up comming changes

	- In game commands
		In order to run a command a "/" must be infront of the word.
		- Pause: Pauses the game until the play types "Start"
		- Hint: gives one letter of the answer every time it is run. Can be used 3 times
		- Score: Displays the curent score
		- Help: shows all the in game commands


# Made by:
Andreas Flyvholm Haagh