# CalculatorCs
This is a text based calculator in C#

# On first run
The user will be asked to either Add, Subtract, Multiply, or Divide.
The program will then check of there is any saved data if not, then it will run the normal operations.

# Normal Operations
The user will be asked to input values for both A and B, it will then take both inputs and the operation supplied in the first question and calculate the result.
The user will then be asked if they would like to save the operation.
if Yes then the result is saved in the sum varible and the saved boolean will be switched to true
if No then the program will reset.

# Saved Operations
If the program detects a saved result it will ask the user if they want to use it, if the user declines it will run the normal operations.
However if the user wishes to use a saved sum the program will run through the Saved operations and ask the user what varible to swap with the sum.
Depending on the result, it will swap either the a or b varible. and run though the normal operation.
