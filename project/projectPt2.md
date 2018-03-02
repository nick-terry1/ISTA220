## Proposed Project
#### author: Nick Terry
#### date: feb 29, 2018  

##### Introduction
The project idea I chose from the my originally submitted writeup was the quiz idea. The Adventure style game was too easy for a project,
and the RPG type game was too hard and I wouldn't even come close to finishing it this class. Quiz is a hard project to do but not so hard that I wouldnt be able to 
finish it by the end of the class.  
##### General Idea
The overall idea is a quiz app with a GUI interface where upon opening the app, the user is met with a page that asks whether he would like 
to either "create a quiz" or "start the quiz" with the choice being chosen by two buttons. If the user picks the create button 
it will set a boolean value to false. This boolean value is binded to the read only property of the textbox on page one. 
It will also take you to page one. The start quiz button will only take you to page one, without changing the boolean 
variable from its default false value. Page 1 will also have four radio buttons which can also be written depending on the 
value of the boolean variable. There would be a button on the right side of the screen that would take you to the next page. 
This would continue until the user reached the last page which would contain a list of questions (the entire list would be accessed by a scrolling) along with which ones were 
answered wrong and right. The overall percentage would be shown in big bold font. To the right there would be a button that promted the user 
to go back to the main page (where he chose to create or start).
##### Optional Processes
After looking into a number of already existing quiz apps, I couldnt find any that had the ability to set a time limit to finish the quiz. 
Including this function would mean having a time picker function for hours and minutes or N/A if he didnt want to be timed. If he picked a 
time limit for the test, the time would be displayed on every page and count down. If he didnt pick a time the time would be on every page 
and count up from zero. The final page would have the total time displayed as well. If the user failed to complete the test in time, 
he would automatically be sent to the last page and all the questions that were skipped over would be counted as wrong. 

 The number of pages/questions could be either fixed or user defined. As of now the project only calls for a fixed number of pages and four 
 answers per question. The questions need to be randomized so once the next question was clicked instead of going from page to page 
 sequentially, the click event would trigger a method randomly picking a page that hasnt already been used.
 
 Lastly there could be an option of displaying hints the user could turn on or off depending on a check box at the beginning of the test (mainpage). 
 If turned on the questions would show a right or wrong answer as the user clicked it as opposed to at the end of the test. The right or wrong 
 mark could be either the word "right" or "wrong" popping up when clicked. or a green or red icon popping up. 
 ##### Conclusion
 This project seems easy at first but there has to be a fairly indepth knowledge of page layout and binding to do something like this so it 
 can function properly without errors.