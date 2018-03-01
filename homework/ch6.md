## C# Homework Ch 6
#### author: nick terry
#### date: feb 28, 2018  


1. An exception is when something goes wrong and the code youre trying to run doesnt work, the code jumps to the exception part of the code.  

2. It runs all the statements like normal.  

3. Trick question - Unhandled exceptions dont use catch mechanisms, thats the very definition of "unhandled".  

4. In unhandled exceptions if the try block is part of a method, the method exits and continues to look for a matching catch statement. It will keep exiting methods until it finds a matching catch, then continue on with the calling statement.  

5. The parent class for all exceptions is SystemException.  

6. You can determine the type of error by invoking the message property.  

7. Integer checking is a way to check integer math to keep it from overflowing.  

8. The finally block is a last resort to finish running the code even if the exception wasnt caught by catch.