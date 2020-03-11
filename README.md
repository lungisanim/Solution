#Assumptions
The outpus as understood via the question is to jumble the given string into (1) odd charecters first then even characters, the repeast as required.


#Standards

On C# Method names should start with uppercase, in here both jumbledString and repeatString start with lower case to confirm with requirements.

This could have been written in Java which has no such constraint

#Approach
In java String::repeat, in C# Linq Enumarable::Repeat could have been used (These are language library methods and recommended, however they cannot be used for very larger number of repetitions as required by the Question --(long n)--)
Hence the need for the repeatString method.
